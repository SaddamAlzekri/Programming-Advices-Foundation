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

void PrintAllPrime1ToN(int Num)
{
	string Str = to_string(Num);
	int N = Str.length();
	cout << "Input\n";
	for (int i = N - 1; i >= 0; i--)
	{
		cout << Str[i] << endl;
	}
}

void PrintAllPrime1ToNN(int Num)
{
	int Remainder;
	while (Num > 0)
	{
		Remainder = Num % 10;
		Num = Num / 10;
		cout << Remainder << endl;
	}
}

int main()
{
	int Num = ReadPositiveNumber("Output");
	PrintAllPrime1ToNN(Num);

	_getch();
	return 0;
}