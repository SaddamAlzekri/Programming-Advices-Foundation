#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

int main()
{
	string Name = "Saddam Al-zekri", City = "Taiz", Country = "YEMEN";
	int Age = 25, MonthlySalary = 5000, YearlySalary = MonthlySalary * 12;
	char Gendar = 'M';
	bool Married = 1;
	cout << "******************************"<<endl;
	cout << "Name: " << Name << endl;
	cout << "Age: " << Age << endl;
	cout << "City: " << City << endl;
	cout << "Country :" << Country << endl;
	cout << "Monthly Salary: " << MonthlySalary << endl;
	cout << "Yearly Salary:" << YearlySalary << endl;
	cout << "Gendar: " << Gendar << endl;
	cout << "Maried: " << Married << endl;
	cout << "******************************"<<endl;

	_getch();
	return 0;
}