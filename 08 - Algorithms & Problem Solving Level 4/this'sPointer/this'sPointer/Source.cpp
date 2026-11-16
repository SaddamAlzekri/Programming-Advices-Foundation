#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsEmplyee
{
public:
	int ID;
	string Name;
	float Salary;

	clsEmplyee(int ID, string Name, float Salary)
	{
		this->ID = ID;
		this->Name = Name;
		this->Salary = Salary;
	}
	static void Fun1(clsEmplyee Emplyee)
	{
		Emplyee.Print();
	}

	void Fun2()
	{
		Fun1(*this);
	}

	void Print()
	{
		//cout << ID << "\t" << Name << "\t" << Salary << endl;
		cout << this->ID << "\t" << this->Name << "\t" << this->Salary << endl;
	}
};

int main()
{
	clsEmplyee Employee(101, "Saleh", 5000);
	Employee.Print();
	Employee.Fun2();
	_getch();
	return 0;
}