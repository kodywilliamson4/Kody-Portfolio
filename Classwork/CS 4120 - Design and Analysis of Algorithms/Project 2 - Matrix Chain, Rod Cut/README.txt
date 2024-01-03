Within this zip file are 4 different programs, 4 different executables, the datasets I used for my trials, the results in an excel format, a log file, a project report, and this README.

Creating the executables/compiling:
1. Enter the main directory containing all of the .cpp files: /home/90/kodyw/williamson_p2/
2. Select which algorithm you wish to compile and then type g++ -o ROD_CUT ROD_CUT.cpp CStopWatch.cpp, replacing ROD_CUT with MATRIX_CHAIN if you wish to run that instead
3. This will create an executable named after the algorithm you selected follow the steps below to execute it

Running the executables once they are made:
1. Select which executable you want to run. Each executable aligns with either rod cut or matrix chain.
2. Once you have decided which of the four you want to run, type ./ROD_CUT but change ROD_CUT with MATRIX_CHAIN if you wish to execute that instead.
3. You will receive a command prompt asking you to specify the n which is the number of arguments. Enter how many items are in the array you are going to enter. You will then be asked
to enter the array which needs to be integers with each one separated by a space. Then hit enter.
4. The program will run the algorithm corresponding to the name on the executable and give you the desired results for each.

--------//EXAMPLES OF ABOVE//--------
~$ cd williamson_p1/
~/williamson_p1$ g++ -o ROD_CUT ROD_CUT.cpp CStopWatch.cpp
~/williamson_p1$ ./ROD_CUT
Input argument n: 5
Input 5 numbers: 1 3 8 13 15

**WARNING** The code for MATRIX_CHAIN cannot run on bglinux above 6 inputs but runs on my local machine fine with a larger buffer selected.