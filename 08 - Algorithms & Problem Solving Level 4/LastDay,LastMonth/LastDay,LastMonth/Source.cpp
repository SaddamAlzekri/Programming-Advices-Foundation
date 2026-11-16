#include<iostream>
#include<conio.h>
using namespace std;

struct sDate1
{
	short Day;
	short Month;
	short Year;
};

short ReadDay()
{
	short Day = 0;
	cout << "Please enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a Year? ";
	cin >> Year;

	return Year;
}

sDate1 ReadFullDate1()
{
	sDate1 Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();
	return Date;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfDayInMonth(short Month, short Year)
{
	short arrNumberMonth[12] = { 13, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : arrNumberMonth[Month - 1];
}

bool isLastDay(sDate1 Date1)
{
	return (Date1.Day == NumberOfDayInMonth(Date1.Month, Date1.Year));
}

bool isLastMonth(sDate1 Date1)
{
	return (Date1.Month == 12) ? true : false;
}

int main()
{
	sDate1 Date1 = ReadFullDate1();

	if (isLastDay(Date1))
		cout << "\n\nYes, Day is Last Day in Month.";
	else
		cout << "\nNo, Day isnot Last Day in Month.";

	if (isLastMonth(Date1))
		cout << "\nYes, Month is Last Month in Year.";
	else
		cout << "\nNo, Month isnot Last Month in Year.";

	_getch();
	return 0;
}
