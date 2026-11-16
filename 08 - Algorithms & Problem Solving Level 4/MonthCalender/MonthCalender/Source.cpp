#include<iostream>
#include<iomanip>
#include<string>
#include<conio.h>
using namespace std;

string MonthShortName(short Month)
{
	string arrShortNameOfMonth[12] = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Seb", "Oct", "Nov", "Dec" };

	return arrShortNameOfMonth[Month - 1];
}

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short DayOfWeekOrder(short Day, short Month, short Year)
{
	short a, y, m;

	a = (14 - Month) / 12;
	
	y = Year - a;

	m = Month + (12 * a) - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

short NumberOfDaysInAMonth(short Month, short Year)
{
	int arrMonthDays[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return ((Month == 2) ? isLeapYear(Year) ? 29 : 28 : arrMonthDays[Month - 1]);
}

void PrintMonthCalender(short Day, short Month, short Year)
{
	short Current = DayOfWeekOrder(1, Month, Year);
	short NumberOfDays = NumberOfDaysInAMonth(Month, Year);

	printf("\n____________________%s______________________\n", MonthShortName(Month).c_str());

	printf("   Sun   Mon   Tue   Wed   Thu   Fri   Sat   \n");

	short i;
	for (i = 0; i < Current; i++)
		printf("      ");
	for (short j = 1; j <= NumberOfDays; j++)
	{
		printf("%5d", j);

		if (++i == 7)
		{
			i = 0;
			printf("\n");
		}
	}

	printf("\n____________________________________________\n");
}

short ReadYear()
{
	short Year = 0;
	cout << "Please enter a Year? ";
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

int main()
{
	short Year = ReadYear();
	short Month = ReadMonth();

	PrintMonthCalender(1, Month, Year);

	_getch();
	return 0;
}