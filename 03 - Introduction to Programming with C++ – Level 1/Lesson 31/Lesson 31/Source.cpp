#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

int main()
{
	string FullName, Num1, Num2;
	cout << "Please enter String1?\n";
	getline(cin, FullName);
	cout << "Please enter String2?\n";
	cin >> Num1;
	cout << "Please enter String3?\n";
	cin >> Num2;
	cout << "*******************************\n";
	cout << "The length of dtring1 is " << FullName.length()<<endl;
	cout << "Character at 0,2,4,7 are: " << FullName[0] << FullName[2] << FullName[4] << FullName[7] << endl;
	cout << "The concatenation string2 and string3 : " << Num1 + Num2 << endl;
	int Result = stoi(Num1) * stoi(Num2);
	cout << Num1 << " * " << Num2 << " = " << Result << endl;

	
	_getch();
	return 0;
}