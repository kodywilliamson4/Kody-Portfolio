// FILE: selectsort.cpp
// A program that is meant to allow for selection based sorting
//Source: Dr. Venu Dasigi

#include <algorithm>  // Provides swap
#include <cstdlib>    // Provides EXIT_SUCCESS, size_t
#include <iostream>   // Provides cout and cin
#include "selectsort.h"

using namespace std;

int selectionsort(int data[], size_t n)
// Library facilities used: algorithm, cstdlib
{
    size_t i, j, index_of_largest;
    int largest;
    int count = 0;

    if (n == 0)
        return 0; // No work for an empty array.

    for (i = n - 1; i > 0; --i)
    {
        largest = data[0];
        index_of_largest = 0;
        for (j = 1; j <= i; ++j)
        {
            if (++count && data[j] > largest)
            {
                largest = data[j];
                index_of_largest = j;
            }
        }
        swap(data[i], data[index_of_largest]);
    }

    return count;
}