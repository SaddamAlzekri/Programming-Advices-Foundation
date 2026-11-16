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

void SumUntillValue(int Number1)
{
	int Count = 0;
	while (Number1 != 1234 && Count < 3)
		{
			Count++;
			cout << "Please, enter the Number1.\n";
			cin >> Number1;
		}
	if (Number1 == 1234)
	{
		cout << "Your balance 7500";
	}
	}


int main()
{
	int Number1 = ReturnNumber1();
	SumUntillValue(Number1);
	_getch();
	return 0;
}