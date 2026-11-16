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

int Factorial(int Number)
{
	int Count = 1;
	while (Number >= 1)
	{
		Count *= Number;
		Number--;
	}
	return Count;
}

int main()
{
	int Number = ReturnNumber();
	cout << "========================\n";
	cout << "The Factorial is " << Factorial(Number) << endl;
	_getch();
	return 0;
}