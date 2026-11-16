#include<iostream>
#include<string>
#include<conio.h>
using namespace std;
void Calculate(float Num1, float Num2, char Operation)
{
	string DefaultMessage = "Wrong Operation";
	switch (Operation)
	{
	case '+':
		cout << Num1 + Num2;
		break;
	case '-':
		cout << Num1 - Num2;
		break;
	case '*':
		cout << Num1 * Num2;
		break;
	case '/':
		cout << Num1 / Num2;
		break;
	default:
		cout << DefaultMessage;
		break;
	}
}
int main()
{
	float Num1, Num2;
	char OPeration;
	cout << "Please, enter the Num1.\n";
	cin >> Num1;
	cout << "Please, enter the Num2.\n";
	cin >> Num2;
	cout << "Please, enter the OPERATION.\n";
	cin >> OPeration;
	Calculate(Num1, Num2, OPeration);
	_getch();
	return 0;
}