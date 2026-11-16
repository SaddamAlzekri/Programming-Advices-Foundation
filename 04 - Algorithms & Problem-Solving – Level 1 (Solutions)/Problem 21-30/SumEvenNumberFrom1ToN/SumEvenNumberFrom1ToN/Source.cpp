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
	if (Num % 2 == 0)
		return enOddOrEven::Even;
	else
		return enOddOrEven::Odd;
}

void SumEvenNumbersFrom1ToNUsingFor(int Num)
{
	int Sum = 0;
	for (int Count = 0; Count <= Num; Count++)
	{
		if (CheckOddOrEven(Count) == enOddOrEven::Even)
			Sum += Count;
	}

	cout << "The sum even is " << Sum << endl;
}

void SumEvenNumbersFrom1ToNUsingWhile(int Num)
{
	int Sum = 0, Count = 0;
	while (Count <= Num)
	{

		if (CheckOddOrEven(Count) == enOddOrEven::Even)
		{
			Sum += Count;
		}
		Count++;
	}
	cout << "The sum even is " << Sum << endl;
}

void SumEvenNumbersFrom1ToNUsingDoWhile(int Num)
{
	int Sum = 0, Count = 0;
	do
	{
		if (CheckOddOrEven(Count) == enOddOrEven::Even)
		{
			Sum += Count;
		}
		Count++;
	} while (Count <= Num);

	cout << "The Sum even is " << Sum << endl;
}

int main()
{
	int N = ReadNumber();
	SumEvenNumbersFrom1ToNUsingFor(N);
	SumEvenNumbersFrom1ToNUsingWhile(N);
	SumEvenNumbersFrom1ToNUsingDoWhile(N);

	_getch();
	return 0;
}