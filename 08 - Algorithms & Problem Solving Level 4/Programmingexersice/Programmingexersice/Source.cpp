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

	void SendEmail(string Message, string Body)
	{
		cout << "the following message sent successfully to email: " << _Email << endl;
		cout << "Subject: " << Message << endl;
		cout << "the following message sent successfully to Phone: " << _Phone << endl;
		cout << "body: " << Body << endl;
	}

	void SendSms(string Message)
	{
		cout << "the following message sent successfully to Phone: " << _Phone << endl;
		cout << Message << endl;
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

	void SetTile(string Tile)
	{
		_Title = Tile;
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
		return _Title;
	}

	void SetSalary(float Salary)
	{
		_Salary = Salary;
	}
	float Salary()
	{
		return _Salary;
	}

};

class clsDevelpoer : public clsEmployee
{
private:
	string _MainProgrammingLanguages;
public:
	clsDevelpoer(short ID, string FirstName, string LastName, string FullName, string Email, string Phone, string Title, string Department, float Salary, string MainProgrammingLanguages)
		: clsEmployee(ID, FirstName, LastName, FullName, Email, Phone, Title, Department, Salary)
	{
		_MainProgrammingLanguages = MainProgrammingLanguages;
	}

	void SetMainProgrammingLanguages(string MainProgrammingLanguages)
	{
		_MainProgrammingLanguages = MainProgrammingLanguages;
	}
	string MainProgrammingLanguages()
	{
		return _MainProgrammingLanguages;
	}
	void Print()
	{
		cout << "Info\n";
		cout << "______________________________________\n";
		cout << "ID         : " << ID() << endl;
		cout << "FirstName  : " << FirstName() << endl;
		cout << "LastName   : " << LastName() << endl;
		cout << "FullName   : " << FullName() << endl;
		cout << "Title      : " << Title() << endl;
		cout << "Email      : " << Email() << endl;
		cout << "Phone      : " << Phone() << endl;
		cout << "Salary     : " << Salary() << endl;
		cout << "Department : " << Department() << endl;
		cout << "MainProgrammingLanguages : " << MainProgrammingLanguages() << endl;
		cout << "______________________________________\n";
	}

};

int main()
{

	clsDevelpoer Employee(20, "Saleh", "Al-zekri", "Saleh Alzekri", "Ali@gmail.com", "7822939319", "Desktop", "Desiner", 110000, "C++");

	Employee.Print();
	cout << "\n\n";
	Employee.SendEmail("Hi", "How are you?");
	cout << "\n\n";

	Employee.SendSms("How are you?");
	_getch();
	return 0;
}