#include<iostream>
#include<conio.h>
using namespace std;
void PowNumber(int Number)
{
	cout << "Number^2 : " << pow(Number, 2) << endl;
	cout << "Number^3 : " << pow(Number, 3) << endl;
	cout << "Number^4 : " << pow(Number, 4) << endl;
}
int main()
{
	int Number;
	cout << "Enter the one number.\n";
	cin >> Number;
	PowNumber(Number);
	_getch();
	return 0;
}