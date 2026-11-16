#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadName()
{
	string Name;
	cout << "Please, enter your name.\n";
	getline(cin, Name);
	return Name;
}

void PrintName(string Name)
{
	cout << "\nThe Name is " << Name << endl;
}

int main()
{
	PrintName(ReadName());
	_getch();
	return 0;
}