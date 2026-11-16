#include<iostream>
#include<conio.h>
using namespace std;

void ReadNumbers(int& Num1, int& Num2, int& Num3)
{
	cout << "Please enter the number1\n";
	cin >> Num1;
	cout << "Please enter the number2\n";
	cin >> Num2;
	cout << "Please enter the number3\n";
	cin >> Num3;
}

int SwapNumbers(int Num1, int Num2, int Num3)
{
	if (Num1 > Num2 )
	if (Num1 > Num3)
		return Num1;
	else
		return Num3;
	else
	if (Num2 > Num3)
		return Num2;
	else
		return Num3;
}

void PrintNumbers(int Swap)
{
	cout << "The Max Number " << Swap << endl;
}

int main()
{
	int Num1, Num2, Num3;
	ReadNumbers(Num1, Num2, Num3);
	PrintNumbers(SwapNumbers(Num1, Num2, Num3));

	_getch();
	return 0;
}