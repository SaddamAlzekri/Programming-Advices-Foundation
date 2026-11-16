#include<iostream>
//#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
private:
	short _ID;
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

	void Print()
	{
		cout << "Info\n";
		cout << "_________________________\n";
		cout << "ID        : " << _ID << endl;
		cout << "FirstName : " << _FirstName << endl;
		cout << "LastName : " << _LastName << endl;
		cout << "Email : " << _Email << endl;
		cout << "Phone : " << _Phone << endl;
		cout << "_________________________\n";
	}
};

int main()
{
	clsPerson Person1(10, "Saddam", "Al-zekri", "Saddam Al-zekri", "SaddamAlzekri@gmail", "712126932");

	Person1.Print();

	return 0;
	//_getch();
	system("pause");
}