#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadNumber(string Message)
{
	float Num = 0;
	cout << Message << endl;
	cin >> Num;
	return Num;
}

float MyFloor(float Number)
{
	if (Number > 0)
		return int(Number);
	else if (Number < 0)
		return int(--Number);
}

int main()
{
	float Number = ReadNumber("Please enter float Number.");
	cout << "C++ Floor Result : " << MyFloor(Number) << endl;
	cout << "My Floor Result : " << floor(Number) << endl;
	_getch();
	return 0;
}