#include<iostream>
#include<conio.h>
using namespace std;

struct sDate
{
	short Day;
	short Month;
	short Year;
};

enum CompareDate
{
	Before = -1, Equal = 0, After = 1
};

struct Period
{
	sDate startDate;
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

Period ReadPeriod()
{
	Period Period;
	cout << "Enter start Period: \n\n";
	Period.startDate = ReadFullDate();
	cout << "Enter End Period: \n\n";
	Period.EndDate = ReadFullDate();

	return Period;
}

bool Date1BeforeDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true :
		(Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)): false );
}

bool Date1EqualDate2(sDate Date1, sDate Date2)
{
	if (Date1.Year == Date2.Year && Date1.Month == Date2.Month && Date1.Day == Date2.Day)
		return true;
	return false;
}

bool DateAfterDate2(sDate Date1, sDate Date2)
{
	if (!Date1BeforeDate2(Date1, Date2) && !Date1EqualDate2(Date1, Date2))
		return true;
	return false;
}

CompareDate CompareBeteen(sDate Date1, sDate Date2)
{
	if (Date1BeforeDate2(Date1, Date2))
		return CompareDate::Before;
	else if (Date1EqualDate2(Date1, Date2))
		return CompareDate::Equal;
	else
		return CompareDate::After;
}

bool DateWithinPeriod(sDate Date, Period period)
{
	return !(CompareBeteen(Date, period.startDate) == CompareDate::Before
		&&
		CompareBeteen(Date, period.startDate) == CompareDate::After);
}

int main()
{

	cout << "Enter Period: \n";
	Period Period1 = ReadPeriod();

	cout << "\nEnter Date to Check? \n";                                
	sDate CheckOfDate = ReadFullDate();

	if (DateWithinPeriod(CheckOfDate, Period1))
		cout << "\n\nYes, Date is within Period.\n";
	else
		cout << "\n\nNo, Date is not Within Period.\n";


	_getch();
	return 0;
}
