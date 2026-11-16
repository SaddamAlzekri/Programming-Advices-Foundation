#include<iostream>
#include<conio.h>
using namespace std;

void PrintFibbonacciSeries(int Number, int FirstNumber,int SecondNumber)
{	
	if (Number > 0)
	{
		int Result = FirstNumber + SecondNumber;
		
		 SecondNumber = FirstNumber;
		 FirstNumber = Result;

		cout << Result << "\t";
		PrintFibbonacciSeries(Number - 1, FirstNumber, SecondNumber);
	}
}

int main()
{
	int FirstNumber = 0, SecondNumber = 1;

	PrintFibbonacciSeries(10, FirstNumber, SecondNumber);

	_getch();
	return 0;
}