# Putty-HyperTerminal-Automation-Coop-Project-
The application allows resetting, recovering and configuring multiple routers and switches. 
HyperTerminal & PuTty Automation

Project

The project is a Windows Application that allows the user to reset and configure routers and switches automatically. It also allows the user to recover passwords of routers and switches, when the password is unknown. The code is written in C# and can be run on Visual Studio. The program resets and recovers passwords with a simple click, skipping the process of running commands. The purpose of this project is to ease-up and speed-up the process of setting-up Networking labs for upcoming classes.

Features

•	The user can erase and reload the routers and switches with a single click, instead of manually typing-in the commands.
•	The application connects to the right port and runs the specified commands.
•	Users can directly run HyperTerminal and PuTTy from the application.
•	In case of unknown password set-up on any router and switch, the application allows the user to recover passwords ad reset the same for future use.
•	Easy to use interface and architecture. 


Installation

Installation and setting-up of the software:

1.	First, you need to ensure the system has a .NET framework, Windows 7 or above, and Visual Studio installed.
2.	Second, user has to download the zipped folder of the application and extract all the files and solution.
3.	Third, once the extraction and system set-up is done, we need to build the solution. To do this,
File -> Open -> Project -> HyperTerminalAndPuttyAutomation -> Build -> Build Solution
4.	Fourth, to run the application, follow these steps:
•	Open the HyperTerminalAndPuttyAutomation folder
•	Go to PuttyAutomation_1 folder -> bin -> Debug -> PuttyAutomation_2.exe
•	Run this application file
•	For ease, right-click the PuttyAutomation_2.exe -> Create Shortcut and put it on the Desktop.
•	Simply, run the application to execute.


User Guide

Case 1: Router or Password has the ‘Cisco + Class’ password combination

•	Run the application.
•	Check the port you’re connected to
•	Fill the port number in the textbox (it is not case sensitive)
•	Press the ‘Execute’ button
•	Wait for commands to run
•	After 30 seconds, close the application
•	Restart the application and this time, press the “Run HyperTerminal” or “Run Putty” button
•	Check if the erasing and reloading succeeded.

Case 2: Unknown password setup on Routers

•	Check the port you’re connected to
•	Restart the specific router from the button manually
•	Run the application.
•	Fill the port number in the textbox( it is not case sensitive)
•	Press “Router Password Reset” button
•	Wait for the commands to run. (It takes 6-7 minutes)
o	Tip: It may show app not responding, but it works fine on the backend, so let it run without disrupting.
•	Once the app responds, close the application.
•	Restart the application and this time, press the “Run HyperTerminal” or “Run Putty” button
•	Check if the password is recovered or not.

Case 3: Unknown password setup on a Switch

•	Check the port you’re connected to
•	Restart the specific switch from the button manually
•	Hold press the button, unplug and re-plug the power cable and wait until all lights go off. Once all lights turn down, let go off the button.
•	Run the application.
•	Fill the port number in the textbox( it is not case sensitive)
•	Press “Switch Password Reset” button
•	Wait for the commands to run. (It takes 3-5 minutes)
o	Tip: Once again, it may show app not responding, but it works fine on the backend, so let it run without disrupting.
•	Once the app responds, close the application.
•	Restart the application and this time, press the “Run HyperTerminal” or “Run Putty” button
•	Check if the password is recovered or not.
