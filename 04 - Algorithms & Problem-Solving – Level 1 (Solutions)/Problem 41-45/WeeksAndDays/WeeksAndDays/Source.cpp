#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

float HoursToDays(float NumberOfHours)
{
	return NumberOfHours / 24;
}

float HoursToWeeks(float NumberOfHours)
{
	return NumberOfHours / 24 / 7;
}

float DayToWeeks(float NumberOfDay)
{
	return NumberOfDay / 7;
}

int main()
{
	float NumberOfHours = ReadPositiveNumber("Please Enter The Number\n");
	float NumberOfDay = HoursToDays(NumberOfHours);
	float NumberOfWeeks1 = DayToWeeks(NumberOfDay);
	float NumberOfWeeks2 = HoursToWeeks(NumberOfHours);


	cout << "Total Hours = " << NumberOfHours << endl;
	cout << "Total Day = " << NumberOfDay << endl;
	cout << "Total Weeks = " << NumberOfWeeks2 << endl;


	_getch();
	return 0;
}


