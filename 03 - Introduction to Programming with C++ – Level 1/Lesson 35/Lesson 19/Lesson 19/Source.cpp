#include<iostream>
#include<conio.h>
using namespace std;
const float IP = 3.14;

float CircleArea(float D)
{
	float Result = (IP * pow(D, 2))/4;
	return Result;
}

int main()
{
	float D;
	cout << "Please, enter the r.\n";
	cin >> D;
	cout << CircleArea(D) << endl;
	_getch();
	return 0;
}