#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;
float circleArea(float r)
{
	float Area = PI *pow(r, 2);
	return ceil(Area);
}

int main()
{
	float r;
	cout << "Enter the r value.\n";
	cin >> r;
	cout << circleArea(r) << endl;

	_getch();
	return 0;
}