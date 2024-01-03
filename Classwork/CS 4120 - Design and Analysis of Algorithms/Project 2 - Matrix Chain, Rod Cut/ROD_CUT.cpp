#include <algorithm>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include "CStopWatch.h"
#include <math.h>

using namespace std;

int cut_rod(vector<int> p, int n);
int memoized_cut_rod(vector<int> p, int n);
int memoized_cut_rod_aux(vector<int> p, int n, vector<int> r);
int bottom_up_cut_rod(vector<int> p, int n);

int main()
{
	//Creating variables
	CStopWatch timer1;
	CStopWatch timer2;
	CStopWatch timer3;
	int input;
	int price1;
	int price2;
	int price3;
	
	//Getting argument size
	int n;
	cout << "Input argument n: ";
	cin >> n;

	//Creating array
	vector<int> p;
	cout << "Input " << n << " numbers: ";

	for (int i = 0; i < n; i++) {
		cin >> input;
		p.push_back(input);
	}

	//////////////////////////////////////Calling Functions////////////////////////////////////////////

	//Cut rod
	timer1.startTimer();
	price1 = cut_rod(p, n);
	timer1.stopTimer();
	cout << price1 << ", " << timer1.getElapsedTimeInMilliSec() <<endl;

	//Memoized
	timer2.startTimer();
	price2 = memoized_cut_rod(p, n);
	timer2.stopTimer();
	cout << price2 << ", " << timer2.getElapsedTimeInMilliSec() << endl;

	//Bottom up
	timer3.startTimer();
	price3 = bottom_up_cut_rod(p, n);
	timer3.stopTimer();
	cout << price3 << ", " << timer3.getElapsedTimeInMilliSec() << endl;


	return 0;
}

int cut_rod(vector<int> p, int n)
{
	int q;
	if (n == 0)
	{
		return 0;
	}

	q = -999999999;
	for (int i = 1; i <= n; i++)
	{
		q = max(q, p[i-1] + cut_rod(p, n - i));
	}

	return q;
}

int memoized_cut_rod(vector<int> p, int n)
{
	vector<int> r;
	for (int i = 0; i < n+1; i++)
	{
		r.push_back(-999999999);
	}

	return memoized_cut_rod_aux(p, n, r);
}

int memoized_cut_rod_aux(vector<int> p, int n, vector<int> r)
{
	int q;
	if (r[n] >= 0)
	{
		return r[n];
	}
	if (n == 0)
	{
		q = 0;
	}
	else
	{
		q = -999999999;
		for (int i = 0; i < n; i++)
		{
			q = max(q, p[i] + memoized_cut_rod_aux(p, n - i - 1, r));
		}
	}
	r[n] = q;
	return q;
}

int bottom_up_cut_rod(vector<int> p, int n)
{
	vector<int> r;
	int q;
	for (int k = 0; k < n + 1; k++)
	{
		r.push_back(0);
	}
	for (int j = 1; j <= n ; j++)
	{
		q = -999999999;
		for (int i = 0; i < j; i++)
		{
			q = max(q, p[i] + r[j-i-1]);
		}
		r[j] = q;
	}
	return r[n];
}