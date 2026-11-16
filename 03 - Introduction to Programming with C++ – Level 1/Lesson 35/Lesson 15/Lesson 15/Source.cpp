#include<iostream>
#include<conio.h>
using namespace std;
float RectangleArea(float a, float b)
{
	float Result = a * b;
	return Result;
}
int main()
{
	float a, b;
	cout << "Please, enter the a.\n";
	cin >> a;
	cout << "Please, enter the b.\n";
	cin >> b;
	cout << RectangleArea(a, b) << endl;
	_getch();
	return 0;
}