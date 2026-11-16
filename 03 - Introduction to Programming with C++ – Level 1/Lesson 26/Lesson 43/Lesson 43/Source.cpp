#include<iostream>
#include<conio.h>
using namespace std;
void TimeByClock(int TimeBySeconds)
{
	int Days = TimeBySeconds / 86400;
	int RestofDays = TimeBySeconds % 86400;
	int Hours = RestofDays / 3600;
	int RestOfHours = RestofDays % 3600;
	int Minutes = RestOfHours / 60;
	int Seconds = RestOfHours % 60;

	cout << Days << ":" << Hours << ":" << Minutes <<":"<< Seconds;
}
int main()
{
	int TimeBySeconds;
	cout << "Enter the Seconds.\n";
	cin >> TimeBySeconds;
	TimeByClock(TimeBySeconds);
	_getch();
	return 0;
}

