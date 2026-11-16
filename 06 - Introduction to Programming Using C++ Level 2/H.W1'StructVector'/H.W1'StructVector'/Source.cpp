#include<iostream>
#include<vector>
#include<conio.h>
#include<string>
using namespace std;

struct stEmployees
{
	string FirstName;
	string LastName;
	int Salary = 0;
};

void ReadEmployees(vector <stEmployees> &vEmployees, stEmployees tEmployees)
{

	char YOrN = 'Y';
	do
	{
		cout << "Please enter the firstname: ";
		cin >> tEmployees.FirstName;
		cout << "Please enter the LastName : ";
		cin >> tEmployees.LastName;
		cout << "Please enter the Salary   : ";
		cin >> tEmployees.Salary;
		cout << "Click \'Y\\y\' to continue: ";
		cin >> YOrN;
		vEmployees.push_back(tEmployees);
	} while (YOrN == 'Y' || YOrN == 'y');
	cout << endl;
}
void PrintEmployees(vector <stEmployees> vEmployees)
{
	for (stEmployees &Employees : vEmployees)
	{
		cout << "FirstName: " << Employees.FirstName << endl;
		cout << "LastName : " << Employees.LastName << endl;
		cout << "Salary   : " << Employees.Salary << endl;
		cout << endl;
	}
}
int main()
{

	vector <stEmployees> vEmployees;
	stEmployees tEmployees;
	ReadEmployees(vEmployees, tEmployees);
	PrintEmployees(vEmployees);
	_getch();
	return 0;
}