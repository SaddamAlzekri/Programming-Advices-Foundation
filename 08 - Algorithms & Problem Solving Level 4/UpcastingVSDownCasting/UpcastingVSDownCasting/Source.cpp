#include<iostream>S
#include<conio.h>
#include<string>
using namespace std;

class clsA
{
public:
	string FirstName = "Saddam Al-zekri";
};

class clsB : public clsA
{
public:
	string Title = "CEO";
};

int main()
{
	clsB B;
	cout << B.FirstName << endl;
	
	//Up Casting
	clsA *A = &B;
	cout << A->FirstName << endl;

	clsA A2;
	cout << A2.FirstName << endl;

	//Down Casting
	//clsB *B2 = &A2;

	_getch();
	return 0;
}