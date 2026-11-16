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

	for (int i = 1; i <= Num; i++)
	{
		cout << i << endl;
	}
}

void PrintRangeNumberFrom1ToNUsingWhile(int Num)
{
	int Count = 1;
	cout << "Range printed using while statement:\n";
	while (Count <= Num)
	{
		cout << Count << endl;
		Count++;
	}
}

void PrintRangeNumberFrom1ToNUsingDoWhile(int Num)
{
	int Count = 1;
	cout << "Range printed using do while statement:\n";
	do
	{
		cout << Count << endl;
		Count++;
	} while (Count <= Num);
}

int main()
{
	int N = ReadNumber();
	//PrintRangeNumberFrom1ToNUsingFor(N);
	//PrintRangeNumberFrom1ToNUsingWhile(N);
	PrintRangeNumberFrom1ToNUsingDoWhile(N);

	_getch();
	return 0;
}