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

sDate1 ReadFullDate()
{
	sDate1 Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();
	return Date;
}

bool isDate1LessThanDate2(sDate1 Date1, sDate1 Date2)
{
	return (Date1.Year < Date2.Year) ? true : 
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : 
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) :false);
}

int main()
{
	sDate1 Date1 = ReadFullDate();
	cout << "\n\n";
	sDate1 Date2 = ReadFullDate();

	if (isDate1LessThanDate2(Date1, Date2))
		cout << "\n\nYes, Date1 is Less than Date2\n";
	else
		cout << "\n\nNo, Date1 isnot Less than Date2\n";

	_getch();
	return 0;
}
