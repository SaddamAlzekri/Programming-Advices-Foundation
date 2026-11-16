#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
struct StrInfo
{
	string FirstName;
	string LastName;
	string Age;
	string Phone;
};

void ReadInfo(StrInfo& Info)
{
	cout << "Please, enter your first name.\n";
	cin >> Info.FirstName;
	cout << "Please, enter your last name.\n";
	cin >> Info.LastName;
	cout << "Please, enter your Age.\n";
	cin >> Info.Age;
	cout << "Please, enter your phone.\n";
	cin >> Info.Phone;
}

void PrintInfo(StrInfo Info)
{

	cout << "My fist name is " << Info.FirstName << endl;
	cout << "My last name is " << Info.LastName << endl;
	cout << "My Age is " << Info.Age << endl;
	cout << "My phone number is " << Info.Phone << endl;

}

void ReadAllPersons(StrInfo Info[100], short &Length)
{
	cout << "How many persons that enter?\n";
	cin >> Length;
	for (int i = 0; i <= Length-1; i++)
	{
		ReadInfo(Info[i]);
	}
}

void PrintAllPersons(StrInfo Info[100], short Length)
{
	for (int i = 0; i <= Length - 1; i++)
	{
		cout << "      Person " << i + 1 << endl;
		cout << "********************\n";
		PrintInfo(Info[i]);
		cout << "********************\n\n";

	}
}
int main()
{

	short Length;
	StrInfo PersonInfo[100];
	ReadAllPersons(PersonInfo, Length);
	PrintAllPersons(PersonInfo, Length);

	_getch();
	return 0;
}