#include<iostream>
#include<conio.h>
using namespace std;

void ReadNumbers(float& a, float& b, float& c)
{
	cout << "Please enter the number 'a'\n";
	cin >> a;
	cout << "Please enter the number 'b'\n";
	cin >> b;
	cout << "Please enter the number 'c'\n";
	cin >> c;
}

float CalculateCircleAreaAroundAnArbitraryTraingle(float a, float b, float c)
{
	const float PI = 3.141592653589793238;
	float P = (a + b + c) / 2, T, Area;

	T = (a * b * c) / (4 * sqrt(P * (P - a) * (P - b) * (P - c)));
	Area = PI * pow(T, 2);
	return Area;
}

void PrintResult(float Area)
{
	cout << "The circle area is " << Area << endl;
}

int main()
{

	float a, b, c;
	ReadNumbers(a, b, c);
	PrintResult(CalculateCircleAreaAroundAnArbitraryTraingle(a, b, c));

	_getch();
	return 0;
}
