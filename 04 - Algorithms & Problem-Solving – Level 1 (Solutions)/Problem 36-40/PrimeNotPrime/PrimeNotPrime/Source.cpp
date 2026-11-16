#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
enum enPrimeNotPrime
{
	Prime = 1,
	NotPrime = 2
};

float ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

enPrimeNotPrime CheckPrime(int PositiveNumber)
{
	int N = round(PositiveNumber / 2);
	for (int Counter = 2; Counter <= N; Counter++)
	{
		if (PositiveNumber % Counter == 0)
			return enPrimeNotPrime::NotPrime;
	}
	return enPrimeNotPrime::Prime;
} 

void PrintNumberType(int Number)
{

	switch (CheckPrime(Number))
	{
	case enPrimeNotPrime::Prime:
		cout << "The number is Prime\n";
		break;
	case enPrimeNotPrime::NotPrime:
		cout << "The number is not Prime\n";
		break;
	}
}

int main()
{
	PrintNumberType(ReadPositiveNumber("Please enter the number"));
	_getch();
	return 0;
}