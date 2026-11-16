#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;

int main()
{
	int a = 10;
	int &x = a;

	cout << setw(15) << "The value \'a\\x\'\n\n";

	cout << setw(15) << "a value  : " << a << endl;
	cout << setw(15) << "a value  : " << x << endl << endl;

	cout << setw(15) << "The address \'a\\x\'\n\n";

	cout << setw(15) << "a address: " << &a << endl;
	cout << setw(15) << "a address: " << &x << endl << endl;
	int* p;
	int b = 20;
	p = &b;
	cout << setw(15) << "The \'p\' value and address afetr p = &b\n\n";

	cout << setw(15) << "a address: " << *p << endl;
	cout << setw(15) << "a value  : " << p << endl << endl;

	int c = 30;
	p = &c;
	cout << setw(15) << "The \'p\' value and address afetr p = &c\n\n";

	cout << setw(15) << "a address: " << *p << endl;
	cout << setw(15) << "a value  : " << p << endl << endl;


	_getch();
	return 0;
}
