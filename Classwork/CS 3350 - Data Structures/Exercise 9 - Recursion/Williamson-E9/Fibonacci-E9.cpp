// Fibonacci.cpp
// Copyright by Venu Dasigi

#include <iostream>

using namespace std;

long FibRecBasic (int n)
{
	long F1, F2;
	if (n <= 1) return (n);
	else
	{
		F1 = FibRecBasic(n - 1);
		F2 = FibRecBasic(n - 2);
		return (F1 + F2);
	}
};

long FibLoopBasic (int n)
{
	long F1, F2, Fib;
	if (n < 2) return (n);
	F2 = 0;
	F1 = 1;
	for (int i = 2; i <= n; i++)
	{
		Fib = F1 + F2;
		F2 = F1;
		F1 = Fib;
	};
	return (Fib);
};

long FibRec (int n, long & pluscount)
{
	// Returns the n-th Fibonacci number, and increases the value of the output (reference)
	// parameter pluscount by the number of plus operations performed by this call.
	// ONLY thosee plus ops used in computing the Fibonacci number are counted, not any others.

	// FILL THIS IN (BUILDING ON FibRecBasic ABOVE) FOR PART c.
	// THIS WON'T BE VERY HARD, BUT WILL TAKE SOME EFFORT.
	// THE FOLLOWING RETURN STATEMENT IS FOR THE COMPILER AND WOULD CHANGE.
	long F1, F2;
	if (n <= 1) {
		return (n);
	}
	else
	{
		F1 = FibRec(n - 1, pluscount);
		F2 = FibRec(n - 2, pluscount);
		pluscount = pluscount + 1;
		return (F1 + F2);
	}
};

long FibLoop (int n, long & pluscount)
{
	// Returns the n-th Fibonacci number, and increases the value of the output (reference)
	// parameter pluscount by the number of plus operations performed by this call.
	// ONLY thosee plus ops used in computing the Fibonacci number are counted, not any others.

	// FILL THIS IN (BUILDING ON FibLoopBasic ABOVE) FOR PART c.
	// THIS WILL BE VERY/TRIVIALLY SIMPLE.
	// THE FOLLOWING RETURN STATEMENT IS FOR THE COMPILER AND WOULD CHANGE.
	long F1, F2, Fib;
	if (n < 2) return (n);
	F2 = 0;
	F1 = 1;
	for (int i = 2; i <= n; i++)
	{
		Fib = F1 + F2;
		pluscount = pluscount + 1;
		F2 = F1;
		F1 = Fib;
	};
	return Fib;
};


int main ()
{
	long FibNumRec, FibNumLoop, opsRec, opsLoop;

	cout << "n\t Fib(n)" << endl;
	for (int n = 0; n <= 40; n++)
	{
		if ((n <= 20) || (n % 5 == 0))
		{
			FibNumLoop = FibLoopBasic(n);
			cout << n << "\t " << FibNumLoop << endl;
/* UNCOMMENT THE FOLLOWING FOR PART b. */
			FibNumRec = FibRecBasic(n);
			cout << n << "\t " << FibNumRec << endl;
   /* UNCOMMENT THE ABOVE FOR PART b. */
		}
	}

/* UNCOMMENT THE FOLLOWING FOR PART c. */
	cout << "n\t ops-Rec\t ops-Loop\t Fib(n)" << endl;

	for (int n = 0; n <= 40; n++)
	{
		if ((n<=20)||(n%5==0))
		{
			opsRec = 0; opsLoop = 0;

			// For each n, the operation counters are initialized to 0, to be passed respectively 
			// to the FibRec and FibLoop functions, for counting the number of plus operations.

			FibNumRec = FibRec (n, opsRec);
			FibNumLoop = FibLoop (n, opsLoop);
			if (FibNumRec != FibNumLoop) cout << "OH, NO!  I have goofed up!" << endl;
			if (n<30)
				cout << n << "\t " << opsRec << "\t\t " << opsLoop << "\t\t " << FibNumLoop << endl;
			else
				cout << n << "\t " << opsRec << "\t " << opsLoop << "\t\t " << FibNumLoop << endl;
		}
	}
  /* UNCOMMENT THE ABOVE FOR PART c. */
}
