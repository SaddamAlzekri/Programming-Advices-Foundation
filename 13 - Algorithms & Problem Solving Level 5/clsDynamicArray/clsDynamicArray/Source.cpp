#pragma once
#include <iostream>
#include <conio.h>
#include "clsDynamicArray.h"
using namespace std;

int main()
{
	clsDynamicArray <int> DynamicArray(10);

	DynamicArray.SetItem(0, 1);
	DynamicArray.SetItem(1, 2);
	DynamicArray.SetItem(2, 3);
	DynamicArray.SetItem(3, 30);
	DynamicArray.SetItem(8, 5);
	DynamicArray.PrintList();

	cout << "\nArray size?   " << DynamicArray.Size() << endl;
	cout << "\nArray Empty?   " << DynamicArray.IsEmpty() << endl;


	cout << "\nResize the array.\n";
	DynamicArray.Resize(4);
	DynamicArray.PrintList();
	
	
	cout << "\nReverse Array.\n";
	DynamicArray.Reverse();
	DynamicArray.PrintList();

	cout << "\nGetItem(1) : " << DynamicArray.GetItem(1) << endl;

	cout << "\nArray size?   " << DynamicArray.Size() << endl;

	int Index = DynamicArray.Find(30);
	DynamicArray.PrintList();

	if (Index == -1)
		cout << "\nItem was not Found:-(\n";
	else
		cout << "\n30 is found at deleting 30:" << Index << endl;

	DynamicArray.DeleteItem(30);
	cout << "\n\nArray Items after deleting 30:";
	cout << "\nArray Size: " << DynamicArray.Size() << endl;
	DynamicArray.PrintList();


	DynamicArray.InsertAt(2, 30);
	cout << "\n\nInsert 30 at index ["<<2<<"] : ";
	DynamicArray.PrintList();

	DynamicArray.InsertBefore(2, 30);
	cout << "\n\nInsert 30 at index [" << 1 << "] : ";
	DynamicArray.PrintList();

	DynamicArray.InsertAfter(2, 30);
	cout << "\n\nInsert 30 at index [" << 1 << "] : ";
	DynamicArray.PrintList();

	DynamicArray.InsertAtBeginning(500);
	cout << "\n\nInsert 30 at index [" << 1 << "] : ";
	DynamicArray.PrintList();


	DynamicArray.InsertAtEnd(600);
	cout << "\n\nInsert 30 at index [" << 1 << "] : ";
	DynamicArray.PrintList();
	_getch();
	return 0;
}