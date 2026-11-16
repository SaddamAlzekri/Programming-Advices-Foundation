#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;

float CircleArea(float L)
{
	float Result = ((pow(L, 2)) / (4 * PI));
	return Result;
}

int main()
{
	float L;
	cout << "Please, enter the r.\n";
	cin >> L;
	cout << CircleArea(L) << endl;
	_getch();
	return 0;
}