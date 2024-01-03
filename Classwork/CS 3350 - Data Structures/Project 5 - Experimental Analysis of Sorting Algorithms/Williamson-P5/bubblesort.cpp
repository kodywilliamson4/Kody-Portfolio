// FILE: bubblesort.cpp
// An interactive test program for the bubblesort function
//Source: https://www.geeksforgeeks.org/bubble-sort/

#include <algorithm>   // Provides swap
#include <cstdlib>     // Provides EXIT_SUCCESS, size_t
#include <iostream>    // Provides cout and cin
#include "bubblesort.h"

using namespace std;

void swap(int* xp, int* yp)
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}

// A function to implement bubble sort  
int bubblesort(int arr[], int n)
{
    int i, j;
    bool swapped;
    int count = 0;
    for (i = 0; i < n - 1; i++)
    {
        swapped = false;
        for (j = 0; j < n - i - 1; j++)
        {
            if (++count && arr[j] > arr[j + 1])
            {
                swap(&arr[j], &arr[j + 1]);
                swapped = true;
            }
        }

        // IF no two elements were swapped by inner loop, then break 
        if (swapped == false)
            break;
    }

    return count;
}