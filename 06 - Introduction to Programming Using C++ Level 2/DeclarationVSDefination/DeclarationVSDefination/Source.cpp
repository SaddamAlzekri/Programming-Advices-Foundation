#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
//Function Declaration
void Add(int, int);
int main()
{
	Add(12, 3);

	_getch();
	return 0;
}
//Function Definition
void Add(int Num1, int Num2)
{
	cout << (Num1 + Num2);
}