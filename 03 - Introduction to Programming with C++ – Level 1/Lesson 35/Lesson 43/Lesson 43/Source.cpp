#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14159265358;

void ChangeToSeconds(int Seconds)
{	
	int Days = Seconds / (24 * 3600);
	int RestDays = Seconds % (24 * 3600);
	int Hours = RestDays / 3600;
	int RestHours = RestDays % 3600;
	int Minutes = RestHours / 60;
	int RestMinutes = RestHours % 60;
	cout << Days << ":" << Hours << ":" << Minutes << ":" << RestMinutes << endl;
}

int main()
{

	int Seconds;
	cout << "Please, enter the Seconds.\n";
	cin >> Seconds;
	ChangeToSeconds(Seconds);

	_getch();
	return 0;
}