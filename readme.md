# RoboGUI
A GUI For Controlling a Zumo/Arduino Rescue Robot
----
## About
----
This is a simple GUI designed in C# using Windows Forms that allows you to control a Zumo/Arduio via an XBee wireless communication module (connected to serial port COM5).

The window uses two main panels:
- A control panel containing buttons.
- A Serial Window to print the output from the robot.

----
## Controls
----
The robot can be controlled manually after enabling the controls via buttonA being activated, by clicking the appropriately named buttons to:
- Drive forward
- Turn left/right
- Reverse

Alternatively the robot can be controlled by using the WASD keys to also perform the appropriate manouvers:
- W (Forward)
= A/D (Left/Right)
- S (Reverse)
- X (Exit)

The robot can also be switched in & out of automatic mode, as appropriate depending on the situation as well, again using the appropriate buttons or by using the assigned keys.
- G (Turn on Auto Mode)
- H (Turn off Auto Mode)

----

## Serial Box
----
The Serial Box will continously update with any data recieved from the Arduino/Zumo no matter if a key was pressed or not.

This allows for a continous stream of updates on the robots sensors as they are called to allow the user to control the robot more efficiently and avoid mistakes.