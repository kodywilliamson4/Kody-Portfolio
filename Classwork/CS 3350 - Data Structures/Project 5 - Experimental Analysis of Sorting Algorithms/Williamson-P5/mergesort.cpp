// FILE: merge.cpp
// An interactive test program for the mergesort function
//Source: Dr. Venu Dasigi

#include <cstdlib>    // Provides EXIT_SUCCESS, size_t
#include <iostream>   // Provides cout and cin
#include "mergesort.h"

using namespace std;

int mergesort(int data[], size_t n)
// Precondition: data is an array with at least n components.
// Postcondition: The elements of data have been rearranged so
// that data[0] <= data[1] <= ... <= data[n-1].
// NOTE: If there is insufficient dynamic memory, thenbad_alloc is thrown.
// Library facilities used: cstdlib
{
    size_t n1; // Size of the first subarray
    size_t n2; // Size of the second subarray
    int count = 0;

    if (n > 1)
    {
        // Compute sizes of the subarrays.
        n1 = n / 2;
        n2 = n - n1;

        mergesort(data, n1);         // Sort from data[0] through data[n1-1]
        mergesort((data + n1), n2);  // Sort from data[n1] to the end

        // Merge the two sorted halves.
        count = merge(data, n1, n2, count);
    }
    return count;
}

int merge(int data[], size_t n1, size_t n2, int count)
// Precondition: data is an array (or subarray) with at least n1 + n2 elements.
// The first n1 elements (from data[0] to data[n1 - 1]) are sorted from
// smallest to largest, and the last n2 (from data[n1] to data[n1 + n2 - 1])
// also are sorted from smallest to largest.
// Postcondition: The first n1 + n2 elements of data have been rearranged to be
// sorted from smallest to largest.
// NOTE: If there is insufficient dynamic memory, then bad_alloc is thrown.
// Library facilities used: cstdlib
{
    int* temp;          // Points to dynamic array to hold the sorted elements
    size_t copied = 0; // Number of elements copied from data to temp
    size_t copied1 = 0; // Number copied from the first half of data
    size_t copied2 = 0; // Number copied from the second half of data
    size_t i;           // Array index to copy from temp back into data

    // Allocate memory for the temporary dynamic array.
    temp = new int[n1 + n2];

    // Merge elements, copying from two halves of data to the temporary array.
    while (++count && ++count &&(copied1 < n1) && (copied2 < n2))
    {
        if (data[copied1] < (data + n1)[copied2])
            temp[copied++] = data[copied1++];        // Copy from first half
        else
            temp[copied++] = (data + n1)[copied2++]; // Copy from second half
    }

    // Copy any remaining entries in the left and right subarrays.
    while (++count && copied1 < n1)
    {
        count = count + 1;
        temp[copied++] = data[copied1++];
    }
    while (++count && copied2 < n2)
    {
        count = count + 1;
        temp[copied++] = (data + n1)[copied2++];
    }

    // Copy from temp back to the data array, and release temp's memory.
    for (i = 0; i < n1 + n2; i++)
        data[i] = temp[i];
    delete[] temp;

    return count;
}