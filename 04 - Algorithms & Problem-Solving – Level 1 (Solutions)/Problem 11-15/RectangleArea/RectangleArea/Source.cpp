#include<iostream>
#include<conio.h>
using namespace std;

void ReadRectangleArea(float& High, float& Width)
{
	cout << "Please enter the high\n";
	cin >> High;
	cout << "Please enter the Width\n";
	cin >> Width;
}

float CalculateRectangleArea(float High, float Width)
{
	return High*Width;
}

void PrintRectangleArea(float Area)
{
	cout << "The Rectangle Area is " << Area << endl;
}

int main()
{

	float High, Width;
	ReadRectangleArea(High, Width);
	PrintRectangleArea(CalculateRectangleArea(High, Width));

	_getch();
	return 0;
}

