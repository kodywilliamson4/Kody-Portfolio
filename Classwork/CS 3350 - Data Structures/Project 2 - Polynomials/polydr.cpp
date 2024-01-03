// polydr.cpp
// Copyright by Venu Dasigi

#include "poly.h"
#include <iostream>

using namespace std;

const unsigned int MAX = 50;
void main ()
{
	// Pre: None.
	// Post: Give the user a menu of choices.
	//       Based on what command the user inputs, take
	//       the appropriate action as guaranteed by the menu.
	//       Input is accepted in a case-insensitive manner!
	poly p[MAX];
	char command;
	unsigned int i, j, k;
	float value;
	void printmenu ();

	printmenu();
	do
	{
		cin >> command;
		switch (command)
		{
		case '?':
		case 'H':
		case 'h':
			printmenu();
			break;
		case 'R':
		case 'r':
			cin >> i;
			cout << "Reading polynomial " << i << endl;
			p[i].read();
			break;
		case 'P':
		case 'p':
			cin >> i;
			cout << "Printing polynomial " << i << endl;
			p[i].write();
			break;
		case '+':
			cin >> i;
			cin >> j;
			cin >> k;
			p[k] = p[i].plus(p[j]);
			break;
		case '-':
			cin >> i;
			cin >> j;
			cin >> k;
			p[k] = p[i].minus(p[j]);
			break;
		case 'E':
		case 'e':
			cin >> i;
			cin >> j;
			p[i].evaluate(j);
			break;
// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION
// *** Think of the different cases to be covered.	***
// *** Try to make your response independent of the	***
// *** whether the command letter is in upper or	***
// *** lower case!									***
		};
	}
	while ((command != 'Q') && (command != 'q'));
};

void printmenu ()
{
	// Pre: None.
	// Post: Print a menu of choices.

// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION
	cout << "Available commands:" << endl
		<< "?: to print this menu" << endl
		<< "H: to print this menu" << endl
		<< "R n: to read a value for polynomial n" << endl
		<< "P n: to print the value of polynomial n" << endl
		<< "+ i j k: to add polynomials i and j and store result in k" << endl
		<< "E n v: to evaluate polynomial n with its variable set to value v" << endl
		<< "Q: to quit" << endl;
};
