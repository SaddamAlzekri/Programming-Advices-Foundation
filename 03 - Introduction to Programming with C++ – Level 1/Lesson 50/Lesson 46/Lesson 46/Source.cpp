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
	while (Number1 != 91)
	{
		cout << char(Number1) << endl;
		Number1++;
	}
}

int main()
{
	int Number1 = 65;
    SumUntillValue(Number1);
	_getch();
	return 0;
}