#include<iostream>
#include<conio.h>
using namespace std;

int ReadNumber()
{
	int Num;
	cout << "Please enter the number.\n";
	cin >> Num;
	return Num;
}

void PrintRangeNumberFrom1ToNUsingFor(int Num)
{
	cout << "Range printed using for statement:\n";

	for (int i = Num; i >= 1; i--)
	{
		cout << i << endl;
	}
}

void PrintRangeNumberFrom1ToNUsingWhile(int Num)
{
	cout << "Range printed using while statement:\n";
	while (Num >= 1)
	{
		cout << Num << endl;
		Num--;
	}
}

void PrintRangeNumberFrom1ToNUsingDoWhile(int Num)
{
	cout << "Range printed using do while statement:\n";
	do
	{
		cout << Num << endl;
		Num--;
	} while (Num >= 1);
}

int main()
{
	int N = ReadNumber();
	PrintRangeNumberFrom1ToNUsingFor(N);
	PrintRangeNumberFrom1ToNUsingWhile(N);
	PrintRangeNumberFrom1ToNUsingDoWhile(N);

	_getch();
	return 0;
}