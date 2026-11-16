#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14159265358;

int ChangeToSeconds(int Days, int Hours, int Minutes, int Seconds)
{
	int TimeBySeconds = (Days * 24 * 3600) + (Hours * 3600) + (Minutes * 60) + Seconds;
	return TimeBySeconds;
}

int main()
{

	int Days, Hours, Minutes, Seconds;
	cout << "Please, enter the days.\n";
	cin >> Days;
	cout << "Please, enter the Hours.\n";
	cin >> Hours;
	cout << "Please, enter the Minutes.\n";
	cin >> Minutes;
	cout << "Please, enter the Seconds.\n";
	cin >> Seconds;
	cout << ChangeToSeconds(Days, Hours, Minutes, Seconds) << endl;

	_getch();
	return 0;
}