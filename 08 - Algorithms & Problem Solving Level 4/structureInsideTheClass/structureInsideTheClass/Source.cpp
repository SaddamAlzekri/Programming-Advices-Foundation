#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
	struct stAddress
	{
		string AddressLine1;
		string AddressLine2;
		string City;
		string Country;
	};
public:
	string FullName;
	stAddress Address;

	clsPerson()
	{
		FullName = "Saddam Al-zekri";
		Address.AddressLine1 = "Building 10";
		Address.AddressLine2 = "Company Street";
		Address.City = "Mareb";
		Address.Country = "YEMEN";
	}

	void PrintAddress()
	{
		cout << "Print Address\n";
		cout << Address.AddressLine1 << endl;
		cout << Address.AddressLine2 << endl;
		cout << Address.City << endl;
		cout << Address.Country << endl;
	}
};

int main()
{
	clsPerson Person1;

	Person1.PrintAddress();
	_getch();
	return 0;
}