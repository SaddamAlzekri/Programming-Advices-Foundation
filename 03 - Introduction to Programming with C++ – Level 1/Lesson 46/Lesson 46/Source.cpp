#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
enum enweekDay {Sunday = 1, Monday = 2, Tuesday = 3, wendesday = 4, Thuresday = 5, friday = 6, Saturday = 7};
void ShowWeekDay()
{
	cout << "***********************************\n";
	cout << "*             WeekDay             *\n";
	cout << "***********************************\n";
	cout << "(1) Sunday\n";
	cout << "(2) Monday\n";
	cout << "(3) Tuesday\n";
	cout << "(4) Wendesday\n";
	cout << "(5) Thuresday\n";
	cout << "(6) Friday\n";
	cout << "(7) Saturday\n";
	cout << "***********************************\n";
}
enweekDay DayNumber()
{
	int DayNum;
	cout << "Please, enter the day number.\n";
	cin >> DayNum;
	return (enweekDay)DayNum;
}

string PrintweekDay(enweekDay day)
{
	switch (day)
	{
	case 1:
		return "It is Sunday\n";
		break;
	case 2:
		return "It is Monday\n";
		break;
	case 3:
		return "It is Tuesday\n";
		break;
	case 4:
		return "It is wendesday\n";
		break;
	case 5:
		return "It is Thuresday\n";
		break;
	case 6:
		return "It is Friday\n";
		break;
	case 7:
		return "It is Saturday\n";
		break;
	default:
		return "Wrong Day Number\n";
		break;
	}
}
int main()
{
	ShowWeekDay();
	cout << PrintweekDay(DayNumber());
	_getch();
	return 0;
}