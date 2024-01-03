#include <cassert>
#include <iostream>
#include "poly.h"

using namespace std;

poly::poly()
{
// Pre: None.
// Post: A basic "zero" polynomial object is created
// with zero terms.

	variable = 'x';
	terms = new node;
};

void poly::copy (const poly & p)
{
	// Pre: p is a valid polynomial.
	// Post: p is copied into the implicit parameter.
	
	variable = p.variable;
	terms = new node;
	terms->set_link(NULL);
	node* headptr = terms;
	node* tailptr = NULL;
	list_copy(p.terms->link(), headptr, tailptr);
	terms = headptr;
};

poly::poly (const poly & p) //DEEP COPY SEMANTICS
{
	// Pre: p is a valid polynomial.
	// Post: p is copied into the implicit parameter
	// using "deep copy semantics."

	copy (p);
};

void poly::free (void)
{
	// Pre: The implicit parameter has been allocated.
	// Post: Any necessary deallocation is done.

	node* headptr = terms;
	list_clear(headptr);
	delete [] terms;
	terms = NULL;
};

poly::~poly (void)
{
	// Pre: The implicit parameter has been allocated.
	// Post: Any necessary deallocation is done.

	free ();
};

poly & poly::operator= (const poly & p) //DEEP COPY SEMANTICS
{
	// Pre: p is a valid polynomial.
	// Post: The value of p is assigned to the implicit parameter
	// by "deep copy semantics."  Any necessary deallocation is
	// done along the way.

	if (this != &p)
	{
		free ();
		copy (p);
	};
	return (*this);
};


void poly::InsertTermSorted (term t)
{
	// Pre: Implicit parameter is a valid polynomial NOT
	// containing any term with the same exponent as t.
	// Post: The new term t is inserted into the implicit
	// parameter polynomial, making sure the terms are in
	// decreasing order of exponents.  In the process, the
	// polynomial is "expanded" if necessary.
	// Insertion is made by finding the right position,
	// starting at the end; this is good for efficiency of
	// addition, etc.

	node* headptr = terms->link();
	list_insert_sorted(headptr, t);
	terms = headptr;
};

void poly::read ()
{
	// Pre: None.
	// Post: A new value is read into the implicit paramter polynomial,
	// per instructions as given out first.  The terms are stored in
	// decreasing order of exponents.  If necessary, the old value is destroyed.

	poly temp;
	int coeff;
	int exp;
	cout << "Input a polynomial by first specifying the variable and then the terms in any order." << endl
		<< "Each term is specified by an integer coefficient and" << endl
		<< "a non-negative integer exponent." << endl
		<< "Indicate END by specifying a dummy term with" << endl
		<< "a zero coefficient and/or a negative exponent." << endl;

	cin >> temp.variable;
	do
	{
		cin >> coeff;
		if (coeff)
		{
			cin >> exp;
			if (exp >= 0)
				temp.InsertTermSorted(term(coeff, exp));
		}
		else
			while (cin && (cin.peek() != '\n')) cin.ignore();
	} while (coeff && (exp >= 0));
	*this = temp; // The assignment operator is being called here!
};

void poly::write() const
{
	// Pre: The implicit parameter is a valid polynomial.
	// Post: The polynomial represented by the implicit parameter is
	// printed out on the standard output.  The variable is used as stored.

// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION
	node* headptr = terms;
	int nterms = list_length(headptr);
	
	for (int i = 0; i < nterms; i++)
	{
		if (i != 0 && headptr->data().sign() != '-')
		{
			cout << headptr->data().sign();
		}
		cout << headptr->data().coeff;
		if (i + 1 != nterms)
		{
			cout << variable << headptr->data().exp << " ";
		}
		headptr = headptr->link();
	}
	cout << endl;
};

poly poly::plus (poly & right) const
{
	// Pre: The implicit parameter and the parameter right are valid
	// ploynomials.
	// Post: The sum of the two parameters is returned by plus.

// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION

	node* cursor1 = terms;
	node* cursor2 = right.terms;
	node* temp = NULL;
	node* temp3 = NULL;
	poly tempP = right;
	term *temp2;
	temp2 = new term(0, 0);
	int len1 = list_length(cursor1);
	int len2 = list_length(cursor2);
	int sLength;
	bool first = true;
	int num = 0;
	bool found = false;

	//Checking matching variables
	if (variable != variable)
	{
		cout << "Sorry, this program can only add polynomials of the same variable.";
	}
	else {

		for (int i = 0; i < len1; i++)
		{
			cursor2 = tempP.terms;
			len2 = list_length(tempP.terms);
			found = false;
			for (int j = 0; j < len2; j++)
			{
				if (cursor1->data().exp == cursor2->data().exp)
				{
					found = true;
					temp2->exp = cursor2->data().exp;
					temp2->coeff = cursor2->data().coeff + cursor2->data().coeff;
					temp->set_data(temp);
					list_insert_sorted(tempP.terms, temp2);
				}
				cursor2 = cursor2->link();
			}
			cursor1 = cursor1->link();
		}
	}
	return tempP;
};

//poly poly::minus(poly& right) const
//{
//	// Pre: The implicit parameter and the parameter right are valid
//	// ploynomials.
//	// Post: The sum of the two parameters is returned by plus.
//
//// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION
//
//	//Checking matching variables
//	if (variable != variable)
//	{
//		cout << "Sorry, this program can only add polynomials of the same variable.";
//	}
//	else {
//		node* cursor1 = terms;
//		node* cursor2 = right.terms;
//		node* temp = NULL;
//		node* temp3 = NULL;
//		int len1 = list_length(cursor1);
//		int len2 = list_length(cursor2);
//		int sLength;
//		bool first = true;
//		int num = 0;
//
//		for (int i = 0; i < len1; i++)
//		{
//			cursor2 = right.terms;
//			for (int j = 0; j < len2; j++)
//			{
//				if (cursor1->data().exp == cursor2->data().exp)
//				{
//					num = cursor1->data().coeff - cursor2->data().coeff;
//					term temp2;
//					temp2.coeff = num;
//					temp2.exp = cursor1->data().exp;
//					if (first = true)
//					{
//						list_head_insert(temp, temp2);
//						first = false;
//						temp3 = temp;
//					}
//					else
//					{
//						list_insert_sorted(temp, temp2);
//					}
//
//				}
//				else
//				{
//
//				}
//				cursor2 = cursor2->link();
//			}
//			cursor1 = cursor1->link();
//		}
//		cursor1 = cursor1->link();
//		cursor2 = cursor2->link();
//		int lTemp = list_length(temp);
//		for (int k = 0; k < len1; k++)
//		{
//			for (int l = 0; l < len2; l++)
//			{
//				for ()
//			}
//		}
//	}
//	return temp;
//};

float poly::evaluate (float value) const
{
	// Pre: The implicit parameter is a valid polynomial.
	// Post: The value of the polynomial with the value substituted for the variable is returned.

// *DO: FILL IN WITH AN APPROPRIATE IMPLEMENTATION
	float total = 0.0;
	float current = 0;
	node* headptr = terms;
	int nterms = list_length(headptr);

	for (int i = 0; i < nterms; i++)
	{
		for (int j = 0; j < headptr->data().exp; j++)
		{
			current = current * value;
		}
		current = headptr->data().coeff * current;
		total = total + current;
		headptr = headptr->link();
	}
	return total;
};