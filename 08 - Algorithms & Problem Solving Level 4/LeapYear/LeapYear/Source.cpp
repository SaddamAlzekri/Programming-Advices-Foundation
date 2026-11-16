#include<iostream>
#include<conio.h>
using namespace std;

int Year()
{
	int YearNumber = 0;
	cout << "Please Number of Year!!!\n";
	cin >> YearNumber;

	return YearNumber;
}

bool isLeapYear(int Number)
{
	if (Number % 400 == 0)
	{
		return true;
	}
	else if (Number % 100 == 0)
	{
		return false;
	}
	else if (Number % 4 == 0)
	{
		return true;
	}
	else
	{
		return false;
	}

}
int main()
{
	int YearNumber = Year();
	if (isLeapYear(YearNumber))
	{
		cout << "This year " << YearNumber << " is Leap year";
	}
	else
	{
		cout << "This year " << YearNumber << " is not Leap year";

	}
	_getch();
	return 0;
}