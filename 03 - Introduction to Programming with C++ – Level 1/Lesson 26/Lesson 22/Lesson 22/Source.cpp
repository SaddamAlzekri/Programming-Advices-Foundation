#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;

float CircleArae(float a, float b)
{
	float Area = (PI * pow(b,2)/ 4) * ((2 * a - b) / (2 * a + b));
	return floor(Area);
}
int main()
{
	float a, b;
	cout << "Enter the a,b value.\n";
	cin >> a >> b;
	cout<<CircleArae(a, b) << endl;
	_getch();
	return 0;
}