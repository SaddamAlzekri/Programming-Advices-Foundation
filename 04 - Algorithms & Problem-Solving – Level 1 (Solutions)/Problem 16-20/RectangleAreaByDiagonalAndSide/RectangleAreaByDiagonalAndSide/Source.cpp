#include<iostream>
#include<math.h>
#include<conio.h>
using namespace std;

void ReadNumbers(int& a, int& d)
{
	cout << "Please enter the rectangle side \n";
	cin >> a;
	cout << "Plaese enter the rectangle diagonal\n";
	cin >> d;
}

float CalculateRectangleBySideAndDiagonal(int a, int d)
{
	float Result;
	Result = (a * sqrt(pow(d, 2) - pow(a, 2)));
	return Result;
}

void PrintResult(float Result)
{
	cout << "The rectangle area is " << Result << endl;
}

int main()
{
	int a, d;
	ReadNumbers(a, d);
	PrintResult(CalculateRectangleBySideAndDiagonal(a, d));

	_getch();
	return 0;
}