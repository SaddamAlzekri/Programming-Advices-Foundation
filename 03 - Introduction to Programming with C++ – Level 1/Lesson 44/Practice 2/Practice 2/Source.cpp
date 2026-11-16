#include<iostream>
#include<conio.h>
using namespace std;
enum enCountry {YEMEN = 1, Oman = 2, Iran = 3, Iraq = 4, Eygpt = 5};
void CountryFunction(enCountry country)
{
	if (country == enCountry::YEMEN)
	{
		cout << "The country is YEMEN.\n";
	}
	else if (country == enCountry::Oman)
	{
		cout << "The country is Oman.\n";
	}
	else if (country == enCountry::Iran)
	{
		cout << "The country is Iran.\n";
	}
	else if (country == enCountry::Iraq)
	{
		cout << "The country is Iraq.\n";
	}
	else if (country == enCountry::Eygpt)
	{
		cout << "The country is Eygpt.\n";
	}
}
int main()
{
	int CountryNum;
	cout << "*********************\n";
	cout << "(1) YEMEN\n";
	cout << "(2) Oman\n";
	cout << "(3) Iran\n";
	cout << "(4) Iraq\n";
	cout << "(5) Eygpt\n";
	cout << "*********************\n";
	enCountry Country;
	cout << "Choice the Country\n";
	cin >> CountryNum;
	Country = (enCountry)CountryNum;
	CountryFunction(Country);



	_getch();
	return 0;
}