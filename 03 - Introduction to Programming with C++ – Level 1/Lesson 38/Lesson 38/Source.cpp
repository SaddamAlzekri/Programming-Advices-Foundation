#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
struct CardInfo
{
	string FirstName;
	string LastName;
	int Age;
	int PhoneNumber;
};

void ReadCardInfo(CardInfo &MyInfo)
{
	cout << "Please, enter the first name.\n";
	cin >> MyInfo.FirstName;
	cout << "Please, enter the last name.\n";
	cin >> MyInfo.LastName;
	cout << "Please, enter the age.\n";
	cin >> MyInfo.Age;
	cout << "Please, enter the phone number.\n";
	cin >> MyInfo.PhoneNumber;
}

void PrintCardInfo(CardInfo &MyInfo)
{
	cout << "\n\n***************************************\n";
	cout << "First Name : " << MyInfo.FirstName << endl;
	cout << "Last Name : " << MyInfo.LastName << endl;
	cout << "Age : " << MyInfo.Age << endl;
	cout << "Phone Number : " << MyInfo.PhoneNumber << endl;
	cout << "***************************************\n";

}



int main()
{
	CardInfo Person1Info;
	ReadCardInfo(Person1Info);
	PrintCardInfo(Person1Info);
	_getch();
	return 0;
}