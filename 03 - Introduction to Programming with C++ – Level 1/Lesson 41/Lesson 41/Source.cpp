#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

struct MyInfo
{
	string FirstName;
	string LastName;
	int Age;
	int Phone;
};

void Read1PersonInfo(MyInfo &Info)
{
	cout << "Please, enter the first name.\n";
	cin >> Info.FirstName;
	cout << "Please, enter the last name.\n";
	cin >> Info.LastName;
	cout << "Please, enter the age.\n";
	cin >> Info.Age;
	cout << "Please, enter the phone.\n";
	cin >> Info.Phone;
}

void Print1PersonInfo(MyInfo Info)
{
	cout << "*********************************\n";
	cout << "First Name : " << Info.FirstName << endl;
	cout << "Last Name : " << Info.LastName << endl;
	cout << "Age : " << Info.Age << endl;
	cout << "Phone : " << Info.Phone << endl;
	cout << "*********************************\n";
}

void ReadAllPersons(MyInfo Info[2])
{
	Read1PersonInfo(Info[0]);
	Read1PersonInfo(Info[1]);
}

void PrintAllPersons(MyInfo Info[2])
{
	Print1PersonInfo(Info[0]);
	Print1PersonInfo(Info[1]);
}
int main()
{
	MyInfo Info[2];
	ReadAllPersons(Info);
	PrintAllPersons(Info);
	

	_getch();
	return 0;
}