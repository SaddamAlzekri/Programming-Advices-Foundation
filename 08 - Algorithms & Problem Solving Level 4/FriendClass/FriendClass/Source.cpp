#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsA 
{
private:
	int _var1;
protected:
	int _var2;
public:
	int _var3;

	clsA()
	{
		_var1 = 10;
		_var2 = 20;
		_var3 = 30;
	}

	friend class clsB;
};

class clsB
{
public:
	void Desplay(clsA A)
	{
		cout << "The value of var1 = " << A._var1 << endl;
		cout << "The value of var2 = " << A._var2 << endl;
		cout << "The value of var3 = " << A._var3 << endl;
	}
};
int main()
{
	clsA A;
	clsB B;
	B.Desplay(A);

	_getch();
	return 0;
}