#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadNumber(string Message)
{
	float Num = 0;
	cout << Message << endl;
	cin >> Num;
	return Num;
}

float FractionNumber(float Number)
{
	return Number - int(Number);
}

float MyRound(float Number)
{
	int IntNum = int(Number);
	float Fraction = FractionNumber(Number);
	if (abs(Fraction) >= 0.5)
	{
		if (IntNum > 0)
			return ++IntNum;
		else
			return --IntNum;
	}else 
		return IntNum;
}

int main()
{
	float Number = ReadNumber("Please enter float Number.");
	cout << "C++ Round Result : " << MyRound(Number) << endl;
	cout << "My Round Result : " << round(Number) << endl;
	_getch();
	return 0;
}