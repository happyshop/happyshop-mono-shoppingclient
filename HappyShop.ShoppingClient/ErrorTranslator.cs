using System;
using System.Collections.Generic;
using System.Net;

namespace HappyShop.ShoppingClient
{
  static public class ErrorTranslator
  {
    private const string _defaultMessage = "Es gab einen internen Fehler. Ihr braucht nicht Bescheid zu geben, da eine Mail an das Spitzen-Entwickler-Team versandt wurde :-)";
    private static readonly Dictionary<Type, Func<Exception, string>> _handlers = new Dictionary<Type, Func<Exception, string>>
                                                                              {
                                                                                {typeof( WebException ), MessageFromWebException},
                                                                                {typeof( UnknownItemException ), SimpleExceptionMessage},
                                                                              };
 
    public static string Translate(Exception exception)
    {
      Func<Exception, string> handler;
      if( _handlers.TryGetValue(exception.GetType(), out handler) )
      {
        return handler(exception);
      }
      return _defaultMessage;
    }

    private static string SimpleExceptionMessage(Exception exception)
    {
      return exception.Message;
    }


    private static string MessageFromWebException(Exception exception)
    {
      WebException typedException = (WebException)exception;
      switch( typedException.Status )
      {
        case WebExceptionStatus.Success:
          return "Alles gut";
        case WebExceptionStatus.NameResolutionFailure:
        case WebExceptionStatus.ConnectFailure:
        case WebExceptionStatus.ReceiveFailure:
        case WebExceptionStatus.SendFailure:
        case WebExceptionStatus.PipelineFailure:
        case WebExceptionStatus.RequestCanceled:
        case WebExceptionStatus.ConnectionClosed:
        case WebExceptionStatus.Timeout:
          return "Leider gibt es Netzwerkprobleme :-(";
        default:
          return _defaultMessage;
      }
    }
  }
}