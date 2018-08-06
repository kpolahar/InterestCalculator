# About InterestCalculator

The purpose of this project is for me to demonstrate my skills, coding style, and perhaps most importantly, my work process, to a potential employer and their development team, to help them determine whether or not I would be a good fit for their team and its needs.

The coding challenge focuses in particular on test-driven development (TDD), though it does not specify a particular testing framework which must be used. It is apparent that one particular skill set which is important to this team is a level of familiarity and capability with at least some form of unit testing. The document also mentions the important of a firm grasp on SOLID programming principles.

# To Run

### Prerequisites

Visual Studio 2017 (This program was written on my Macbook Pro, which runs 2017 Community)
If you do not already have Visual Studio 2017 installed, installation links and instructions can be found [here](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio).

### Running the Project

 - Open your command prompt or terminal and navigate into the directory where you would like to clone the InterestCalculator repository
 - Run the following commands
 - git clone https://github.com/kpolahar/InterestCalculator.git
 - Open Visual Studio 2017
 - File -> Open -> [Directory where you put the InterestCalculator repository] -> InterestCalculator.sln

The focus of this project is on unit testing, so there isn't really a front end, even though this is an MVC project (because, theoretically, in my magical imaginary future free time, I'd like to make a front end for it).

Tests created for normal unit testing purposes follow the same folder structure of the InterestCalculator project. Tests created for the purpose of meeting the direct requirements of this coding challenge's assignment reside within a single file, 'AssignedTests.cs'. Each testing scenario has its own class wrapper within this file, to help with clarity. Variables needed for these tests were initialized within constructors for these classes and used by various test methods in these classes. All constructors and methods were tested prior to the construction of this 'AssignedTests.cs' file with individual unit tests, which reside in the remainder of the InterestCalculatorTests project.


Please feel free to email me at *kpolahar@gmail.com* if you have any questions! ^_^

Thanks,
Kate