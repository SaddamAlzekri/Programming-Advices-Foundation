#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
struct StInfo
{
	string FirstName;
	string LastName;
};

StInfo ReadName()
{
	StInfo Info;
	cout << "Please enter the first name\n";
	cin >> Info.FirstName;
	cout << "Please enter the last name\n";
	cin >> Info.LastName;
	return Info;
}

string FullName(StInfo Info, bool reverce)
{
	string FullName;
	if (reverce)
		FullName = Info.LastName + " " + Info.FirstName;
	else 
		FullName = Info.FirstName + " " + Info.LastName;
	return FullName;
}

void PrintFullName(string Name)
{
	cout << "The Full Name is " << Name << endl;
}
int main()
{
	PrintFullName(FullName(ReadName(), true));
	_getch();
	return 0;
}