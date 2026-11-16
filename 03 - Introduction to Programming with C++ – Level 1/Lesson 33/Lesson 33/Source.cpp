#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
void ProblemWithGetline()
{
	int PhoneNumber;
	string FullName;
	string Country;

	cout << "Please,Enter the your phone number.\n";
	cin >> PhoneNumber;

	cout << "Please,Enter the your full name.\n";
	cin.ignore(1, '\n');
	getline(cin, FullName);

	cout << "Please,Enter the your country.\n";
	cin >> Country;

	cout << "\n\n**************************\n";
	cout << PhoneNumber << endl << FullName << endl << Country;
	cout << "\n**************************\n";

}
int main()
{
	ProblemWithGetline();

	_getch();
	return 0;
}