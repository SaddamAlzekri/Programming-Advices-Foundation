#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
public:
	string _FullName;

	class clsAddress
	{
	public:
		string _AddressLine1;
		string _AddressLine2;
		string _City;
		string _Country;
		
		clsAddress(string AddressLine1, string AddressLine2, string City, string County)
		{
			_AddressLine1 = AddressLine1;
			_AddressLine2 = AddressLine2;
			_City = City;
			_Country = County;
		}

		void setAddressLine1(string AddressLine1)
		{
			_AddressLine1 = AddressLine1;
		}
		string AddressLine1()
		{
			return _AddressLine1;
		}

		void setAddressLine2(string AddressLine2)
		{
			_AddressLine2 = AddressLine2;
		}
		string AddressLine2()
		{
			return _AddressLine2;
		}

		void setCity(string City)
		{
			_City = City;
		}
		string City()
		{
			return _City;
		}

		void setCountry(string Country)
		{
			_Country = Country;
		}
		string Country()
		{
			return _Country;
		}

		void PrintAddress()
		{
			cout << "Print Address\n";
			cout << _AddressLine1 << endl;
			cout << _AddressLine2 << endl;
			cout << _City << endl;
			cout << _Country << endl;
		}
	};

	void setFullName(string FullName)
	{
		_FullName = FullName;
	}
	string FullName()
	{
		return _FullName;
	}

	clsAddress Address = clsAddress("", "", "", "");

	clsPerson(string FullName, string AddressLine1, string AddressLine2, string City, string Country)
	{
		_FullName = FullName;

		Address = clsAddress(AddressLine1, AddressLine2, City, Country);
	}

};

int main()
{
	clsPerson Person1("Saddam Al-zekri", "Building 10", "Company Street", "Mareb", "YEMEN");

	Person1.Address.PrintAddress();

	_getch();
	return 0;
}