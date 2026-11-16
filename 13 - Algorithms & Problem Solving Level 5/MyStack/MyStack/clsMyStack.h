//#pragma once
//#include<iostream>
//#include "clsDblLinkedList.h"
//using namespace std;
//
//template <class T>
//class clsMyStack
//{
//public:
//	clsDblLinkedList<int> DblLinkedList;
//
//	void Push(T value)
//	{
//		DblLinkedList.InsertAtBeginning(value);
//	}
//
//	void Print()
//	{
//		DblLinkedList.PrintList();
//	}
//
//	void pop()
//	{
//		DblLinkedList.DeleteFirstNode();
//	}
//
//	T Size()
//	{
//		return DblLinkedList.Size();
//	}
//
//	T Top()
//	{
//		return DblLinkedList.GetItem(0);
//	}
//
//	T Bottom()
//	{
//		T index = DblLinkedList.Size();
//		return DblLinkedList.GetItem(index - 1);
//
//	}
//
//	T GetItem(T value)
//	{
//		return DblLinkedList.GetItem(value);
//	}
//
//	void Reverse()
//	{
//		return DblLinkedList.Reverce();
//
//	}
//
//	void UpdateItem(int index, T value)
//	{
//		DblLinkedList.UpdateItem(index, value);
//	}
//
//	void InsertAfter(int index, T value)
//	{
//		DblLinkedList.InsertAfterindex(index, value);
//	}
//
//	void InsertAtFront(T value)
//	{
//		DblLinkedList.InsertAtBeginning(value);
//	}
//
//	void InsertAtBack(T value)
//	{
//		DblLinkedList.InsertAtEnd(value);
//	}
//
//	void Clear()
//	{
//		DblLinkedList.clear();
//	}
//};
//

#pragma once

#include <iostream>
#include "clsMyQueue.h"
using namespace std;
template <class T>

class  clsMyStack :public   clsMyQueue <T>
{

public:

	void push(T Item)
	{
		clsMyQueue <T>::_MyList.InsertAtBeginning(Item);
	}

	T Top()
	{
		return clsMyQueue <T>::front();

	}

	T Bottom()
	{
		return clsMyQueue <T>::back();

	}

};

