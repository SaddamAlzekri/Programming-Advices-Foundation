#include<iostream>
#include<conio.h>
using namespace std;

enum enOddEvenOrAll
{
	Odd = 1,
	Even = 2,
	All = 3
};

int ReadNumber()
{
	int Num;
	cout << "Please enter the num\n";
	cin >> Num;
	return Num;
}

enOddEvenOrAll CheckNumber()
{
	int ChooseNumber;
	cout << "Enter (1) Number Odd\n";
	cout << "Enter (2) Number Even\n";
	cout << "Enter (3) All Number\n";
	do
	{
		cin >> ChooseNumber;
	} while (ChooseNumber > 3);

	if (ChooseNumber == enOddEvenOrAll::Odd)
		return enOddEvenOrAll::Odd;
	else if (ChooseNumber == enOddEvenOrAll::Even)
		return enOddEvenOrAll::Even;
	else
		return enOddEvenOrAll::All;
}

int SumOddNumber(int Num)
{
	int Sum = 0;
	for (int Counter = Num; Counter >= 1; Counter--)
	{
		if (Counter % 2 != 0)
		{
			Sum += Counter;
		}

	}
	return Sum;
}

int SumEvenNumber(int Num)
{
	int Sum = 0;
	for (int Counter = Num; Counter >= 1; Counter--)
	{
		if (Counter % 2 == 0)
		{
			Sum += Counter;
		}

	}
	return Sum;
}

int SumAllNumber(int Num)
{
	int Sum = 0;
	for (int Counter = Num; Counter >= 1; Counter--)
	{
		Sum += Counter;
	}
	return Sum;
}

void SumOddevenOrAllNumbersUsingFor(int Num)
{
	int Sum = 0;
	int N = CheckNumber();
	if (N == enOddEvenOrAll::Odd)
	{
		cout << "The Numbers Odd is " << SumOddNumber(Num) << endl;
	}
	else if (N == enOddEvenOrAll::Even)
	{
		cout << "The Numbers Even is " << SumEvenNumber(Num) << endl;
	}
	else if (N == enOddEvenOrAll::All)
	{
		cout << "The All Of Sum Numbers  is " << SumAllNumber(Num) << endl;
	}
}

int main()
{
	int N = ReadNumber();
	SumOddevenOrAllNumbersUsingFor(N);
	_getch();
	return 0;
}