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
	} while (Num <= 0);
	return Num;
}

int CountDigitFrequency(int Num, int DigitToChech)
{
	int Remainder = 0, Counter = 0;
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		if (Remainder == DigitToChech)
		{
			Counter++;
		}
	}
	return Counter;
}

void PrintAllDigitFrequency(int Num)
{
	for (int i = 0; i <= 9; i++)
	{
		short DigitFrequency = 0;
		DigitFrequency =  CountDigitFrequency(Num, i);
		if (DigitFrequency > 0)
		{
			cout << "Digit " << i << " Frequency is " << DigitFrequency << " Time(s).\n";
		}
	}
}
int main()
{
	int Number = ReadPositiveNumber("Please Enter The Number.");
	PrintAllDigitFrequency(Number);
	_getch();
	return 0;
}