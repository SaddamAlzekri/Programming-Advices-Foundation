#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
void YearMonth(short Num1)
{
	switch (Num1)
	{
	case 1:
		cout << "It is January";
		break;
	case 2:
		cout << "It is Fabruary";
		break;
	case 3:
		cout << "It is March";
		break;
	case 4:
		cout << "It is April";
		break;
	case 5:
		cout << "It is May";
		break;
	case 6:
		cout << "It is June";
		break;
	case 7:
		cout << "It is Jully";
		break;
	case 8:
		cout << "It is August";
		break;
	case 9:
		cout << "It is Septemper";
		break;
	case 10:
		cout << "It is October";
		break;
	case 11:
		cout << "It is November";
		break;
	case 12:
		cout << "It is December";
		break;
	default:
		cout << "Wrong Month";
		break;
	}
}
int main()
{
	short Num1;
	cout << "Please, enter the Num1.\n";
	cin >> Num1;
	YearMonth(Num1);
	_getch();
	return 0;
}