#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a year? ";
	cin >> Year;

	return Year;
}

short ReadMonth()
{
	short Month = 0;
	cout << "Please enter a Month? ";
	cin >> Month;

	return Month;
}

short ReadDay()
{
	short Day = 0;
	cout << "Please enter a Day? ";
	cin >> Day;

	return Day;
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short NumberOfDayInAYear(short Year)
{
	short NumberOfYearDay = 0;
	if (isLeapYear(Year))
	{
		NumberOfYearDay = 366;
	}
	NumberOfYearDay = 365;
	return NumberOfYearDay;
}

short DayOrder(short Day, short Month, short Year)
{
	int a, y, m, d;
	if (Month > 12 || Month < 1)
		return 0;

	a = ((14 - Month) / 12);
	y = Year - a;
	m = Month + 12 * a - 2;

	d = (Day + y + (y / 4) - (y / 100) + (y / 400) + (31 * m / 12)) % 7;
	
	return d;
}

string DayOfWeek(short Day)
{
	string arrDayOfWeek[8] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
	

	return arrDayOfWeek[Day];
}

int main()
{

	short Year = ReadYear();
	cout << "\n";
	short Month = ReadMonth();
	cout << "\n";
	short Day = ReadDay();

	short NumberDayOfWeek = DayOrder(Day, Month, Year);

	cout <<"\nDate     : "<<Day << "/" << Month << "/" << Year << endl;
	cout << "Day Ordre : " << NumberDayOfWeek << endl;
	cout << "Day Name  : " << DayOfWeek(NumberDayOfWeek) << endl;
	_getch();
	return 0;
}