#include<iostream>
#include<conio.h>
using namespace std;
void ReadNumbers(int& Num1, int& Num2, int& Num3)
{
	cout << "Please enter the Number1\n";
	cin >> Num1;
	cout << "Please enter the Number2\n";
	cin >> Num2;
	cout << "Please enter the Number3\n";
	cin >> Num3;
}

int SumOf3Numbers(int Num1, int Num2, int Num3)
{
	int Sum = Num1 + Num2 + Num3;
	return Sum;
}

int AverageNumbers(int Num1, int Num2, int Num3)
{
	return (float)SumOf3Numbers(Num1, Num2, Num3) / 3;
}

void PrintTotal(int Total)
{
	cout << "The Sum is " << Total << endl;
}

int main()
{
	int Num1, Num2, Num3;
	ReadNumbers(Num1, Num2, Num3);
	PrintTotal(AverageNumbers(Num1, Num2, Num3));
	_getch();
	return 0;
}