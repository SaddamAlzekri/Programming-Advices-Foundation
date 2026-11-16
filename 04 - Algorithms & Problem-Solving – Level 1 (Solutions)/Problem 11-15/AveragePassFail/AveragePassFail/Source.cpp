#include<iostream>
#include<conio.h>
using namespace std;
enum enPassFail
{
	Pass = 1,
	Fail = 2
};

void ReadNumber(int& Num1, int& Num2, int& Num3)
{
	cout << "Please enter the Number1.\n";
	cin >> Num1;
	cout << "Please enter the Number2.\n";
	cin >> Num2;
	cout << "Please enter the Number3.\n";
	cin >> Num3;
}

int SumOf3Numbers(int Num1, int Num2, int Num3)
{
	int Sum = Num1 + Num2 + Num3;
	return Sum;
}

float AverageOf3Numbers(int Num1, int Num2, int Num3)
{
	return (float)SumOf3Numbers(Num1, Num2, Num3) / 3;
}

enPassFail CheckPassFail(float Average)
{
	if (Average >= 50)
		return enPassFail::Pass;
	else
		return enPassFail::Fail;
}

void PrintAverage(float Average)
{
	if (CheckPassFail(Average) == enPassFail::Pass)
		cout << "You are Pass\n";
	else
		cout << "You are Fail\n";
}

int main()
{

	int Num1, Num2, Num3;
	ReadNumber(Num1, Num2, Num3);
	PrintAverage(AverageOf3Numbers(Num1, Num2, Num3));

	_getch();
	return 0;
}