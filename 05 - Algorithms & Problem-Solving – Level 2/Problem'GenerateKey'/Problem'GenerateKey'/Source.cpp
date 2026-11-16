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

int RandomSmallLetter(int From, int To)
{
	return (rand() % (To - From + 1) + From);
}

string GenerateKey(int Number)
{
	string GenerateKey = "";
	cout << "Key[" << Number << "]: ";
	for (int j = 1; j <= 4 ; j++)
	{
		for (int i = 1; i <= 4; i++)
		{
			GenerateKey += char(RandomSmallLetter(65, 90));
			if (i == 4 && j != 4)
				GenerateKey += "-";
		}
	}
	return GenerateKey;
}

void PrintGenerateKey(int Number)
{
	for (int i = 1; i <= Number; i++)
	{
		cout << GenerateKey(i) << endl;
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int Number = ReadPositiveNumber("Please Enter the number.");
	PrintGenerateKey(Number);
	_getch();
	return 0;
}