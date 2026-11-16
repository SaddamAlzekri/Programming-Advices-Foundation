#include<iostream>
#include<conio.h>
using namespace std;

short ReadYear()
{
	short YearNumber = 0;
	cout << "Please enter the Number Of Year? ";
	cin >> YearNumber;

	return YearNumber;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfDayInYear(short YearNumber)
{
	return isLeapYear(YearNumber) ? 366 : 365;
}

short NumberOfHoursInYear(short YearNumber)
{
	return  NumberOfDayInYear(YearNumber) * 24;
}

int NumberOfMinutesInYear(short YearNumber)
{
	return  NumberOfHoursInYear(YearNumber) * 60;
}

int NumberOfSecondsInYear(short YearNumber)
{
	return  NumberOfMinutesInYear(YearNumber) * 60;
}

int main()
{	
	short Year = ReadYear();

	cout << "Number of day      in year [" << Year << "] is : ";
	cout << NumberOfDayInYear(Year) << endl;

	cout << "Number of Hours    in year [" << Year << "] is : ";
	cout << NumberOfHoursInYear(Year) << endl;

	cout << "Number of Minutes  in year [" << Year << "] is : ";
	cout << NumberOfMinutesInYear(Year) << endl;

	cout << "Number of Seconds  in year [" << Year << "] is : ";
	cout << NumberOfSecondsInYear(Year) << endl;

	_getch();
	return 0;
}