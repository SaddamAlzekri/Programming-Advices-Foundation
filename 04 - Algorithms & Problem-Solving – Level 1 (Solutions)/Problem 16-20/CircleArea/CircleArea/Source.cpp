#include<iostream>
#include<math.h>
#include<conio.h>
using namespace std;

float ReadNumbers(float& r)
{
	cout << "Please enter the Radious r\n";
	cin >> r;
	return r;
}

float CalculateCircleArea(float r)
{
	const float PI = 3.141592653589793238;
	float Result;
	Result = pow(r, 2) * PI;
	return Result;
}

void PrintResult(float Result)
{
	cout << "The rectangle area is " << Result << endl;
}

int main()
{
	float r;
	ReadNumbers(r);
	PrintResult(CalculateCircleArea(r));

	_getch();
	return 0;
}