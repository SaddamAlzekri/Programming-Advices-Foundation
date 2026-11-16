#include<iostream>
#include<conio.h>
using namespace std;

enum enComparDateFunction
{
	Before = -1, Equal = 0, After = 1
};

struct sDate
{
	short Day;
	short Month;
	short Year;
};

short ReadDay()
{
	short Day;
	cout << "Please enter a Day? ";
	cin >> Day;

	return Day;
}

short ReadMonth()
{
	short Month;
	cout << "Please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadYear()
{
	short Year;
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

bool isDate1BeforDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year < Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? ((Date1.Month < Date2.Month) ? true :
		(Date1.Year == Date2.Year ? Date1.Month < Date2.Month : false)) : false);
}

bool isDate1EqualDate2(sDate Date1, sDate Date2)
{
	if (Date1.Year == Date2.Year && Date1.Month == Date2.Month && Date1.Day == Date2.Day)
		return true;
	
	return false;
}

bool isDate1AfterDate2(sDate Date1, sDate Date2)
{
	return (Date1.Year > Date2.Year) ? true :
		((Date1.Year == Date2.Year) ? ((Date1.Month > Date2.Month) ? true :
		(Date1.Year == Date2.Year ? Date1.Month > Date2.Month : false)) : false);
}

enComparDateFunction ChoiceDateFunction(sDate Date1, sDate Date2)
{
	if (isDate1BeforDate2(Date1, Date2))
		return (enComparDateFunction) -1;
	else if (isDate1EqualDate2(Date1, Date2))
		return (enComparDateFunction) 0;
	if (isDate1AfterDate2(Date1, Date2))
		return (enComparDateFunction) 1;

}

void CompareDateFunction(sDate Date1, sDate Date2)
{
	enComparDateFunction CompareDates = ChoiceDateFunction(Date1, Date2);
	switch (CompareDates)
	{
	case enComparDateFunction::Before:
		cout << "Compare Result = " <<enComparDateFunction::Before;
		break;
	case enComparDateFunction::Equal:
		cout << "Compare Result = " << enComparDateFunction::Equal;
		break;
	case enComparDateFunction::After:
		cout << "Compare Result = " << enComparDateFunction::After;
		break;

	default:
		break;
	}
}

int main()
{
	cout << "Enter Date1: " << endl;
	sDate Date1 = ReadFullDate();
	cout << "\n\nEnter Date2: " << endl;
	sDate Date2 = ReadFullDate();

	cout << "\n\n";
	CompareDateFunction(Date1, Date2);

	_getch();
	return 0;
}