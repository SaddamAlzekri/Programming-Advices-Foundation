#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14159265358;
float CircleArea(float a, float b, float c)
{
	float p = ((a + b + c) / 2);
	float Result = (PI * pow((a*b*c) / (4 * sqrt(p*(p - a)*(p - b)*(p - c))), 2));
	return Result;
}
int main()
{
	float a, b, c;
	cout << "Please, enter the a value.\n";
	cin >> a;
	cout << "Please, enter the b value.\n";
	cin >> b;
	cout << "Please, enter the c value.\n";
	cin >> c;
	cout << CircleArea(a, b, c) << endl;
	_getch();
	return 0;
}