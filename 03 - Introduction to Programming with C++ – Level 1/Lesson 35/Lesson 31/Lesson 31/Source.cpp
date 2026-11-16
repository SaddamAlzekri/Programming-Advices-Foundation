#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14159265358;

void PowerOfNumber(int Number)
{
	cout << pow(Number, 2) << endl << pow(Number, 3) << endl <<pow(Number, 4) << endl;
}

int main()
{
	float Number;
	cout << "Please, enter the number.\n";
	cin >> Number;
	PowerOfNumber(Number);
	_getch();
	return 0;
}