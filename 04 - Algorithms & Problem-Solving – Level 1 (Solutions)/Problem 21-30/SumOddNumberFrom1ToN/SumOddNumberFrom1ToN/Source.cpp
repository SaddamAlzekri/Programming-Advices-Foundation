#include<iostream>
#include<conio.h>
using namespace std;

enum enOddOrEven
{
	Odd = 1,
	Even = 2
};

int ReadNumber()
{
	int Num;
	cout << "Please enter the num.\n";
	cin >> Num;
	return Num;
}

enOddOrEven CheckOddOrEven(int Num)
{
	if (Num % 2 != 0)
		return enOddOrEven::Odd;
	else
		return enOddOrEven::Even;
}

void SumOddNumbersFrom1ToNUsingFor(int Num)
{
	int Sum = 0;
	for (int Count = 0; Count <= Num; Count++)
	{
		if (CheckOddOrEven(Count) == enOddOrEven::Odd)
			Sum += Count;
	}

	cout <<"The sum odd is "<<Sum<<endl;
}

void SumOddNumbersFrom1ToNUsingWhile(int Num)
{
	int Sum = 0, Count = 0;
	while (Count <= Num)
	{

		if (CheckOddOrEven(Count) == enOddOrEven::Odd)
		{
			Sum += Count;
		}
		Count++;
	}
	cout << "The sum odd is " << Sum << endl;
}

void SumOddNumbersFrom1ToNUsingDoWhile(int Num)
{
	int Sum = 0, Count = 0;
	do
	{
		if (CheckOddOrEven(Count) == enOddOrEven::Odd)
		{
			Sum += Count;
		}
		Count++;
	} while (Count <= Num);

	cout << "The Sum odd is " << Sum << endl;
}

int main()
{
	int N = ReadNumber();
	SumOddNumbersFrom1ToNUsingFor(N);
	SumOddNumbersFrom1ToNUsingWhile(N);
	SumOddNumbersFrom1ToNUsingDoWhile(N);

	_getch();
	return 0;
}