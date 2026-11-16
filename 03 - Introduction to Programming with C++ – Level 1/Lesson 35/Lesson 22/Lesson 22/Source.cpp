#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;

float CircleArea(float a, float b)
{
	float Result = (PI * (pow(b, 2) / 4) * ((2 * a - b) / (2 * a + b)));
	return Result;
}

int main()
{
	float a, b;
	cout << "Please, enter the a.\n";
	cin >> a;
	cout << "Please, enter the b.\n";
	cin >> b;
	cout << CircleArea(a, b) << endl;
	_getch();
	return 0;
}