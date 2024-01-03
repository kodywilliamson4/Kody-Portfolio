#pragma once
// PROTOTYPES of the functions used in this test program:
int heapsort(int [], size_t);
// Precondition: data is an array with at least n components.
// Postcondition: The elements of data have been rearranged so
// that data[0] <= data[1] <= ... <= data[n-1].

size_t parent(size_t);
// Precondition: k> 0.
// Postcondition: The function assumes that k is the index of an array element, where the array
// represents a complete binary tree. The return value is the index of the parent of node k, using
// the formula from rule 3 on page 624.

size_t left_child(size_t);
// Postcondition: The function assumes that k is the index of an array element, where the array
// represents a complete binary tree. The return value is the index of the left child of node k,
// using the formula from rule 2 on page 624.

size_t right_child(size_t);
// Postcondition: The function assumes that k is the index of an array element, where the array
// represents a complete binary tree. The return value is the index of the right child of node k,
// using the formula from rule 2 on page 624.

int make_heap(int [], size_t, int );
// Precondition: data is an array with at least n elements.
// Postcondition: The elements of data have been rearranged so that the
// complete binary tree represented by this array is a heap.

int reheapify_down(int[], size_t, int );
// Precondition: n > 0, and data is an array with at least n elements. These elements form a
// heap **except** that data[0] may be in an incorrect location.
// location.
// Postcondition: The data values have been rearranged so that the first n elements of data now
// form a heap.
