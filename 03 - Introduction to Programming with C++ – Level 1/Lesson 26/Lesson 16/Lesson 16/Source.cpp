#include<iostream>
#include<conio.h>
using namespace std;
float RectangleAria(float a, float d)
{
	float Area = a*sqrt(pow(d, 2) - pow(a, 2));
	return Area;
}
int main()
{
	float a, d;
	cout << "Enter the a and d.\n";
	cin >> a >> d;
	cout << RectangleAria(a,d) << endl;
	_getch();
	return 0;
}