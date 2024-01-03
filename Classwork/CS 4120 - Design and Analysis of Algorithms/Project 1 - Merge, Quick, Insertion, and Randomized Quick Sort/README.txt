Within this zip file are 4 different programs, 4 different executables, the datasets I used for my trials, the results in an excel format, a log file, a project report, and this README.

Creating the executables/compiling:
1. Enter the main directory containing all of the .cpp files: /home/90/kodyw/williamson_p1/
2. Select which algorithm you wish to compile and then type g++ -o ALGORITHM ALGORITHM.cpp CStopWatch.cpp, replacing ALGORITHM with the name of the algorithm you with to compile
3. This will create an executable named after the algorithm you selected follow the steps below to execute it

Running the executables once they are made:
1. Select which executable you want to run. Each executable aligns with a different sorting algorithm between merge sort, insertion sort, quick sort, and randomized quick sort.
2. Once you have decided which of the four you want to run, type ./ALGORITHM and but change ALGORITHM with the name of the algorithm you wish to execute
3. You will receive a command prompt asking you to specify the path to the directory containing the data files used. My input of the path looked like this:
	/home/90/kodyw/williamson_p1/DataSets/
4. The program will run the sorting algorithm corresponding to the name on the executable and give you the n used, the number of comparisons, and the time taken in milliseconds.
5. Press enter to end the program.

--------//EXAMPLES OF ABOVE//--------
~$ cd williamson_p1/
~/williamson_p1$ g++ -o INSERTIONSORT INSERTIONSORT.cpp CStopWatch.cpp
~/williamson_p1$ ./INSERTIONSORT
Input destination of files: /home/90/kodyw/williamson_p1/DataSets/

Other algorithms run by swapping in MERGESORT, QUICKSORT, or RANDOMIZED_QUICKSORT

NOTE: DataSets folder was generated using provided Java program