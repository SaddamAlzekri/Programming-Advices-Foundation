#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;
int main()
{
	int a = 10;

	cout << setw(15) << "A value  : " << setw(10) << a << endl;
	cout << setw(15) << "A address: " << setw(10) << &a << endl;

	int *p;
	p = &a;

	cout << setw(15) << "A address: " << setw(10) << p << endl;
	cout << setw(15) << "A value  : " << setw(10) << *p << endl << endl;
	
	*p = 20;
	cout << setw(25) << "After change \'*p\' value\n\n";
	cout << setw(15) << "A value  : " << setw(10) << a << endl;
	cout << setw(15) << "A value  : " << setw(10) << *p << endl << endl;

	a = 30;
	cout << setw(25) << "After change \'a\' value\n\n";
	cout << setw(15) << "A value  : " << setw(10) << a << endl;
	cout << setw(15) << "A value  : " << setw(10) << *p << endl;
	_getch();
	return 0;
}