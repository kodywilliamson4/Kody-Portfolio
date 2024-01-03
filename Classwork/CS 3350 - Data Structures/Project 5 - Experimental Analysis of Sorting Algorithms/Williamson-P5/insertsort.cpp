// FILE: insertsort.cpp
// A program that is meant to allow for insertion based sorting
//Source: https://www.tutorialspoint.com/cplusplus-program-to-implement-insertion-sort

#include <algorithm>  // Provides swap
#include <cstdlib>    // Provides EXIT_SUCCESS, size_t
#include <iostream>   // Provides cout and cin
#include "insertsort.h"

using namespace std;


int insertsort(int array[], int size) {
    int key, j;
    int count = 0;
    for (int i = 1; i < size; i++) {
        key = array[i];//take value
        j = i;
        while (++count && j > 0 && array[j - 1] > key) {
            array[j] = array[j - 1];
            j--;
        }
        array[j] = key;   //insert in right place
    }
    
    return count;
}