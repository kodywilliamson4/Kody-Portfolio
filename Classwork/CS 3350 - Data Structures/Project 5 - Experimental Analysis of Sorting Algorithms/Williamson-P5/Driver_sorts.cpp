#include <iostream>
#include <cstdlib>
#include <string>
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

int main2()
{
	int numbers[SIZE];
	int increasing[SIZE];
	int decreasing[SIZE];

	fill_random_numbers(numbers, SIZE);
	fill_sorted_numbers(increasing, decreasing, SIZE);

	int rand[SIZE];
	int inc[SIZE];
	int dec[SIZE];

	// NOW apply sorting algorithms to a copy of each array or copy of a slice of the array.

	//SELECT SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Select sort:" << endl;
	cout << "Random numbers sorted: ";
	selectionsort(rand, SIZE);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	selectionsort(inc, SIZE);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	mergesort(dec, SIZE);
	print_arr(dec, SIZE);
	cout << endl;

	//MERGE SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Merge sort: " << endl;
	cout << "Random numbers sorted: ";
	mergesort(rand, SIZE);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	mergesort(inc, SIZE);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	mergesort(dec, SIZE);
	print_arr(dec, SIZE);
	cout << endl;

	//BUBBLE SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Bubble sort: " << endl;
	cout << "Random numbers sorted: ";
	bubblesort(rand, SIZE);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	bubblesort(inc, SIZE);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	bubblesort(dec, SIZE);
	print_arr(dec, SIZE);
	cout << endl;

	//INSERT SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Insert sort: " << endl;
	cout << "Random numbers sorted: ";
	insertsort(rand, SIZE);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	insertsort(inc, SIZE);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	insertsort(dec, SIZE);
	print_arr(dec, SIZE);
	cout << endl;

	//HEAP SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Heap sort: " << endl;
	cout << "Random numbers sorted: ";
	heapsort(rand, SIZE);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	heapsort(inc, SIZE);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	heapsort(dec, SIZE);
	print_arr(dec, SIZE);
	cout << endl;

	//QUICK SORT

	copy_arr(numbers, rand, SIZE);
	copy_arr(increasing, inc, SIZE);
	copy_arr(decreasing, dec, SIZE);

	cout << "Quick sort: " << endl;
	cout << "Random numbers sorted: ";
	quicksort(rand, SIZE, 0);
	print_arr(rand, SIZE);
	cout << "Increasing numbers sorted: ";
	quicksort(inc, SIZE, 0);
	print_arr(inc, SIZE);
	cout << "Decreasing numbers sorted: ";
	quicksort(dec, SIZE, 0);
	print_arr(dec, SIZE);
	cout << endl;

	return 0;
}