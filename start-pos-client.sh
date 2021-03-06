#!/bin/sh -e

trap "{ sleep 10; /sbin/reboot }" INT TERM

while :
do
  git checkout . && git pull
  xbuild HappyShopShoppingClient.sln /p:Configuration=Release /t:Rebuild
  (cd HappyShop.ShoppingClient/bin/Release && chmod +x xinit-startup.sh && xinit ./xinit-startup.sh)
done

exit 0
