#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int Number = 0;
	string Result = "";

	cout << "Enter the Number: ";
	cin >> Number;
	//Using Short Hand If
	Result = (Number == 0) ? "Zero" : (Number >= 0) ? "Positive" : "Negetive";

	cout << Result << endl;
	_getch();
	return 0;
}