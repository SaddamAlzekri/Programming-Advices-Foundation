#include<iostream>
#include<conio.h>
using namespace std;

void ReadNumber(int& Num1, int& Num2)
{
	cout << "Please enter the number1\n";
	cin >> Num1;
	cout << "Please enter the number2\n";
	cin >> Num2;
}

void SwapNumber(int& Num1, int& Num2)
{
	int Temp;

	Temp = Num1;
	Num1 = Num2;
	Num2 = Temp;
}

void PrintSwapNumber(int Num1, int Num2)
{
	cout << "Num1 = " << Num1 << endl;
	cout << "Num2 = " << Num2 << endl;
}

int main()
{

	int Num1, Num2;
	ReadNumber(Num1, Num2);
	cout << "\n\n";
	PrintSwapNumber(Num1, Num2);
	cout << "\n\n";
	SwapNumber(Num1, Num2);
	PrintSwapNumber(Num1, Num2);

	_getch();
	return 0;
}

