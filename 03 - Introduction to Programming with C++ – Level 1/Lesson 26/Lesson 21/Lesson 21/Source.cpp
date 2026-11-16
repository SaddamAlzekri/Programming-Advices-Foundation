#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;
float CircleArea(float L)
{
	float Area = (pow(L,2)) / (4 * PI);
	return floor(Area);
}
int main()
{
	float L;
	cout << "Enter the l value.\n";
	cin >> L;
	cout << CircleArea(L) << endl;
	_getch();
	return 0;
}