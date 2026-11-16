#include<iostream>
#include<conio.h>
using namespace std;


struct sDate
{
	short Day;
	short Month;
	short Year;

};

enum enDateCompare
{
	Berfore = -1 , Equal = 0, After = 1
};

struct Period
{
	sDate StartDate;
	sDate EndDate;
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

Period ReadPeroids()
{
	Period Peroids;
	cout << "\nEnter start Date: \n\n";
	Peroids.StartDate = ReadFullDate();
	cout << "\n\nEnter End Date: \n\n";
	Peroids.EndDate = ReadFullDate();

	return Peroids;
}

bool isDate1BeforeDAte2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? ((Date1.Month < Date2.Month) ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day: false)) : false);
}

bool isDate1EqualDate2(sDate Date1, sDate Date2)
{
	return ((Date1.Year == Date2.Year) ? ((Date1.Month == 
		Date2.Month) ? ((Date1.Day == Date2.Day) ? true : false) : false)
		: false);
}

bool isDate1AfterDate2(sDate Date1, sDate Date2)
{
	return !(isDate1BeforeDAte2(Date1, Date2));
}

enDateCompare CompareDate(sDate Date1, sDate Date2)
{
	if (isDate1BeforeDAte2(Date1, Date2))
		return enDateCompare::Berfore;
	else if (isDate1EqualDate2(Date1, Date2))
		return enDateCompare::Equal;
	else
		return enDateCompare::After;
}

bool isOverLap(Period Peroid1, Period Peroid2)
{
	if (CompareDate(Peroid2.EndDate, Peroid1.StartDate) == enDateCompare::Berfore
		||
		CompareDate(Peroid2.StartDate, Peroid1.EndDate) == enDateCompare::After)
		return false;
	else
		return true;
}

int main()
{
	cout << "Enter Peroid 1: ";
	Period Peroid1 = ReadPeroids();	cout << isDate1BeforeDAte2(Peroid1.StartDate, Peroid1.EndDate);

	cout << "\n\nEnter Peroid 2: ";
	Period Peroid2 = ReadPeroids();

	if (isOverLap(Peroid1, Peroid2))
	{
		cout << "Yes, Peroid OverLap\n";
	}
	else
	{
		cout << "No, Peroid OverLap\n";
	}

	_getch();
	return 0;
}