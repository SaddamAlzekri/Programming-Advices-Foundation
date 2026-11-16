#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
void WeekDay(short Num1)
{
	switch (Num1)
	{
	case 1:
		cout << "It is Sunday";
		break;
	case 2:
		cout << "It is Monday";
		break;
	case 3:
		cout << "It is Tuesday";
		break;
	case 4:
		cout << "It is Wendesday";
		break;
	case 5:
		cout << "It is Thuresday";
		break;
	case 6:
		cout << "It is Friday";
		break;
	case 7:
		cout << "It is friday";
		break;
	default:
		cout << "Wrong Day";
		break;
	}
}
int main()
{
	short Num1;
	cout << "Please, enter the Num1.\n";
	cin >> Num1;
	WeekDay(Num1);
	_getch();
	return 0;
}