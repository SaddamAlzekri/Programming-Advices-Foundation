#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
struct StrTaskDuration
{
	int NumberOfDay;
	int NumberOfHourse;
	int NumberOfMinutes;
	int NumberOfSeconds;
};

int ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num <= 0);
	return Num;
}

StrTaskDuration SecondsToDayHourseMinutesSeconds(int TotalSeconds)
{
	StrTaskDuration TaskDuration;
	const int SecondOfDay = 24 * 60 * 60;
	const int SecondsOfHourse = 60 * 60;
	const int SecondsOfMinutes = 60;

	int Remainder = 0;

	TaskDuration.NumberOfDay = floor(TotalSeconds / SecondOfDay);
	Remainder = TotalSeconds % SecondOfDay;
	TaskDuration.NumberOfHourse = floor(Remainder / SecondsOfHourse);
	Remainder = Remainder % SecondsOfHourse;
	TaskDuration.NumberOfMinutes = floor(Remainder / SecondsOfMinutes);
	Remainder = Remainder % SecondsOfMinutes;
	TaskDuration.NumberOfSeconds = Remainder;
	return TaskDuration;

}

void PrintTaskDuration(StrTaskDuration TaskDuration)
{
	cout << TaskDuration.NumberOfDay << " : "
		<< TaskDuration.NumberOfHourse << " : "
		<< TaskDuration.NumberOfMinutes << " : "
		<< TaskDuration.NumberOfSeconds << endl;
}
int main()
{
	int Totalseconds = ReadPositiveNumber("Please Enter TotalSeconds");
	PrintTaskDuration(SecondsToDayHourseMinutesSeconds(Totalseconds));
	_getch();
	return 0;
}