#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

enum enPrimeNotPrime
{
	Prime = 1, NotPrime = 2
};

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

enPrimeNotPrime CheckPrime(int Num)
{
	int M = round(Num / 2);
	for (int i = 2; i <= M; i++)
	{
		if (Num % i == 0)
			return enPrimeNotPrime::NotPrime;
	}

	return enPrimeNotPrime::Prime;
}

void PrintPrimeNumber(int Num)
{
	cout << "Prime Number From " << 1 << " To " << Num;
	cout << "\n";
	for (int i = 1; i < Num; i++)
	{
		if (CheckPrime(i) == enPrimeNotPrime::Prime)
			cout << i << endl;
	}
}

int main()
{
	int Num = ReadPositiveNumber("Please Enter Prime Number.");
	PrintPrimeNumber(Num);
	_getch();
	return 0;
}