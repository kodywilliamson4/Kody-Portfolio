#include <iostream>
#include <cstdlib>
#include <string>
#include <iomanip>
#include "number_data.h"
#include "selectsort.h"
#include "mergesort.h"
#include "heapsort.h"
#include "quicksort.h"
#include "main.h"
#include "insertsort.h"
#include "bubblesort.h"

using namespace std;


const unsigned int SIZE = 8000;

int main()
{
	int numbers[SIZE];
	int increasing[SIZE];
	int decreasing[SIZE];
	int count1;
	int count2;
	int count3;
	int count4;
	int count5;
	int count6;
	int count7;
	int count8;
	int count9;

	fill_random_numbers(numbers, SIZE);
	fill_sorted_numbers(increasing, decreasing, SIZE);

	// NOW apply sorting algorithms to a copy of each array or copy of a slice of the array.

	int rand1[1000];
	int dec1[1000];
	int rand2[2000];
	int dec2[2000];
	int rand4[4000];
	int dec4[4000];
	int rand8[SIZE];
	int inc[SIZE];
	int dec8[SIZE];


	//SELECT SORT BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = selectionsort(dec1, 1000);
	count2 = selectionsort(rand1, 1000);
	count3 = selectionsort(dec2, 2000);
	count4 = selectionsort(rand2, 2000);
	count5 = selectionsort(dec4, 4000);
	count6 = selectionsort(rand4, 4000);
	count7 = selectionsort(dec8, SIZE);
	count8 = selectionsort(rand8, SIZE);
	count9 = selectionsort(inc, SIZE);
	
	cout << "Select sort:" << endl;
	cout << setw(5) << "n" << setw(10) <<"Expected" << setw(10) <<"Expected" << setw(10) <<"Expected" << setw(11) <<"Actual" << setw(10) <<"Actual" << setw(10) <<"Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 1000*1000 << setw(10) << 1000*1000 << setw(10) << 1000 * 1000 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 2000*2000 << setw(10) << 2000*2000 << setw(10) << 2000*2000 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 4000*4000 << setw(10) << 4000*4000 << setw(10) << 4000*4000 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 8000*8000 << setw(10) << 8000*8000 << setw(10) << 8000*8000 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;


	//MERGE SORT IS BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = mergesort(dec1, 1000);
	count2 = mergesort(rand1, 1000);
	count3 = mergesort(dec2, 2000);
	count4 = mergesort(rand2, 2000);
	count5 = mergesort(dec4, 4000);
	count6 = mergesort(rand4, 4000);
	count7 = mergesort(dec8, SIZE);
	count8 = mergesort(rand8, SIZE);
	count9 = mergesort(inc, SIZE);

	cout << "Merge sort:" << endl;
	cout << setw(5) << "n" << setw(10) << "Expected" << setw(10) << "Expected" << setw(10) << "Expected" << setw(11) << "Actual" << setw(10) << "Actual" << setw(10) << "Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 9966 << setw(10) << 9966 << setw(10) << 9966 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 21932 << setw(10) << 21932 << setw(10) << 21932 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 47863 << setw(10) << 47863 << setw(10) << 47863 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 103726 << setw(10) << 103726 << setw(10) << 103726 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;

	//BUBBLE SORT IS BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = bubblesort(dec1, 1000);
	count2 = bubblesort(rand1, 1000);
	count3 = bubblesort(dec2, 2000);
	count4 = bubblesort(rand2, 2000);
	count5 = bubblesort(dec4, 4000);
	count6 = bubblesort(rand4, 4000);
	count7 = bubblesort(dec8, SIZE);
	count8 = bubblesort(rand8, SIZE);
	count9 = bubblesort(inc, SIZE);

	cout << "Bubble sort:" << endl;
	cout << setw(5) << "n" << setw(10) << "Expected" << setw(10) << "Expected" << setw(10) << "Expected" << setw(11) << "Actual" << setw(10) << "Actual" << setw(10) << "Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 1000 * 1000 << setw(10) << 1000 * 1000 << setw(10) << 1000 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 2000 * 2000 << setw(10) << 2000 * 2000 << setw(10) << 2000 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 4000 * 4000 << setw(10) << 4000 * 4000 << setw(10) << 4000 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 8000 * 8000 << setw(10) << 8000 * 8000 << setw(10) << 8000 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;

	//BUBBLE SORT IS BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = insertsort(dec1, 1000);
	count2 = insertsort(rand1, 1000);
	count3 = insertsort(dec2, 2000);
	count4 = insertsort(rand2, 2000);
	count5 = insertsort(dec4, 4000);
	count6 = insertsort(rand4, 4000);
	count7 = insertsort(dec8, SIZE);
	count8 = insertsort(rand8, SIZE);
	count9 = insertsort(inc, SIZE);

	cout << "Insert sort:" << endl;
	cout << setw(5) << "n" << setw(10) << "Expected" << setw(10) << "Expected" << setw(10) << "Expected" << setw(11) << "Actual" << setw(10) << "Actual" << setw(10) << "Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 1000 * 1000 << setw(10) << 1000 * 1000 << setw(10) << 1000 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 2000 * 2000 << setw(10) << 2000 * 2000 << setw(10) << 2000 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 4000 * 4000 << setw(10) << 4000 * 4000 << setw(10) << 4000 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 8000 * 8000 << setw(10) << 8000 * 8000 << setw(10) << 8000 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;

	//HEAP SORT IS BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = heapsort(dec1, 1000);
	count2 = heapsort(rand1, 1000);
	count3 = heapsort(dec2, 2000);
	count4 = heapsort(rand2, 2000);
	count5 = heapsort(dec4, 4000);
	count6 = heapsort(rand4, 4000);
	count7 = heapsort(dec8, SIZE);
	count8 = heapsort(rand8, SIZE);
	count9 = heapsort(inc, SIZE);

	cout << "Heap sort:" << endl;
	cout << setw(5) << "n" << setw(10) << "Expected" << setw(10) << "Expected" << setw(10) << "Expected" << setw(11) << "Actual" << setw(10) << "Actual" << setw(10) << "Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 9966 << setw(10) << 9966 << setw(10) << 9966 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 21932 << setw(10) << 21932 << setw(10) << 21932 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 47863 << setw(10) << 47863 << setw(10) << 47863 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 103726 << setw(10) << 103726 << setw(10) << 103726 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;

	//QUICK SORT IS BELOW
	copy_arr(numbers, rand1, 1000);
	copy_arr(decreasing, dec1, 1000);
	copy_arr(numbers, rand2, 2000);
	copy_arr(decreasing, dec2, 2000);
	copy_arr(numbers, rand4, 4000);
	copy_arr(decreasing, dec4, 4000);
	copy_arr(numbers, rand8, SIZE);
	copy_arr(decreasing, dec8, SIZE);
	copy_arr(increasing, inc, SIZE);

	count1 = 0;
	count2 = 0;
	count3 = 0;
	count4 = 0;
	count5 = 0;
	count6 = 0;
	count7 = 0;
	count8 = 0;
	count9 = 0;

	count1 = quicksort(dec1, 1000, count1);
	count2 = quicksort(rand1, 1000, count2);
	count3 = quicksort(dec2, 2000, count3);
	count4 = quicksort(rand2, 2000, count4);
	count5 = quicksort(dec4, 4000, count5);
	count6 = quicksort(rand4, 4000, count6);
	count7 = quicksort(dec8, SIZE, count7);
	count8 = quicksort(rand8, SIZE, count8);
	count9 = quicksort(inc, SIZE, count9);

	cout << "Quick sort:" << endl;
	cout << setw(5) << "n" << setw(10) << "Expected" << setw(10) << "Expected" << setw(10) << "Expected" << setw(11) << "Actual" << setw(10) << "Actual" << setw(10) << "Actual" << endl;
	cout << setw(5) << "" << setw(10) << "worst" << setw(10) << "average" << setw(10) << "best" << setw(11) << "descending" << setw(10) << "random" << setw(10) << "ascending" << endl;
	cout << setw(5) << "1000" << setw(10) << 1000 * 1000 << setw(10) << 9966 << setw(10) << 9966 << setw(11) << count1 << setw(10) << count2 << setw(10) << "-" << endl;
	cout << setw(5) << "2000" << setw(10) << 2000 * 2000 << setw(10) << 21932 << setw(10) << 21932 << setw(11) << count3 << setw(10) << count4 << setw(10) << "-" << endl;
	cout << setw(5) << "4000" << setw(10) << 4000 * 4000 << setw(10) << 47863 << setw(10) << 47863 << setw(11) << count5 << setw(10) << count6 << setw(10) << "-" << endl;
	cout << setw(5) << "8000" << setw(10) << 8000 * 8000 << setw(10) << 103726 << setw(10) << 103726 << setw(11) << count7 << setw(10) << count8 << setw(10) << count9 << endl;


	main2();

	return 0;
}