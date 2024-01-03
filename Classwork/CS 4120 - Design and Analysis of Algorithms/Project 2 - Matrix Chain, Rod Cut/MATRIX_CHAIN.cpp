//Help with matrix of vectors: https://stackoverflow.com/questions/12375591/vector-of-vectors-to-create-matrix

#include <algorithm>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include "CStopWatch.h"
#include <math.h>

using namespace std;

int recursive_matrix_chain(vector<int> p, int i, int j);
int memoized_matrix_chain(vector<int> p, int n);
int lookup_chain(int m[][50], vector<int> p, int i, int j);
int matrix_chain_order(vector<int> p, int n, int** m, int** s);

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

	//Recursive

	timer1.startTimer();
	price1 = recursive_matrix_chain(p, 1, n - 1);
	timer1.stopTimer();
	cout << price1 << ", " << timer1.getElapsedTimeInSec() << endl;

	//Memoized
	timer2.startTimer();
	price2 = memoized_matrix_chain(p, n);
	timer2.stopTimer();
	cout << price2 << ", " << timer2.getElapsedTimeInSec() << endl;

	//Bottom up
	int num = n;
	int** m = new int* [num];
	int** s = new int* [num];
	for (int t = 1; t < num; t++) {
		m[t] = new int[num];
		s[t] = new int[num];
		m[t][t] = 0;
	}

	timer3.startTimer();
	price3 = matrix_chain_order(p, n, m, s);
	timer3.stopTimer();
	cout << m[1][n-1] << ", " << timer3.getElapsedTimeInSec() << endl;


	return 0;
}

int recursive_matrix_chain(vector<int> p, int i, int j)
{
	if (i == j)
	{
		return 0;
	}

	int** m = new int* [i];
	for (int k = 0; k < i+1; k++) {
		m[k] = new int[j+1];
	}

	//Creating matrix of i by j - nevermind in the pseudocode this appears to be a matrix for no reason
	m[i][j] = 999999999;
	int q;

	for (int r = i; r < j; r++)
	{
		q = recursive_matrix_chain(p, i, r) + recursive_matrix_chain(p, r + 1, j) + p[i-1] * p[r] * p[j];
		if (q < m[i][j])
		{
			m[i][j] = q;
		}
	}

	return m[i][j];
}

int memoized_matrix_chain(vector<int> p, int n)
{
	int num = n - 1;
	int m[50][50];
	for (int i = 0; i < 50; i++)
	{
		for (int j = 0; j < 50; j++)
		{
			m[i][j] = 999999999;
		}
	}

	return lookup_chain(m, p, 1, num);
}

int lookup_chain(int m[][50], vector<int> p, int i, int j)
{
	int q;

	if (m[i][j] < 999999998)
	{
		return m[i][j];
	}
	if (i == j)
	{
		m[i][j] = 0;
	}
	else
	{
		for (int k = i; k < j; k++)
		{
			q = lookup_chain(m, p, i, k) + lookup_chain(m, p, k + 1, j) + p[i - 1] * p[k] * p[j];
			if (q < m[i][j])
			{
				m[i][j] = q;
			}
		}
	}

	return m[i][j];
}

int matrix_chain_order(vector<int> p, int n, int**m, int**s)
{
	int j;
	int q;
	int num = n;
	for (int l = 2; l < num; l++)
	{
		for (int i = 1; i < num - l + 1; i++)
		{
			j = i + l - 1;
			m[i][j] = 999999999;
			for (int k = i; k <= j-1; k++)
			{
				q = m[i][k] + m[k + 1][j] + p[i - 1] * p[k] * p[j];
				if (q < m[i][j])
				{
					m[i][j] = q;
					s[i][j] = k;
				}
			}
		}
	}

	return 0;
}