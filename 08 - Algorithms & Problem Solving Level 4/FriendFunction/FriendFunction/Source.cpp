#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsA
{
private:
	int _Var1;
protected:
	int _Var2;
public:
	int _Var3;

	clsA()
	{
		_Var1 = 10;
		_Var2 = 20;
		_Var3 = 30;
	}
	
	friend int MySum(clsA A);
};

int MySum(clsA A)
{
	return A._Var1 + A._Var2 + A._Var3;
}

int main()
{
	clsA A;

	cout << MySum(A);
	_getch();
	return 0;
}