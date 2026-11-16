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
	} while (Num > 100 || Num < 0);
	return Num;
}

int MaxOfRandomNumber(int Array[], int Number)
{
	int MaxOfNumber = 0;
	for (int i = 1; i <= Number; i++)
	{
		if (MaxOfNumber < Array[i])
		{
			MaxOfNumber = Array[i];
		}
	}
	return MaxOfNumber;
}

void ReadToArray(int Number)
{
	int Array[100] = {}, N;
	cout << "Array Element: ";
	
	for (int i = 1; i <= Number; i++)
	{
		Array[i] = (rand() % (100 - 1 + 1) + 1);
		cout << Array[i]<<"\t";
	}
	cout << "\nMax Number is:" << MaxOfRandomNumber(Array, Number) << endl;
}

int main()
{
	srand((unsigned)time(NULL));
	int Number = ReadPositiveNumber("Please Enter the number.");
	ReadToArray(Number);

	_getch();
	return 0;
}