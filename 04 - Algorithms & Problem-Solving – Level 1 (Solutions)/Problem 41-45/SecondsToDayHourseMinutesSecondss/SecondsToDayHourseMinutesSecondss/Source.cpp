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
int main()
{
	cout << "sssss";
	_getch();
	return 0;
}