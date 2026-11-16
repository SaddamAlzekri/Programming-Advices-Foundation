#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

int main()
{
	string Name, City, Country;
	int Age, MonthlySalary, YearlySalary;
	char Gendar;
	bool Married;

	cout << "Enter your name.\n";
	cin >> Name;
	cout << "Enter your age.\n";
	cin >> Age;
	cout << "Enter your city.\n";
	cin >> City;
	cout << "Enter your country.\n";
	cin >> Country;
	cout << "Enter your monthly salary.\n";
	cin >> MonthlySalary;
	cout << "Enter your gendar.\n";
	cin >> Gendar;
	cout << "Are you maried.\n";
	cin >> Married;

	cout << endl << endl;


	cout << "******************************" << endl;
	cout << "Name: " << Name << endl;
	cout << "Age: " << Age << endl;
	cout << "City: " << City << endl;
	cout << "Country :" << Country << endl;
	cout << "Monthly Salary: " << MonthlySalary << endl;
	cout << "Yearly Salary:" << MonthlySalary * 12 << endl;
	cout << "Gendar: " << Gendar << endl;
	cout << "Maried: " << Married << endl;
	cout << "******************************" << endl;

	_getch();
	return 0;
}