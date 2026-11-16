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

int ReturnNumber2()
{
	int  Number2;
	cout << "Please, enter the Number2.\n";
	cin >> Number2;
	return Number2;
}

int NPowerM(int Number1, int Number2)
{
	int Count = Number1;

	while ( Number2 > 1)
	{
		Count *= Number1;
		Number2--;
	}
	return Count;
}

int main()
{
	int Number1, Number2; 
	Number1 = ReturnNumber1();
	Number2 = ReturnNumber2();

	cout << "========================\n";
	cout << "NPowerM " << NPowerM(Number1, Number2) << endl;
	_getch();
	return 0;
}