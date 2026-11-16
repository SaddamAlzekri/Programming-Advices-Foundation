#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void PrintLetterFromAToZ()
{
	for (int i = 65; i <= 90; i++)
	{
		cout << char(i) << endl;
	}
}

int main()
{
	PrintLetterFromAToZ();
	_getch();
	return 0;
}