#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsA
{
public:
	clsA() {}
	clsA(short value)
	{
		x = value;
	}
	short x;
	void Print()
	{
		cout << "The value of x = " << x << endl;
	}
};


int main()
{
	short NumberOfObjects = 5;

	clsA *Arr = new clsA[NumberOfObjects];

	for (short i = 0; i < NumberOfObjects; i++)
	{
		Arr[i] = clsA(i);
	}

	for (short i = 0; i < NumberOfObjects; i++)
	{
		Arr[i].Print();
	}
	_getch();
	return 0;
}