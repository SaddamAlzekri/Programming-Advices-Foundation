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

void PrintFrom1ToN(int Number)
{
	while (Number >= 1)
	{
		cout << Number << endl;
		Number--;
	}
}
int main()
{
	int Number = ReturnNumber();
	cout << "========================\n";
	PrintFrom1ToN(Number);
	_getch();
	return 0;
}