#include<iostream>
#include<conio.h>
using namespace std;

struct StInfo
{
	int Age;
	bool HasDriverLicense;
};

StInfo ReadInfo()
{
	StInfo Info;
	cout << "Please enter the Age\n";
	cin >> Info.Age;
	cout << "Do you have Driver License\n";
	cin >> Info.HasDriverLicense;
	return Info;
}

bool IsAccept(StInfo Info)
{
	return (Info.Age > 21 && Info.HasDriverLicense);
}

void PrintInfo(StInfo Info)
{
	if (IsAccept(Info))
		cout << "Hired\n";
	else
		cout << "Reject\n";
}

int main()
{
	PrintInfo(ReadInfo());
	_getch();
	return 0;
}