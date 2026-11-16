#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	void *Ptr;
	int x = 50;

	float f1 = 10.5;

	Ptr = &f1;

	cout << Ptr << endl;
	cout << *(static_cast<float*>(Ptr)) << endl;;

	Ptr = &x;
	cout << Ptr << endl;
	cout << *(static_cast<int*>(Ptr)) << endl;

	_getch();
	return 0;
}