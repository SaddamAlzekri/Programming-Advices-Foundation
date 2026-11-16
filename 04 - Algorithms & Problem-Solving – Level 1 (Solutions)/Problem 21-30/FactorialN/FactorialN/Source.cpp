#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < 0);

	return Num;
}

void Factorial(int Num)
{
	int F = 1;
	for (int Counter = Num; Counter >= 1; Counter--)
	{
		F *= Counter;
	}

	cout << "The Factorial is " << F << endl;
}

int main()
{
	Factorial(ReadPositiveNumber("Please enter the number."));
	_getch();
	return 0;
}