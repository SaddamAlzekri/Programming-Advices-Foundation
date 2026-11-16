#include<iostream>
#include<math.h>
#include<conio.h>
using namespace std;

void ReadNumbers(int& a, int& h)
{
	cout << "Please enter the traingle a\n";
	cin >> a;
	cout << "Plaese enter the traingle h\n";
	cin >> h;
}

float CalculateTraingleArea(int a, int h)
{
	float Result;
	Result = ((a * h)/ 2);
	return Result;
}

void PrintResult(float Result)
{
	cout << "The rectangle area is " << Result << endl;
}

int main()
{
	int a, h;
	ReadNumbers(a, h);
	PrintResult(CalculateTraingleArea(a, h));

	_getch();
	return 0;
}