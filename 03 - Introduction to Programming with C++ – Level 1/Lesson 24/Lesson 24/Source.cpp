#include<iostream>
#include<conio.h>
using namespace std;

int main()
{
	short A, B;
	cout << "Please enter the first number A\n";
	cin >> A;
	cout << "Please enter the first number A\n";
	cin >> B;

	cout << A << "=" << B <<" is "<< (A == B) << endl;
	cout << A << "!=" << B << " is " << (A != B) << endl;
	cout << A << ">" << B << " is " << (A > B) << endl;
	cout << A << "<" << B << " is " << (A < B) << endl;
	cout << A << ">=" << B << " is " << (A >= B) << endl;
	cout << A << "<=" << B << " is " << (A <= B) << endl;
	_getch();
	return 0;
}