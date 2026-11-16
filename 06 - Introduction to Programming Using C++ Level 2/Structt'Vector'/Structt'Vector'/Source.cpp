#include<iostream>
#include<vector>
#include<conio.h>
#include<string>
using namespace std;

struct stEmployees
{
	string FirstName;
	string LastName;
	float Salary;
};

int main()
{
	vector <stEmployees> vEmployees;

	stEmployees tEmployees;

	tEmployees.FirstName = "Saddam";
	tEmployees.LastName = "Al-zekri";
	tEmployees.Salary = 5000;
	vEmployees.push_back(tEmployees);

	tEmployees.FirstName = "Ali";
	tEmployees.LastName = "Al-Magrami";
	tEmployees.Salary = 3000;
	vEmployees.push_back(tEmployees);

	tEmployees.FirstName = "Omar";
	tEmployees.LastName = "Al-Qadasi";
	tEmployees.Salary = 1000;
	vEmployees.push_back(tEmployees);


	cout << "Employees Vector: \n\n";

	for (stEmployees &Employees: vEmployees)
	{
		cout << "FirstName: " << Employees.FirstName << endl;
		cout << "LastName : " << Employees.LastName << endl;
		cout << "salary   : " << Employees.Salary << endl;

		cout << "\n\n";
	}
	_getch();
	return 0;

}