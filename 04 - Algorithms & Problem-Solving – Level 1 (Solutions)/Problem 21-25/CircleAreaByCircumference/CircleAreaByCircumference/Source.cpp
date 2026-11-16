#include<iostream>
#include<conio.h>
using namespace std;

float ReadNumber()
{
	float L;
	cout << "Please enter the number\n";
	cin >> L;
	return L;
}

float CircleAreaByCircumference(float L)
{
	const float PI = 3.141592653589793238;
	float Area;
	Area = pow(L, 2) / (4 * PI);
	return Area;
}

void PrintResult(float Area)
{
	cout << "The circle area by circumference\n" << Area << endl;
}

int main()
{
	PrintResult(CircleAreaByCircumference(ReadNumber()));
	_getch();
	return 0;
}