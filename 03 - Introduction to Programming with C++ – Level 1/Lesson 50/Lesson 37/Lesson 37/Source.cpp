#include<iostream>
#include<conio.h>
using namespace std;
int ReturnNumber1()
{
	int Number1;
	cout << "Please, enter the Number1.\n";
	cin >> Number1;
	return Number1;
}

int SumUntillValue(int Number1)
{
	int Count = 0;
	while (Number1 != -99)
	{
		Count += Number1;
		cout << "Please, enter the Number1.\n";
		cin >> Number1;
	}
	return Count;
}

int main()
{
	int Number1;
	Number1 = ReturnNumber1();
	cout << "====================\n";
	cout << "The result " << SumUntillValue(Number1) << endl;
	_getch();
	return 0;
}