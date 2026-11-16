#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Number;
	do
	{
		cout << Message << endl;
		cin >> Number;
	} while (Number <= 0);
	return Number;
}

void PrintInvertedNumberPattern(int Number)
{
	for (int i = 65 + Number-1; i > 64; i--)
	{
		for (int j = 1; j <= Number - (65 +Number-1-i); j++)
		{
			cout << char(i);
			//cout << j << endl;
		}
		cout << endl;
	}
}
int main()
{
	PrintInvertedNumberPattern(ReadPositiveNumber(""));
	_getch();
	return 0;
}