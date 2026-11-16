#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int Mark = 0;
	string Result = "";

	cout << "Enter the Number: ";
	cin >> Mark;
	//Using Short Hand If
	Result = (Mark >= 0) ? "Positive" : "Negetive";

	cout << Result << endl;
	_getch();
	return 0;
}