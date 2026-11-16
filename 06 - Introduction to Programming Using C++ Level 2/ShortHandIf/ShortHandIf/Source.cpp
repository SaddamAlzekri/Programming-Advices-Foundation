#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int Mark = 0;
	string Result = "";

	cout << "Enter the Mark: ";
	cin >> Mark;
	//Using Short Hand If
	Result = (Mark >= 50) ? "PASS" : "FAIL";

	cout << Result << endl;
	_getch();
	return 0;
}