#pragma once
#include<iostream>
#include<string>
using namespace std;

class clsPerson
{
private:
	string _FirstName;
	string _LastName;
	string _Phone;
	string _Email;

public:
	clsPerson(string FirstName, string LastName, string Phone, string Email)
	{
		_FirstName = FirstName;
		_LastName = LastName;
		_Phone = Phone;
		_Email = Email;
	}

	void SetFirstName(int FirstName)
	{
		_FirstName = FirstName;
	}

	string GetFirstName()
	{
		return _FirstName;
	}
	_declspec(property(get = GetFirstName, put = SetFirstName)) string FirstName;

	void SetLastName(int LastName)
	{
		_LastName = LastName;
	}

	string GetLastName()
	{
		return _LastName;
	}
	_declspec(property(get = GetLastName, put = SetLastName)) string LastName;

	void SetPhone(int Phone)
	{
		_Phone = Phone;
	}


	void SetEmail(int Email)
	{
		_Email = Email;
	}

	string GetEmail()
	{
		return _Email;
	}
	_declspec(property(get = GetEmail, put = SetEmail)) string Email;


	string GetPhone()
	{
		return _Phone;
	}
	_declspec(property(get = GetPhone, put = SetPhone)) string Phone;

	string FullName()
	{
		return _FirstName + " " + _LastName;
	}

	void print()
	{
		cout << "Info...\n";
		cout << "_____________________________\n";
		cout << "FirstName : " << _FirstName << endl;

		cout << "LastNAme : " << _LastName << endl;

		cout << "FullName : " << FullName() << endl;

		cout << "Phone : " << _Phone << endl;

		cout << "Email : " << _Email << endl;
		cout << "_____________________________\n";
	}
};