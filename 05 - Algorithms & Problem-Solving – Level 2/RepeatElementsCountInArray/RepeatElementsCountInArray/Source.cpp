#include<iostream>
#include<conio.h>
#include<string>
#include<stdlib.h>
#include<time.h>

using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num = 0;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <1);
	return Num;
}

void SearchNumber(int array[],int Num, int SN)
{
	int Counter = 0;
	for (int i = 1; i <= Num; i++)
	{
		if (array[i] == SN)
		{
			Counter++;
		}
	}
	cout << SN << " is repeat " << Counter << " time(s)\n";
}

void PrintAray(int array[], int Number)
{
	cout << "Original array: ";
	for (int i = 1; i <= Number; i++)
	{
		cout << array[i];
	}
	cout << endl;
}

void ReadToArray(int Number)
{
	int Array[100] = {};
	for (int i = 1; i <= Number; i++)
	{
		cout << "Element[" << i << "]: ";
		cin >> Array[i];
		cout << endl;
	}

	int SN = ReadPositiveNumber("Please Enter the number that search.");
	cout << "Output\n";
	PrintAray(Array, Number);
	SearchNumber(Array, Number, SN);
}

int main()
{
	int Number = ReadPositiveNumber("Please Enter the number.");
	ReadToArray(Number);

	_getch();
	return 0;
}