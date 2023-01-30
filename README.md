# Toy Robot

##Prerequisites:
Install .Net 7 Framework and Visual Studio (IDE)

##Steps for using this repository : 

1) Clone the repository to your local system with command - git clone https://github.com/rumpiguha/toy-robot.git

2) Navigate to the root directory - cd ToyRobot 

3) Input files are in the ToyRobot\Resources\Input folder. 
   Feel free to add a few more cases there. Any text file would work, similar to the sample cases 1 to 6.
   
4) Run the project by executing this command from the project root directory : 
   dotnet run
   
   The output for each case will be displayed in the console.

##Architectural Summary

.NetCore 7 Console application with Unit test using MS Test Framework.

The solution consist of 2 projects- Toy Robot and respective Test Project.

Input from text file is passed onto Program Main method which validates the input command and executes on the Robot instance.

##Application Purpose

The coding challenge is to build a Robot app that executes given valid command to change its position
