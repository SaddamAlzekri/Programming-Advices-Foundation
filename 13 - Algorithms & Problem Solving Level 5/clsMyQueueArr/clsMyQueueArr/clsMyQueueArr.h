#pragma once
#include<iostream>
#include "clsDynamicArray.h"
using namespace std;

template <class T> 
class clsMyQueueArr : protected clsDynamicArray<T>
{
public:
	clsDynamicArray<int> DynamicArray;
	void push(int value)
	{
		DynamicArray.InsertAtEnd(value);
	}

	void Print()
	{
		DynamicArray.PrintList();
	}

	T Size()
	{
		return DynamicArray.Size();
	}

	T front()
	{
		return DynamicArray.GetItem(0);
	}

	T back()
	{
		int EndValue = Size();
		return DynamicArray.GetItem(EndValue -1);
	}

	void pop()
	{
		DynamicArray.DeleteFirstItem();
	}

	T GetItem(int index)
	{
		return DynamicArray.GetItem(index);
	}

	void Reverse()
	{
		DynamicArray.Reverse();
	}

	void UpdateItem(int index, T value)
	{
		DynamicArray.DeleteItemAt(index);
		DynamicArray.InsertAt(index, value);

	}

	void InsertAfter(int index, T value)
	{
		DynamicArray.InsertAfter(index, value);
	}

	void InsertAtFront(T value)
	{
		DynamicArray.InsertAtBeginning(value);
	}

	void InsertAtBack(T value)
	{
		DynamicArray.InsertAtEnd(value);
	}

	void Clear()
	{
		DynamicArray.Clear();
	}
};

