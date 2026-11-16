#include<iostream>
#include<conio.h>
using namespace std;
void ReadNumber(float& D)
{
	cout << "Please enter the Circle Diameter\n";
	cin >> D;
}

float CalculateCircleByDiameter(int D)
{
	const float PI = 3.141592653589793238;
	float Area;
	Area = (PI * pow(D, 2) / 4);
	return Area;
}

void PrintResult(float Area)
{
	cout << "The Area is " << Area << endl;
}
int main()
{
	float D;
	ReadNumber(D);
	PrintResult(CalculateCircleByDiameter(D));
	_getch();
	return 0;
}