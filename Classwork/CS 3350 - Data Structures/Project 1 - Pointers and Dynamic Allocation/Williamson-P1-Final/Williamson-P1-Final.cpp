/*
WHAT:	Homework 1 solution.
AUTHOR:672300
I attempted the resize but I am unsure if you are giving partial credit, I cannot get this to run after even spending
2 extra days so I am unfortunately turning it in as is.
*/

#include <cassert>
#include <iostream>
#include <fstream>
#include <cctype>
using namespace std;

/*Type delcarations - NO MEMORY ALLOCATED (EVEN STATICALLY)*/
struct emprec	/*Employee record with two fields*/
{
    int id;
    float salary;
};
typedef emprec* emprecptr; /*Employee record pointer type*/
typedef emprecptr* indexarr; /* Pointer to a dynamic array of employee record pointers*/

int main()
{
    /* Rudimentary scope control in C/C++ */
    void readdata(indexarr&, int&);
    void printdata(indexarr, int);
    void copyindex(indexarr, indexarr&, int);
    void sortbyID(indexarr, int);
    void sortbySalary(indexarr, int);
    void deallocate(indexarr&, int&);
    indexarr DBindex, IDindex, Salaryindex;
    int dbsize;
    char temp;

    readdata(DBindex, dbsize);
    cout << "Original data:" << endl;
    printdata(DBindex, dbsize);
    copyindex(DBindex, IDindex, dbsize);
    sortbyID(IDindex, dbsize);
    cout << "Data sorted by the ID:" << endl;
    printdata(IDindex, dbsize);
    copyindex(DBindex, Salaryindex, dbsize);
    sortbySalary(Salaryindex, dbsize);
    cout << "Data sorted by the salary:" << endl;
    printdata(Salaryindex, dbsize);
    deallocate(DBindex, dbsize);
};

void eat_white(ifstream& in)
/* Pre: "in" is a valid input file stream.
Post: Any white space skipped over to EOF or the next non-white space character.*/
{
    while ((in.peek() != EOF) && isspace(in.peek())) in.ignore();
};

void resize(indexarr& Base, int OLDSIZE, int NEWSIZE)
/* Pre: Base is a (dynamic) indexarr of size OLDSIZE.
Post: Base is "EXPANDED" OR "SHRUNK" into a new (dynamic) indexarr of size
NEWSIZE, with data copied appropriately.
IMPORTANT NOTE: If being shrunk, it is assumed that there are only NEWSIZE valid
elements in the original array, and only that many are copied.*/
{
    cout << "Shrinking the array, allocating 5 records.";
    emprecptr *temp = NULL;
    temp = new emprecptr[NEWSIZE];
    for (int i = 0; i < NEWSIZE; i++)
    {
        temp[i]->id = Base[i]->id;
        temp[i]->salary = Base[i]->salary;
    }
    Base = temp;
}

void readdata(indexarr& ptrs, int& size)
/*Pre: ptrs is a pointer that could point to a dynamic array of employee record pointers.
Post: ptrs points to a dynamic pointer array of the right size based on the
input read in from the data file named "p1data".
All the elements of the dynamic array are filled with pointers to dynamically
allocated employeed records, which in turn are filled with input data.*/
{
    void resize(indexarr&, int, int);
    ifstream infile;
    infile.open("p1data.txt");
    size = 5;
    if (infile.is_open())
    {
        for (int i = 0; i < size; i++)
        {
            infile >> ptrs[i]->id;
            infile >> ptrs[i]->salary;
            size = i;
        }
    }
    infile.close();
};

void printrec(emprec rec)
/*Pre: rec has data.
Post: The data in rec printed out.*/
{
    cout << rec.id << ' ' << rec.salary << endl;
};

void printdata(indexarr ptrs, int size)
/*Pre: The first "size" elements of the array pointed at by ptrs are employee records
containing data.
Post: They are all printed out in the order pointed at.*/
{
    void printrec(emprec);
    for (int i = 0; i < size; i++) printrec(*ptrs[i]);
};

void copyindex(indexarr orig, indexarr& copy, int size)
/*Pre: The first "size" elements of the array pointed at by orig are employee records
containing data.
Post: copy points to a newly allocated dynamic array of pointers (with size elements), and
the elements of this array are copies of the first size elements of orig.*/
{

    emprecptr* temp = NULL;
    temp = new emprecptr[size];
    for (int i = 0; i < size; i++)
    {
        temp[i]->id = orig[i]->id;
        temp[i]->salary = orig[i]->salary;
    }
    copy = temp;
    delete[] temp;
    temp = NULL;

};

int selectsmallestID(indexarr ptrs, int first, int last)
/*Pre: "first" through "last" elements of the ptrs array are pointers to employee records
containing data.
Post: A value k is returned such that, for i ranging from first to last,
the relation ptrs[k]->id <= ptrs[i]->id holds.*/
{
    int value, i;
    value = first;
    for (i = first + 1; i < last; i++)
    {
        if (ptrs[i]->id < ptrs[value]->id)
        {
            value = i;
        }
    }

    return value;
};

void sortbyID(indexarr ptrs, int size)
/*Pre: The first "size" elements of the ptrs array are pointers to employee records
containing data.
Post: for i ranging from 1 to size-2, the relation ptrs[i]->id <= ptrs[i+1]->id holds.
Also, the employee records themselves are not disturbed/moved around.*/
{
    int selectsmallestID(indexarr, int, int);

    int i, small;
    for (i = 0; i < size - 2; i++)
    {
        small = selectsmallestID(ptrs, i, i - 1);
        swap(*ptrs[i], *ptrs[small]);
    }
};

int selectsmallestSalary(indexarr ptrs, int first, int last)
/*Pre: "first" through "last" elements of the ptrs array are pointers to employee
records containing data.
Post: A value k is returned such that, for i ranging from first to last,
the relation ptrs[k]->salary <= ptrs[i]->salary holds.*/
{
    int value, i;
    value = first;
    for (i = first + 1; i < last; i++)
    {
        if (ptrs[i]->id < ptrs[value]->salary)
        {
            value = i;
        }
    }

    return value;
};

void sortbySalary(indexarr ptrs, int size)
/*Pre: The first "size" elements of the ptrs array are pointers to employee records
containing data.
Post: for i ranging from 1 to size-2, the relation ptrs[i]->salary <= ptrs[i+1]->salary holds.
Also, the employee records themselves are not disturbed/moved around.*/
{
    int selectsmallestSalary(indexarr, int, int);

    int i, small;
    for (i = 0; i < size - 2; i++)
    {
        small = selectsmallestSalary(ptrs, i, i - 1);
        swap(*ptrs[i], *ptrs[small]);
    }
};

void deallocate(indexarr& ptrs, int& size)
/*Pre: ptrs is a pointer pointing to an allocated dynamic array of "size" employee record pointers.
Post: ptrs points to a dynamic pointer array.  The "size" elements of the dynamic array, filled with
pointers to dynamically allocated employeed records, are now deallocated, and then the array of
pointers that ptrs points to is itself deallocated, with ptrs reset to NULL and size reset to 0.*/
{
    for (int i = 0; i < size; i++) delete (ptrs[i]);
    delete ptrs;
    ptrs = NULL;
    size = 0;
};
