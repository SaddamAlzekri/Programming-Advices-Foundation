#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
int Myage = 25;
string MyStatus = "Male";

void Variables()
{
	int Myage = 20;
	string MyStatus = "Female";
	cout << Myage << "\t\t" << MyStatus << "\t------->>Local Variable" << endl;
}

int main()
{
	cout << ::Myage << "\t\t" << ::MyStatus << "\t------->>Global Variable" << endl;
	Variables();
	::Myage = 30;
	::MyStatus = "I donot know";
	cout << ::Myage << "\t\t" << ::MyStatus << "\t------->>Global Variable" << endl;

	_getch();
	return 0;
}