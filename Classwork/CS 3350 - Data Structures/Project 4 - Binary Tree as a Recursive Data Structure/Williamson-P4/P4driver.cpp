//P4driver.cpp
void print(int c);   //Prints integer

#include "bintree.h"
#include <iostream>

using namespace std;

void main()
{
	//Pre: None
	//Post: User is presented with a list of menu options.
	//      Depending on different user inputs, different
	//      actions take place. Input is not case sensitve.

	char input;
	char input2;
	int i;
	BinaryTreeNode<int>* tree = new BinaryTreeNode<int>;
	tree = NULL;
	BinaryTreeNode<int>* reflection = new BinaryTreeNode<int>;
	tree = NULL;

	do
	{
		cin >> input;
		switch (input)
		{
		case 'I':
		case 'i':
			cin >> i;
			insert(tree, i);
			break;
		case 'D':
		case 'd':
			cin >> i;
			remove(tree, i);
			break;
		case 'C':
		case 'c':
			tree_clear(tree);
			break;
		case 'R':
		case 'r':
			reflection = reflect(tree);
			printTree(reflection);
			break;
		case 'P':
		case 'p':
			printTree(tree);
			break;
		case 'T':
		case 't':
			cin >> input2;
			switch (input2)
			{
			case 'R':
			case 'r':
				preorder(print, tree);
				break;
			case 'I':
			case 'i':
				inorder(print, tree);
				break;
			case 'O':
			case 'o':
				postorder(print, tree);
				break;
			};
			break;
		case 'Q':
		case 'q':
			break;

		};
	} while ((input != 'Q') && (input != 'q'));
};

void print(int c) {
	cout << c << " ";
}
