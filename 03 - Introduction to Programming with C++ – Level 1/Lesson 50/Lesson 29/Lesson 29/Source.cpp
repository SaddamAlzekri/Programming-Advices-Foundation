#include<iostream>
#include<conio.h>
using namespace std;
int ReturnNumber()
{
	int Number;
	cout << "Please, enter the value.\n";
	cin >> Number;
	return Number;
}

int SumOddNumber(int Number)
{
	int Count = 0;
	while (Number >= 1)
	{
		if (Number % 2 == 0)
		{
			Count += Number;
		}
		Number--;
	}
	return Count;
}

int main()
{
	int Number = ReturnNumber();
	cout << "========================\n";
	cout << "The odd Number " << SumOddNumber(Number) << endl;
	_getch();
	return 0;
}