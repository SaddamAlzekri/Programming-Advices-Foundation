#include<iostream>
#include<conio.h>
#include<string>
#include<math.h>
using namespace std;

int ReadNumber(string Message)
{
	int Num = 0;
	cout << Message << endl;
	cin >> Num;
	return Num;
}

int MySqrt(float Number)
{
	return pow(Number, 0.5);
}

int main()
{
	float Number = ReadNumber("Please enter float Number.");
	cout << "C++ sqrt Result : " << MySqrt(Number) << endl;
	cout << "My sqrt Result : " << sqrt(Number) << endl;
	_getch();
	return 0;
}