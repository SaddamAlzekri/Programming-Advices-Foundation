#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
struct stEmployee
{
	string Name;
	float Salary;
};

int main()
{
	stEmployee Employee1, *Ptr;

	Employee1.Name = "saddam al-zekri";
	Employee1.Salary = 5000;

	cout << Employee1.Name << endl;
	cout << Employee1.Salary << endl;
	Ptr = &Employee1;

	cout << Ptr->Name << endl;
	cout << Ptr->Salary << endl;

	_getch();
	return 0;
}