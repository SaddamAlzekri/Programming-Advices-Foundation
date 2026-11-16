#include<iostream>
#include<conio.h>
using namespace std;

void PassOrFail(int Mark)
{
	if (Mark >= 50)
	{
		cout << "****************\n";
		cout << "You are PASS.\n";
	}
	else
	{
		cout << "****************\n";
		cout << "You are FAIL.\n";
	}
}
int main()
{
	short Mark;
	cout << "Please, enter your MARK.\n";
	cin >> Mark;
	PassOrFail(Mark);
	_getch();
	return 0;
}