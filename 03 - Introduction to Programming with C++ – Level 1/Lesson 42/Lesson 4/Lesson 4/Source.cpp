#include<iostream>
#include<conio.h>
using namespace std;
void AcceptInCompany(short Age, bool DriverLicence)
{
	if (Age >= 21 && DriverLicence == true)
	{
		cout << "***********************\nYou are Hired\n";
	}
	else
	{
		cout << "***********************\nYou are Reject\n";
	}
}
int main()
{
	short Age;
	bool DriverLicence;
	cout << "Please, enter the your Age.\n";
	cin >> Age;
	cout << "Do you have driver license?\n";
	cin >> DriverLicence;
	AcceptInCompany(Age, DriverLicence);

	_getch();
	return 0;
}