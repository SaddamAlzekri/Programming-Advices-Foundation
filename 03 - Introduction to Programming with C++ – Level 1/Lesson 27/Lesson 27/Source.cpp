#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
struct MyAddress
{
	string Address;
	int CallPhone;
	int WhatsAppPhone;

};
struct Myinfo
{
	string Name;
	int Age;
	string City;
	string Country;
	int MonthlySalary;
	int YearlySalary;
	char Gender;
	bool Married;
	MyAddress MyAddress;
};
int main()
{

	Myinfo info1;
	info1.Name = "Saddam Al-zekri";
	info1.Age = 25;
	info1.City = "Taiz";
	info1.Country = "YEMEN";
	info1.MonthlySalary = 5000;
	info1.YearlySalary = info1.MonthlySalary * 12;
	info1.Gender = 'M';
	info1.Married = 1;
	info1.MyAddress.Address = "Al-zakia";
	info1.MyAddress.CallPhone = 712126932;
	info1.MyAddress.WhatsAppPhone = 712126932;

	//#############################################

	cout <<"Name : "<<info1.Name << endl;
	cout <<"Age : "<<info1.Age << endl;
	cout <<"City : "<<info1.City << endl;
	cout <<"Country : "<<info1.Country << endl;
	cout <<"Monthly Salary : "<<info1.MonthlySalary << endl;
	cout <<"Yearly Salary : "<<info1.YearlySalary<< endl;
	cout <<"Gender : "<<info1.Gender << endl;
	cout <<"Married : "<<info1.Married << endl;
	cout <<"Addrress"<<info1.MyAddress.Address << endl;
	cout <<"Call phone : "<<info1.MyAddress.CallPhone << endl;
	cout <<"WhatsApp phone : "<<info1.MyAddress.WhatsAppPhone << endl;
	
	_getch();
	return 0;
}