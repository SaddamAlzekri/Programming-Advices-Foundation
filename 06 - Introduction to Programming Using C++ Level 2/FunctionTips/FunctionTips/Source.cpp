#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
void Function2();

void Function4()
{
	cout << "Hi, I'm Function 4!!!\n";
}

void Function3()
{
	Function4();
}

void Function2()
{
	Function3();
}

void Function1()
{
	Function2();
	Function4();
	
}

int main()
{
	Function1();
	_getch();
	return 0;
}