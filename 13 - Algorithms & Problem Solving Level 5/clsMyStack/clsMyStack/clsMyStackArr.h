#pragma once
#include<iostream>
#include "clsMyQueue.h"
using namespace std;

template <class T>
class clsMyStack : public clsMyQueueArr<T>
{
public:
	clsMyQueueArr<int> MyQueue;
	T Top()
	{
		return MyQueue.front();
	}


	T Bottom()
	{
		return MyQueue.back();
	}
};

