using System;
using System.Collections.Generic;
using System.Xml;
using HappyShop.ServiceConnector;
using log4net;

namespace HappyShop.ShoppingClient
{
  public class ErrorProvider : IErrorProvider
  {
    private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    private static readonly List<Type> s_exceptionsNotToBeMailed = new List<Type>{typeof(UnknownItemException)};  
    private readonly List<Action<Exception>> _errorContinuationActions = new List<Action<Exception>>();

    public ErrorProvider WithContinuationAction(Action<Exception> action)
    {
      _errorContinuationActions.Add(action);
      return this;
    }

    private bool IsIgnoredException(Exception exception)
    {
      return s_exceptionsNotToBeMailed.Contains(exception.GetType());
    }

    public void SendMail(string subject, string message)
    {
      try
      {
        new ErrorDispatcher((string)Configuration.Static.Merged.ErrorDispatcherTarget)
          .AddRecipients((string)Configuration.Static.Merged.ExceptionRecipientSemicolonSeparatedList)
          .AddSubject(string.Format("{0}: {1}.", GetType().AssemblyQualifiedName, subject))
          .AddMessage(message)
          .Dispatch();
      }
      catch (Exception mailException)
      {
        Log.Error("Failed to send exception mail.", mailException);
      }
    }

    private void SendMail(Exception exception, string message)
    {
      if( ! IsIgnoredException(exception) && XmlConvert.ToBoolean((string)Configuration.Static.Merged.ErrorMailingOn))
      {
        try
        {
          new ErrorDispatcher((string)Configuration.Static.Merged.ErrorDispatcherTarget)
            .AddRecipients((string)Configuration.Static.Merged.ExceptionRecipientSemicolonSeparatedList)
            .AddSubject(string.Format("{0}: {1}.", GetType().AssemblyQualifiedName, message))
            .AddMessage(exception.ToString())
            .Dispatch();
        }
        catch( Exception mailException )
        {
          Log.Error("Failed to send exception mail.", mailException);
        }
      }
    }

    public void Error(Exception exception, string format, params object[] args)
    {
      string message = string.Format(format, args);
      Log.Error(message, exception);
      SendMail(exception, message);
    
      try
      {
        _errorContinuationActions.ForEach(action => action(exception));
      }
      catch( Exception ex)
      {
        Log.Error("Failed to execute continuation actions", ex);
      }
    }

    public void Error(Exception exception)
    {
      Error(exception, "Exception occurred");
    }

    public void DoWith(Action actionWithErrorHandling)
    {
      DoWith(actionWithErrorHandling, "error occurred");
    }

    public void DoWith(Action actionWithErrorHandling, string format, params object[] args)
    {
      try
      {
        actionWithErrorHandling();
      }
      catch( Exception exception)
      {
        Error(exception, format, args);
      }
    }
  }
}