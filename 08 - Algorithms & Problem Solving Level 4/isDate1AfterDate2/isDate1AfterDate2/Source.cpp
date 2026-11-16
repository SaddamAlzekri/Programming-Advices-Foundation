#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

struct sDate
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

sDate ReadFullDate()
{
	sDate Date;
	Date.Day = ReadDay();
	Date.Month = ReadMonth();
	Date.Year = ReadYear();

	return Date;
}

bool Date1AfterDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year > Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month > Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day > Date2.Day : false)): false);
}

int main()
{
	cout << "Enter Datel: \n";
	sDate Date1 = ReadFullDate();
	cout << "\n\nEnter Datel2: \n";
	sDate Date2 = ReadFullDate();

	if (Date1AfterDate2(Date1, Date2))
	{
		cout << "\n\nYes, Date1 is After Date2.\n";
	}
	else
	{
		cout << "\n\nNo, Date1 isNot After Date2.\n";

	}
	_getch();
	return 0;
}