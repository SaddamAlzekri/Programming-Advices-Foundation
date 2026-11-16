#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
	class clsAddress
	{
	public:
		string AddressLine1;
		string AddressLine2;
		string City;
		string Country;

		void PrintAddress()
		{
			cout << "Print Address\n";
			cout << AddressLine1 << endl;
			cout << AddressLine2 << endl;
			cout << City << endl;
			cout <<Country << endl;
		}
	};

public:
	string FullName;
	clsAddress Address;

	clsPerson()
	{
		FullName = "Saddam Al-zekri";
		Address.AddressLine1 = "Building 10";
		Address.AddressLine2 = "Company Street";
		Address.City = "Mareb";
		Address.Country = "YEMEN";
	}
};

int main()
{
	clsPerson Person1;

	Person1.Address.PrintAddress();
	_getch();
	return 0;
}