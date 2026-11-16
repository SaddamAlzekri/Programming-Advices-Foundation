#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void MyFunc()
{
	static int Number = 1;
	cout << "Variable of number: " << Number << endl;
	Number++;
}
int main()
{
	MyFunc();
	MyFunc();
	MyFunc();
	_getch();
	return 0;
}