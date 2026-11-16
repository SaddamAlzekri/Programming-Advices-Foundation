#include<iostream>
#include<conio.h>
#include<string>

using namespace std;

class clsA
{
public:
	clsA(short Value)
	{
		x = Value;
	}
	short x;

	void Print()
	{
		cout << "The value of x = " << x << endl;
	}
};

int main()
{
	clsA ob[] = { clsA(10), clsA(20), clsA(30)};

	for (short i = 0; i < 3; i++)
	{
		ob[i].Print();
	}
	_getch();
	return 0;
}