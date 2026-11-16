#include<iostream>
#include<conio.h>
using namespace std;
const float IP = 3.14;

float RectangleArea(float r)
{
	float Result = IP * (pow(r, 2));
	return Result;
}

int main()
{
	float r;
	cout << "Please, enter the r.\n";
	cin >> r;
	cout << RectangleArea(r) << endl;
	_getch();
	return 0;
}