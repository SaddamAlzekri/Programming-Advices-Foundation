#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
private:
	short _ID = 10;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Email;
	string _Phone;
public:


	clsPerson(short ID, string FirstName, string LastName, string FullName, string Email, string Phone)
	{
		_ID = ID;
		_FirstName = FirstName;
		_LastName = LastName;
		_FullName = FullName;
		_Email = Email;
		_Phone = Phone;
	}

	short ID()
	{
		return _ID;
	}

	void SetFirstName(string FirstName)
	{
		_FirstName = FirstName;
	}
	string FirstName()
	{
		return _FirstName;
	}

	void SetLastName(string LastName)
	{
		_LastName = LastName;
	}
	string LastName()
	{
		return _LastName;
	}

	void SetFullName(string FullName)
	{
		_FullName = FullName;
	}
	string FullName()
	{
		return _FullName;
	}

	void SetEmail(string Email)
	{
		_Email = Email;
	}
	string Email()
	{
		return _Email;
	}

	void SetPhone(string Phone)
	{
		_Phone = Phone;
	}
	string Phone()
	{
		return _Phone;
	}
};

class clsEmployee : public clsPerson
{
private:
	string _Title;
	string _Department;
	float _Salary;
public:
	clsEmployee(short ID, string FirstName, string LastName, string FullName, string Email, string Phone, string Title, string Department, float Salary)
		: clsPerson(ID, FirstName, LastName, FullName, Email, Phone)
	{
		_Title = Title;
		_Department = Department;
		_Salary = Salary;
	}

	void SetTitle(string Title)
	{
		_Title = Title;
	}
	string Title()
	{
		return _Title;
	}

	void SetDepartment(string Department)
	{
		_Department = Department;
	}
	string Department()
	{
		return _Department;
	}

	void SetSalary(float Salary)
	{
		_Salary = Salary;
	}
	float Salary()
	{
		return _Salary;
	}

	void Print()
	{
		cout << "Info\n";
		cout << "_________________________\n";
		cout << "ID         : " << ID() << endl;
		cout << "FirstName  : " << FirstName() << endl;
		cout << "LastName   : " << LastName ()<< endl;
		cout << "Email      : " << Email() << endl;
		cout << "Phone      : " << Phone() << endl;
		cout << "Title      : " << _Title << endl;
		cout << "Department : " << _Department << endl;
		cout << "Salary     : " << _Salary << endl;
		cout << "_________________________\n";
	}
};

int main()
{

	clsEmployee Persin1(10, "Sadam", "Al-zekri", "Saddam Al-zekri", "Saddam@gmail.com", "712126932", "Web Developer", "frontEnd", 5000);

	Persin1.Print();


	_getch();
	return 0;
}