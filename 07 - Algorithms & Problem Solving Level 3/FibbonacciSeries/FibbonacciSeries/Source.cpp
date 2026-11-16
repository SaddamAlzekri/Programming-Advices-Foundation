#include<iostream>
#include<conio.h>
using namespace std;


void PrintFibbonacciSeries(int Number)
{
	int Result = 0, FirstNumber = 0, SecondNumber = 1;

	cout << "1    ";

	for (short i = 2; i <= Number; i++)
	{

		Result = FirstNumber + SecondNumber;
		cout << "\t" <<Result ;
		FirstNumber = SecondNumber;
		SecondNumber = Result;
	}
}

int main()
{
	PrintFibbonacciSeries(10);

	_getch();
	return 0;
}