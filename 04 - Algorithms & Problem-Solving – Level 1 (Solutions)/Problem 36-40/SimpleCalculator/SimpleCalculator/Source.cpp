#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

enum enOperationType
{
	Add = '+',
	Subtract = '-',
	Multiply = '*',
	Divide = '/'
};

float ReadNumber(string Message)
{
	int Num;
	cout << Message << endl;
	cin >> Num;
	return Num;
}

enOperationType ReadOptype()
{
	char Op = '+';
	cout << "Please enter (+, *, /, -)\n";
	cin >> Op;
	return (enOperationType)Op;
}

float Calculate(int Num1, int Num2, enOperationType OpType)
{
	switch (OpType)
	{
	case enOperationType::Add:
		return Num1 + Num2;
		break;
	case enOperationType::Subtract:
		return Num1 - Num2;
		break;
	case enOperationType::Multiply:
		return Num1 * Num2;
		break;
	case enOperationType::Divide:
		return Num1 / Num2;
		break;
	default:
		return Num1 + Num2;
		break;
	}
}

int main()
{
	float Num1 = ReadNumber("Please enter the Number '1'");
	float Num2 = ReadNumber("Please enter the Number '2'");

	enOperationType OP = ReadOptype();

	cout << "Result = " << Calculate(Num1, Num2, OP) << endl;

	_getch();
	return 0;
}