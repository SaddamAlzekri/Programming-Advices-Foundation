#include<iostream>
#include<conio.h>
using namespace std;

void ReadNumber(float& a, float& b)
{
	cout << "Please enter the number a\n";
	cin >> a;
	cout << "Please enter the number b\n";
	cin >> b;
}

float CircleAreaByInsoscelesTraingle(float a, float b)
{
	const float PI = 3.141592653589793238;
	float Area;
	Area = PI * (pow(b, 2) / 4) * ((2 * a - b) / (2 * a + b));
	return Area;
}

void PrintResult(float Area)
{
	cout << "The circle area by traingle " << Area << endl;
}

int main()
{
	float a, b;
	ReadNumber(a, b);
	PrintResult(CircleAreaByInsoscelesTraingle(a, b));
	_getch();
	return 0;
}