#!/bin/sh

# swap touch screen axes to support 270 degree rotation.
# the xinput call can be removed, if display is started in 0 degree rotation mode.
#input --set-prop 'ADS7846 Touchscreen' 'Coordinate Transformation Matrix'  0 1 0 -1 0 1 0 0 1

# This hides the mouse pointer.
# Unclutter needs to be installed on the system.
#unclutter -display :0 -noevents -grab

# Start the mono application.
mono ./HappyShop.ShoppingClient.exe