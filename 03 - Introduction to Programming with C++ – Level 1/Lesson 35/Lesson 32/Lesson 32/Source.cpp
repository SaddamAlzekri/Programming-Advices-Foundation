#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14159265358;

void PowerOfNumber(int Number1, int Number2)
{
	cout << pow(Number1,  Number2) << endl;
}

int main()
{
	float Number1, Number2;
	cout << "Please, enter the number1.\n";
	cin >> Number1;
	cout << "Please, enter the number2.\n";
	cin >> Number2;
	PowerOfNumber(Number1, Number2);
	_getch();
	return 0;
}