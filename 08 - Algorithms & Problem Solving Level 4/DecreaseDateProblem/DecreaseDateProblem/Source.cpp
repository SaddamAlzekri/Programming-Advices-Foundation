#include<iostream>
#include<conio.h>
using namespace std;

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

bool isLeapYear(short Year)
{
	return ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0);
}

short  NumberDayOfMonth(short Month, short Year)
{
	if (Month > 12 || Month < 1)
		return 0;

	int Days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

	return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : Days[Month - 1];
}

sDate IncreaseOneDay(sDate Date)
{
	if (Date.Day == 1)
	{
		if (Date.Month == 1)
		{
			Date.Month = 12;
			Date.Day = NumberDayOfMonth(Date.Month, Date.Year);
			Date.Year--;
		}
		else
		{
			Date.Month -= 1;
			Date.Day = NumberDayOfMonth(Date.Month, Date.Year);
		}
	}
	else
	{
		Date.Day--;
	}

	return Date;
}

sDate IncreasetenDay(short TenYears, sDate Date)
{
	for (short i = 0; i < TenYears; i++)
	{
		Date = IncreaseOneDay(Date);
	}

	return Date;
}

sDate IncreaseOneWeek(sDate Date)
{
	for (short i = 0; i < 7; i++)
	{
		Date = IncreaseOneDay(Date);
	}

	return Date;
}

sDate IncreaseTenWeek(short TenWeek, sDate Date)
{
	for (short i = 0; i < TenWeek; i++)
	{
		Date = IncreaseOneWeek(Date);
	}

	return Date;
}

sDate IncreaseOneMonth(sDate Date)
{
	(Date.Month == 1) ? Date.Month = 12, Date.Year -= 1 : Date.Month--;

	short NumberOfDayForMonth = NumberDayOfMonth(Date.Month, Date.Year);

	if (Date.Day > NumberOfDayForMonth)
		Date.Day = NumberOfDayForMonth;

	return Date;
}

sDate IncreaseFiveMonth(sDate Date)
{

	for (short i = 0; i < 5; i++)
	{
		Date = IncreaseOneMonth(Date);
	}

	return Date;
}

sDate IncreaseOneYear(sDate Date)
{
	Date.Year--;

	return Date;
}

sDate IncreaseTenYear(sDate Date)
{
	for (short i = 0; i < 10; i++)
	{
		Date = IncreaseOneYear(Date);
	}


	return Date;
}

sDate IncreaseTenYear(short TenYear, sDate Date)
{
	Date.Year -= TenYear;

	return Date;
}

sDate IncreaseOneDecade(sDate Date)
{
	Date.Year -= 10;

	return Date;
}

sDate IncreaseTenDecade(short Decade, sDate Date)
{
	for (short i = 0; i < Decade * 10; i++)
	{
		Date = IncreaseOneYear(Date);
	}

	return Date;
}

sDate IncreaseTenDecadeFaster(short Decade, sDate Date)
{
	Date.Year -= Decade * 10;

	return Date;
}

sDate IncreaseOneCentury(sDate Date)
{
	Date.Year -= 100;
	return Date;
}

sDate IncreaseOneMillennium(sDate Date)
{
	Date.Year -= 1000;

	return Date;
}

int main()
{
	sDate Date = ReadFullDate();

	cout << "\n\nDate after: \n\n";

	Date = IncreaseOneDay(Date);
	cout << "01-Adding One Day: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreasetenDay(10, Date);
	cout << "02-Adding Ten Days: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneWeek(Date);
	cout << "03-Adding One Week: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseTenWeek(10, Date);
	cout << "04-Adding Ten Week: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneMonth(Date);
	cout << "05-Adding One Monthes: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseFiveMonth(Date);
	cout << "06-Adding Five Monthes: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneYear(Date);
	cout << "07-Adding One Year: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseTenYear(Date);
	cout << "08-Adding Ten Year: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseTenYear(10, Date);
	cout << "9-Adding Ten Year (faster): ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneDecade(Date);
	cout << "10-Adding One Decade: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseTenDecade(10, Date);
	cout << "11-Adding Ten Decade: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseTenDecadeFaster(10, Date);
	cout << "12-Adding Ten Decade (faster): ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneCentury(Date);
	cout << "13-Adding One Century: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	Date = IncreaseOneMillennium(Date);
	cout << "14-Adding One Millennium: ";
	cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;

	_getch();
	return 0;
}