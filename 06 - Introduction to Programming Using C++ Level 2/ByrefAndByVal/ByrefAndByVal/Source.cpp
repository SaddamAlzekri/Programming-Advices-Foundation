#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
void Function1(int a)
{
	a++;
}

void Function2(int &b)
{
	b++;
}

int main()
{
	int a = 10, b = 20;
	cout << "a = " << a << "\t" << "b = " << b << endl;
	//By Value
	Function1(a);
	//by Refrance
	Function2(b);
	cout << "a = " << a << "\t" << "b = " << b << endl << endl;
	cout << "The Address of a variable: " << &a << endl;
	cout << "The Address of b variable: " << &b << endl;

	_getch();
	return 0;
}