//Help with reading and importing data from: http://www.cplusplus.com/forum/beginner/113789/
//Also help from: http://www.cplusplus.com/forum/beginner/17845/

long long int insertionsort(int A[], int n);

#include <algorithm>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include "CStopWatch.h"

using namespace std;

int main()
{
	//Creating variables
	int rand1[10000];
	int rand2[20000];
	int rand4[40000];
	int rand8[80000];
	string filename;
	string fullfile;
	int number;
	long long int count;
	CStopWatch timer;

	//Getting file destination
	cout << "Input destination of files: ";
	getline(cin, filename);

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	//Rand 10000
	fullfile = filename + "RAND-10000.txt";
	ifstream in(fullfile.c_str());

	for(int i = 0; i < 10000; i++)
	{
		in >> number;
		rand1[i] = number;
	}

	in.close();

	timer.startTimer();
	count = insertionsort(rand1, 10000);
	timer.stopTimer();

	cout << "10000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rand 20000
	fullfile = filename + "RAND-20000.txt";
	ifstream in2(fullfile.c_str());

	for (int i = 0; i < 20000; i++)
	{
		in2 >> number;
		rand2[i] = number;
	}

	in2.close();

	timer.startTimer();
	count = insertionsort(rand2, 20000);
	timer.stopTimer();

	cout << "20000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rand 40000
	fullfile = filename + "RAND-40000.txt";
	ifstream in3(fullfile.c_str());

	for (int i = 0; i < 40000; i++)
	{
		in3 >> number;
		rand4[i] = number;
	}

	in3.close();

	timer.startTimer();
	count = insertionsort(rand4, 40000);
	timer.stopTimer();

	cout << "40000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rand 80000
	fullfile = filename + "RAND-80000.txt";
	ifstream in4(fullfile.c_str());

	for (int i = 0; i < 80000; i++)
	{
		in4 >> number;
		rand8[i] = number;
	}

	in4.close();

	timer.startTimer();
	count = insertionsort(rand8, 80000);
	timer.stopTimer();

	cout << "80000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	//Sort 10000
	fullfile = filename + "SORTED-10000.txt";
	ifstream in5(fullfile.c_str());

	for (int i = 0; i < 10000; i++)
	{
		in5 >> number;
		rand1[i] = number;
	}

	in5.close();

	timer.startTimer();
	count = insertionsort(rand1, 10000);
	timer.stopTimer();

	cout << "10000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Sort 20000
	fullfile = filename + "SORTED-20000.txt";
	ifstream in6(fullfile.c_str());

	for (int i = 0; i < 20000; i++)
	{
		in6 >> number;
		rand2[i] = number;
	}

	in6.close();

	timer.startTimer();
	count = insertionsort(rand2, 20000);
	timer.stopTimer();

	cout << "20000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Sort 40000
	fullfile = filename + "SORTED-40000.txt";
	ifstream in7(fullfile.c_str());

	for (int i = 0; i < 40000; i++)
	{
		in7 >> number;
		rand4[i] = number;
	}

	in7.close();

	timer.startTimer();
	count = insertionsort(rand4, 40000);
	timer.stopTimer();

	cout << "40000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Sort 80000
	fullfile = filename + "SORTED-80000.txt";
	ifstream in8(fullfile.c_str());

	for (int i = 0; i < 80000; i++)
	{
		in8 >> number;
		rand8[i] = number;
	}

	in8.close();

	timer.startTimer();
	count = insertionsort(rand8, 80000);
	timer.stopTimer();

	cout << "80000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	//Rev 10000
	fullfile = filename + "REVERSED-10000.txt";
	ifstream in9(fullfile.c_str());

	for (int i = 0; i < 10000; i++)
	{
		in9 >> number;
		rand1[i] = number;
	}

	in9.close();

	timer.startTimer();
	count = insertionsort(rand1, 10000);
	timer.stopTimer();

	cout << "10000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rev 20000
	fullfile = filename + "REVERSED-20000.txt";
	ifstream in10(fullfile.c_str());

	for (int i = 0; i < 20000; i++)
	{
		in10 >> number;
		rand2[i] = number;
	}

	in10.close();

	timer.startTimer();
	count = insertionsort(rand2, 20000);
	timer.stopTimer();

	cout << "20000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rev 40000
	fullfile = filename + "REVERSED-40000.txt";
	ifstream in11(fullfile.c_str());

	for (int i = 0; i < 40000; i++)
	{
		in11 >> number;
		rand4[i] = number;
	}

	in11.close();

	timer.startTimer();
	count = insertionsort(rand4, 40000);
	timer.stopTimer();

	cout << "40000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Rev 80000
	fullfile = filename + "REVERSED-80000.txt";
	ifstream in12(fullfile.c_str());

	for (int i = 0; i < 80000; i++)
	{
		in12 >> number;
		rand8[i] = number;
	}

	in12.close();

	timer.startTimer();
	count = insertionsort(rand8, 80000);
	timer.stopTimer();

	cout << "80000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Ident 10000
	fullfile = filename + "IDENTICAL-10000.txt";
	ifstream in13(fullfile.c_str());

	for (int i = 0; i < 10000; i++)
	{
		in13 >> number;
		rand1[i] = number;
	}

	in13.close();

	timer.startTimer();
	count = insertionsort(rand1, 10000);
	timer.stopTimer();

	cout << "10000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Ident 20000
	fullfile = filename + "IDENTICAL-20000.txt";
	ifstream in14(fullfile.c_str());

	for (int i = 0; i < 20000; i++)
	{
		in14 >> number;
		rand2[i] = number;
	}

	in14.close();

	timer.startTimer();
	count = insertionsort(rand2, 20000);
	timer.stopTimer();

	cout << "20000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Ident 40000
	fullfile = filename + "IDENTICAL-40000.txt";
	ifstream in15(fullfile.c_str());

	for (int i = 0; i < 40000; i++)
	{
		in15 >> number;
		rand4[i] = number;
	}

	in15.close();

	timer.startTimer();
	count = insertionsort(rand4, 40000);
	timer.stopTimer();

	cout << "40000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	//Ident 80000
	fullfile = filename + "IDENTICAL-80000.txt";
	ifstream in16(fullfile.c_str());

	for (int i = 0; i < 80000; i++)
	{
		in16 >> number;
		rand8[i] = number;
	}

	in16.close();

	timer.startTimer();
	count = insertionsort(rand8, 80000);
	timer.stopTimer();

	cout << "80000" << ", " << count << ", " << timer.getElapsedTimeInMilliSec() << endl;

	cin.ignore();
	return 0;
}

long long int insertionsort(int A[], int n)
{
	int key;
	int i;
	long long int count = 0;
	for (int j = 1; j < n; j++)
	{
		key = A[j];
		i = j - 1;
		while ((i >= 0) && ++count && (A[i] > key))
		{
			A[i + 1] = A[i];
			i = i - 1;
		}
		A[i + 1] = key;
	}

	return count;
}