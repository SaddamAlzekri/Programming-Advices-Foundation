#include<iostream>
#include<conio.h>
using namespace std;
int TimeBySeconds(int Days, int Hours, int Minutes, int Seconds)
{
	int TimeSeconds = (Days*24*3600) + (Hours*3600) + (Minutes * 60) + Seconds;
	return TimeSeconds;
}

int main()
{
	short Days, Hours, Minutes, Seconds;
	cout << "Enter the Number of Days that work its.\n";
	cin >> Days;//2
	cout << "Enter the Number of Hours that work its.\n";
	cin >> Hours;//5
	cout << "Enter the Number of Minutes that work its.\n";
	cin >> Minutes;//45
	cout << "Enter the Number of Seconds that work its.\n";
	cin >> Seconds;//35
	cout <<"The Time by Second : "<<TimeBySeconds(Days, Hours, Minutes, Seconds) << endl;//193,535
	_getch();
	return 0;
}