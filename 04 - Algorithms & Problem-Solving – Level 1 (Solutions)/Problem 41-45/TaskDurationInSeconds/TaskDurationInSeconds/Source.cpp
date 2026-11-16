#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

struct StrTaskDuration
{
	int NumberOfDay;
	int NumberOfHours;
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

StrTaskDuration ReadTaskDuration()
{
	StrTaskDuration TaskDuration;

	TaskDuration.NumberOfDay = ReadPositiveNumber("Please Enter the Day Number.");
	TaskDuration.NumberOfHours = ReadPositiveNumber("Please Enter the Hours Number.");
	TaskDuration.NumberOfMinutes = ReadPositiveNumber("Please Enter the Minutes Number.");
	TaskDuration.NumberOfSeconds = ReadPositiveNumber("Please Enter the Seconds Number.");
	return TaskDuration;

}

int TaskDurationInSeconds(StrTaskDuration TaskDuration)
{
	int DurationInSeconds = 0;

	DurationInSeconds = TaskDuration.NumberOfDay * 24 * 60 * 60;
	DurationInSeconds += TaskDuration.NumberOfHours * 60 * 60;
	DurationInSeconds += TaskDuration.NumberOfMinutes * 60;
	DurationInSeconds += TaskDuration.NumberOfSeconds;

	return DurationInSeconds;
}
int main()
{

	cout << "Task DurationIn Seconds: " << TaskDurationInSeconds(ReadTaskDuration()) << endl;


	_getch();
	return 0;
}