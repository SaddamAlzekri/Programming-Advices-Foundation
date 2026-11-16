#include<iostream>
#include<conio.h>
using namespace std;

int main()
{
	int *Ptrx;
	float *Ptry;

	Ptrx = new int;
	Ptry = new float;

	*Ptrx = 10;
	*Ptry = 58.35f;

	cout << *Ptrx << endl;
	cout << *Ptry << endl;

	delete Ptrx;
	delete Ptry;

	_getch();
	return 0;
}