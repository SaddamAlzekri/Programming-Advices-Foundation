#include<iostream>
#include<conio.h>
using namespace std;

float CalculateFunction(float Num1, float Num2, char OPeration)
{
	if (OPeration == '+')
	{
		return (Num1 + Num2);
	}
	else if (OPeration == '-')
	{
		return (Num1 - Num2);
	}
	else if (OPeration == '*')
	{
		return (Num1 * Num2);
	}
	else if (OPeration == '/')
	{
		return (Num1 / Num2);
	}
}
int main()
{
	float Num1, Num2;
	char OPerator;
	cout << "Please, enter the num1.\n";
	cin >> Num1;
	cout << "Please, enter the num2.\n";
	cin >> Num2;
	cout << "Please, enter the Operator.\n";
	cin >> OPerator;
	cout << "***********************\n";
	cout << CalculateFunction(Num1, Num2, OPerator) << endl;
	_getch();
	return 0;
}