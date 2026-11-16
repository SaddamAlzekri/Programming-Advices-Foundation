#include<iostream>
#include<conio.h>
using namespace std;

void ReadNumbers(int& Num1, int& Num2)
{
	cout << "Please enter the number1\n";
	cin >> Num1;
	cout << "Please enter the number2\n";
	cin >> Num2;
}

int MaxOf2Numbers(int Num1, int Num2)
{
	if (Num1 > Num2)
		return Num1;
	else
		return Num2;
}

void PrintMaxNumber(int Max)
{
	cout << "The Max is " << Max << endl;
}

int main()
{

	int Num1, Num2;
	ReadNumbers(Num1, Num2);
	PrintMaxNumber(MaxOf2Numbers(Num1, Num2));

	_getch();
	return 0;
}