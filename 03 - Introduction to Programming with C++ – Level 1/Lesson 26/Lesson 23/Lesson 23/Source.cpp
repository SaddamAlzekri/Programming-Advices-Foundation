#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;

float CircleArae(float a, float b, float c)
{
	float P = (a + b + c) / 2;
	float Area = (a * b * c) / (4 * sqrt(P*(P - a) * (P - b)*(P - c)));
	float Area2 = PI * pow(Area, 2);
	return round(Area2);
}
int main()
{
	float a, b, c;
	cout << "Enter the a,b, c value.\n";
	cin >> a >> b >> c;
	cout << CircleArae(a, b, c) << endl;
	_getch();
	return 0;
}