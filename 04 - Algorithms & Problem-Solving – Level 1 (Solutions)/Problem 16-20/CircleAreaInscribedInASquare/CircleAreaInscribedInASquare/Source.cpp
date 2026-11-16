#include<iostream>
#include<conio.h>
using namespace std;
void ReadNumber(float& a)
{
	cout << "Please enter the Circle Diameter\n";
	cin >> a;
}

float CalculateCircleAreaInscribedInASquare(int a)
{
	const float PI = 3.141592653589793238;
	float Area;
	Area = (PI * pow(a, 2)) / 4;
	return Area;
}

void PrintResult(float Area)
{
	cout << "The Area is " << Area << endl;
}
int main()
{
	float a;
	ReadNumber(a);
	PrintResult(CalculateCircleAreaInscribedInASquare(a));
	_getch();
	return 0;
}