#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;

int main()
{
	//The address giving address and values giving value!!!
	int a = 10, *p;
	//Logical Error
	//p = a;
	p = &a;
	cout << setw(15) << "A address: " << p << endl;
	//Logical Error
	//*p = &a;
	*p = a;
	cout << setw(15) << "A value: " << *p << endl;
	_getch();
	return 0;
}