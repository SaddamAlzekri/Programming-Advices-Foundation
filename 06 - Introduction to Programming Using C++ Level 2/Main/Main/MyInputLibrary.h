#pragma once
#include<iostream>
#include<string>
using namespace std;
namespace MyInputLibrary
{
	int ReadNumber()
	{
		int Number;
		cout << "Enter the number\n";
		cin >> Number;
		return Number;
	}
}