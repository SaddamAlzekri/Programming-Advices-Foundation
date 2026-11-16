#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

enum enMonthOfYear
{
	Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6,
	Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12
};

int ReadPositiveNumber(string Message, int From, int To)
{
	int Num = 0;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < From||Num > To);
	return Num;
}

enMonthOfYear MonthOfYear()
{
	return (enMonthOfYear)ReadPositiveNumber("Please Enter The Number Of Month 1-12.", 1, 12);
}

string GetMonthOfYears(enMonthOfYear MonthOfYear)
{
	switch (MonthOfYear)
	{
	case enMonthOfYear::Jan:
		return "Jun";
	case enMonthOfYear::Feb:
		return "Feb";
	case enMonthOfYear::Mar:
		return "Mar";
	case enMonthOfYear::Apr:
		return "Apr";
	case enMonthOfYear::May:
		return "May";
	case enMonthOfYear::Jun:
		return "Jun";
	case enMonthOfYear::Jul:
		return "Jul";
	case enMonthOfYear::Aug:
		return "Aug";
	case enMonthOfYear::Sep:
		return "Sep";
	case enMonthOfYear::Oct:
		return "Oct";
	case enMonthOfYear::Nov:
		return "Nov";
	case enMonthOfYear::Dec:
		return "Dec";
	default:
		break;
	}
}

int main()
{
	cout << GetMonthOfYears(MonthOfYear());
	_getch();
	return 0;
}