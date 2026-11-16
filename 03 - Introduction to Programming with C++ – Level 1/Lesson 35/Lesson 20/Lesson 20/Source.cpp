#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;

float CircleArea(float A)
{
	float Result = (PI * pow(A, 2))/4;
	return Result;
}

int main()
{
	float A;
	cout << "Please, enter the r.\n";
	cin >> A;
	cout << CircleArea(A) << endl;
	_getch();
	return 0;
}