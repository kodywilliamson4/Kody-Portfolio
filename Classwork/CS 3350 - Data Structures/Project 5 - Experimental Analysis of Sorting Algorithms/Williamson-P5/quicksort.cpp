// FILE: quick.cpp
// An interactive test program for the quicksort function
//Source: Dr. Venu Dasigi

#include <algorithm>  // Provides swap
#include <cstdlib>    // Provides EXIT_SUCCESS, size_t
#include <iostream>   // Provides cout and cin
#include "quicksort.h"

using namespace std;

int quicksort(int data[], size_t n, int count)
// Library facilities used: cstdlib
{
    size_t pivot_index; // Array index for the pivot element
    size_t n1;          // Number of elements before the pivot element
    size_t n2;          // Number of elements after the pivot element

    if (n > 1)
    {
        // Partition the array, and set the pivot index.
        count = partition(data, n, pivot_index, count);

        // Compute the sizes of the subarrays.
        n1 = pivot_index;
        n2 = n - n1 - 1;

        // Recursive calls will now sort the subarrays.
        count = quicksort(data, n1, count);
        count = quicksort((data + pivot_index + 1), n2, count);
    }

    return count;
}

int partition(int data[], size_t n, size_t& pivot_index, int count)
// Library facilities used: itemtool.h, stdlib.h
//
// NOTES FROM THE IMPLEMENTOR:
// How the partition works on small arrays:
//
// Notice that n=0 is not permitted by the precondition.
//
// If n=1, then too_big_index is initialized as 1, and too_small_index is
// initialized as 0. Therefore, the body of the loop is never executed,
// and after the loop pivot_index is set to zero.
//
// If n=2, then both too_big_index and too_small_index are initialized as 1.
// The loop is entered, and there are two cases to consider:
// -- if data[1] <= pivot, then too_big_index increases to 2, and
//    too_small_index stays at 1. The if-statement at the bottom of the loop
//    is then skipped, and after the loop we copy data[1] down to data[0],
//    and copy the pivot into data[0]. Thus, the smaller element is in
//    data[0], and the larger element (the pivot) is in data[1].
// -- if data[1] > pivot, then too_big_index stays at 1, and too_small_index
//    decreases to 0. The if-statement at the bottom of the loop is then
//    skipped, and after the loop we end up copying the pivot onto data[0]
//    (leaving data[1] alone). Thus, the smaller element (the pivot) remains
//    at data[0], leaving the larger element at data[1].
{
    // -- Implementation is left to the student
    int pivot = data[0]; // May be changed to median-of-three pivoting
    size_t too_big_index = 1;
    size_t too_small_index = n - 1;

    while (too_big_index <= too_small_index)
    {
        while (++count && (too_big_index < n) && (data[too_big_index] <= pivot)) too_big_index++;
        while (++count && data[too_small_index] > pivot) too_small_index--;
        if (too_big_index < too_small_index) swap(data[too_big_index], data[too_small_index]);
    };

    pivot_index = too_small_index;
    data[0] = data[pivot_index];
    data[pivot_index] = pivot;

    return count;
}