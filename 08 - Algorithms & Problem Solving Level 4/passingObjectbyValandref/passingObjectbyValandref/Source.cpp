#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsA
{
public:
	int x;

	void Print()
	{
		cout << "The value of x = " << x << endl;
	}
};

void Fun1(clsA A)
{
	A.x = 100;
}

void Fun2(clsA &A)
{
	A.x = 150;
}

int main()
{
	clsA A;
	A.x = 50;
	cout << "\nA.x before calling function1: \n";
	A.Print();
	cout << "===============================\n";

	Fun1(A);
	cout << "\nA.x After calling byval: \n";
	A.Print();
	cout << "===============================\n";

	Fun2(A);
	cout << "\nA.x After calling byref: \n";
	A.Print();

	_getch();
	return 0;
}