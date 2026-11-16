#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float MyAbc(float Number)
{
	if (Number > 0)
		return Number;
	else
		return Number * -1;
}

float ReadNegetiveNumber(string Message)
{
	int Number = 0;
	cout << Message << endl;
	cin >> Number;
	return Number;
}

int main()
{
	int Counter = 0;
	int Num = ReadNegetiveNumber("Please enter negetive number.");
	cout << "\nMy abc Result : " << abs(Num);
	cout << "\nC++ abc Result : " << MyAbc(Num);

	_getch();
	return 0;
}