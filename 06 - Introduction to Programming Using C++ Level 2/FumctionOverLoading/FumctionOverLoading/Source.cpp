#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
int MySum(double a, double b)
{
	return (a + b);
}

int MySum(int a, int b)
{
	return (a + b);
}

int MySum(int a, int b, int c)
{
	return (a + b + c);
}

int MySum(int a, int b, int c, int d)
{
	return (a + b + c + d);
}
int main()
{

	cout << MySum(12.4, 2.6) << endl;
	cout << MySum(12, 3) << endl;
	cout << MySum(5, 5, 5) << endl;
	cout << MySum(5, 5, 2, 3) << endl;
	_getch();
	return 0;
}