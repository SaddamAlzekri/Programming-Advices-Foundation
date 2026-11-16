#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadNumber()
{
	int Number;
	cout << "Please enter the Number\n";
	cin >> Number;
	return Number;
}

float CalculateHalfNumber(int Number)
{
	return (float)Number / 2;
}

void PrintHalfNumber(int Number)
{
	string Result = "The " + to_string(Number) + "half is " + to_string(CalculateHalfNumber(Number));
	cout << Result << endl;
}

int main()
{
	PrintHalfNumber(ReadNumber());
	_getch();
	return 0;
}