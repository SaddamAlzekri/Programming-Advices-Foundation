#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;
float CircleArea(float D)
{
	float Area = (PI * pow(D, 2)) / 4;
	return ceil(Area);

}
int main()
{
	float D;
	cout << "Enter the D value.\n";
	cin >> D;
	cout << CircleArea(D) << endl;
	_getch();
	return 0;
}