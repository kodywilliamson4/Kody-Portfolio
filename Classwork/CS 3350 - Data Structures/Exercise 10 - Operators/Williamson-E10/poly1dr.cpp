// polydr.cpp
// Copyright by Venu Dasigi

#include "poly1.h"
#include <iostream>
//#include <fstream>
//#include <string>

using namespace std;

void eat_white (istream & in)
/* Pre: "in" is a valid input file stream.
Post: Any white space skipped over to EOF or the next non-white space character.*/
{
  while ((in.peek()!=EOF) && isspace(in.peek())) in.ignore();
};

const unsigned int MAX = 100;
int main ()
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
	    eat_white (cin);
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
			    eat_white (cin);
				cout << "Reading polynomial " << i <<endl;
				cin >> p[i];
				break;
			case 'P':
			case 'p':
				cin >> i;
				cout << "Printing polynomial " << i << ": " << p[i] << endl;
				// OR SIMPLY: cout << p[i];
				break;
			case '+':
				cin >> i >> j >> k;
				cout << "Printing the sum of the number " << i <<
				  " and polynomial " << j << ": " << i+p[j] << endl;
				cout << "Now, printing the sum of polynomial " << i <<
				  " and the number " << j << ": " << p[i]+j << endl;
				cout << "The sum of polynomials " << i <<
				  " and "<< j <<" is being saved in polynomial "
				     << k << endl;
				p[k] = p[i] + p[j];
				break;
			case '-':
				cin >> i >> j >> k;
				cout << "Printing the difference of the number " << i <<
				  " and polynomial " << j << ": " << i-p[j] << endl;
				cout << "Now, printing the difference of polynomial " << i <<
				  " and the number " << j << ": " << p[i]-j << endl;
				cout << "The difference of polynomials " << i <<
				  " and "<< j <<" is being saved in polynomial "
				     << k << endl;
				p[k] = p[i] - p[j];
				break;
			case 'E':
			case 'e':
				cin >> i >> value;
				cout <<"The polynomial " << i <<" evaluated at "
				     << value << " equals ";
				cout << p[i].evaluate(value) <<endl;
				break;
			case 'Q':
			case 'q':
			  cout << "Thank you.  Bye!" << endl;
				break;
			default:
				cout << "Enter a valid command.  Type H or ? for help."
					<< endl;
		};
	}
	while ((command != 'Q') && (command != 'q'));
	return (0);
};

void printmenu ()
{
	// Pre: None.
	// Post: Print a menu of choices.
	cout
		<< "Available commands:\n"
		<< "?: to print this menu\n"
		<< "H: to print this menu\n"
		<< "R n: to read a value for polynomial n, per instructions:" << endl;
	cout << "Input a polynomial by specifying the variable and all terms in any order." << endl
		<< "Each term is specified by an integer coefficient and" << endl
		<< "a non-negative integer exponent." << endl
		<< "Indicate END by specifying a dummy term with" << endl
		<< "a zero coefficient and/or a negative exponent." << endl;

	cout
		<< "P n: to print the value of polynomial n\n"
		<< "+ i j k: to add polynomials i and j and store result in k\n"
		<< "- i j k: to subtract polynomials j from i and store result in k\n"
		<< "E n v: to evaluate polynomial n with its variable set to value v\n"
/*		<< "* i j k: to multiply polynomials i and j and store result in k\n"
*/
		<< "Q: to quit\n";
};
