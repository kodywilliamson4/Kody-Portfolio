#include <vector>
#include <list>
#include <iostream>
#include <string>
using namespace std;

void main()
{
	vector<int> nums;
	vector<int>::iterator iter1;
	list<float> reals;
	list<float>::iterator iter2;
	list<float>::reverse_iterator iter3;
	int x;
	float y;

	//Changes
	vector<float> nums2;
	vector<float>::iterator iter4;
	string z;
	list<string> strings;
	list<string>::iterator iter5;
	list<string>::reverse_iterator iter6;



	cout << "Input five integers one after another:" << endl;
	for (int i = 0; i < 5; i++)
	{
		cin >> x;
		nums.push_back(x);
	};
	cout << "Integer input done" << endl;
	for (iter1 = nums.begin(); iter1 != nums.end(); iter1++) cout << *iter1 << endl;

	cout << "Input three floating point numbers one after another:" << endl;
	for (int i = 0; i < 3; i++)
	{
		cin >> y;
		if (i % 2 == 0) reals.push_back(y);
		else reals.push_front(y);
	};
	cout << "Floating point input done" << endl;
	for (iter2 = reals.begin(); iter2 != reals.end(); iter2++) cout << *iter2 << endl;
	for (iter3 = reals.rbegin(); iter3 != reals.rend(); iter3++) cout << *iter3 << endl;
	for (iter2 = reals.end(); iter2 != reals.begin(); ) cout << *--iter2 << endl;

	//Floating point vector
	cout << "Input three floating point numbers one after another:" << endl;
	for (int i = 0; i < 3; i++)
	{
		cin >> y;
		nums2.push_back(y);
	};
	cout << "Floating point input done" << endl;
	for (iter4 = nums2.begin(); iter4 != nums2.end(); iter4++) cout << *iter4 << endl;

	//String list
	cout << "Input five strings one after another:" << endl;
	for (int i = 0; i < 5; i++)
	{
		cin >> z;
		if (i % 2 == 0) strings.push_front(z);
		else strings.push_back(z);
	};
	cout << "String input done" << endl;
	for (iter5 = strings.begin(); iter5 != strings.end(); iter5++) cout << *iter5 << endl;
	for (iter6 = strings.rbegin(); iter6 != strings.rend(); iter6++) cout << *iter6 << endl;
	for (iter5 = strings.end(); iter5 != strings.begin(); ) cout << *--iter5 << endl;
};
