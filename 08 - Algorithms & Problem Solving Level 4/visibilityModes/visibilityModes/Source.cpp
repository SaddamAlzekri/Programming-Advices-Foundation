#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>

using namespace std;

class clsA{

private:
	int v1;
	int Fun1()
	{
		return 1;
	}

protected:
	int v2;
	int Fun2()
	{
		return 2;
	}
public:
	int v3;
	int Fun3()
	{
		return 3;
	}
};

class clsB : public clsA
{
public:
	int Fun4()
	{
		return 4;
	}

};

int main()
{
	clsB B1;
	cout << B1.Fun4();

	_getch();
	return 0;
}