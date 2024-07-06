# TapoSmartBattery

TapoSmartBattery helps keep your laptop battery within a set range of charge percentage to maintain the health of your battery, by turning a [Tapo smart plug](https://www.tapo.com/uk/product/smart-plug/) on and off when certain battery percentages are reached.

![TapoSmartBattery_screenshot](https://github.com/allthefurlongs/TapoSmartBattery/assets/20117345/6ec59115-c4f5-4f99-b3bd-64c63a41bfb6)

In many modern battery chemistries, keeping charge level away from extremes of 0% or 100% can help prolong battery life. For many laptop batteries, keeping the charge level closer to 50% can be a better sweet spot. Furthermore, keeping a laptop battery constantly charged to 100%, such as when you keep the power cable plugged in all the time, can over a long period sometimes cause battery swelling, a dangerous condition that can lead to thermal runaway, fire, or explosion. Batteries can vary, and if you are unsure of the best way to safely care for a given battery then you should seek a professional opinion. The software authour accepts no responsibility for the use of this software, or any decisions taken about battery care as a result of downloading it.

Plug your laptop's charger into the Tapo smart plug, and be sure the laptop charger's maximum current draw does not exceed any limits on the plug model you have chosen (most are perfectly capable of handling a laptop but no guarantees can be given here), and plug the smart plug into the outlet.

Once you have setup the plug in the Tapo app, go to the device settings and select "Device Info" to get the IP address of the plug on your local home network.

Select the plug model from the drop down, and enter the IP address, and your Tapo username and password. The software will connect directly to the plug on your local network, authenticate to it, and then turn it on or off  when the min/max charge percentage you have entered are reached.
