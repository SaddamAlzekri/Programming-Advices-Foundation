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

void isLeapYear(int Number)
{
	((Number % 4 == 0) ? cout << "This year " << Number << " is Leap year" : cout << "This year " << Number << " is not Leap year");

}

int main()
{
	int YearNumber = Year();
	isLeapYear(YearNumber);

	_getch();
	return 0;
}
