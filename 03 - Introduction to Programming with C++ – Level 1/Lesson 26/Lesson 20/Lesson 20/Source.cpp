#include<iostream>
#include<conio.h>
using namespace std;
const float PI = 3.14;
float CircleAreaInSquar(float A)
{
	float Area = (PI * pow(A, 2)) / 4;
	return ceil(Area);
}
int main()
{
	float A;
	cout << "Enter the A value.\n";
	cin >> A;
	cout << CircleAreaInSquar(A) << endl;
	_getch();
	return 0;
}