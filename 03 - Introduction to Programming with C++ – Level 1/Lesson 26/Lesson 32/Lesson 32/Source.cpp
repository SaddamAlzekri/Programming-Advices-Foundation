#include<iostream>
#include<conio.h>
using namespace std;  
float PowNumber(float Number1, float Number2)
{
	return pow(Number1, Number2);
}
int main()
{
	float Number1, Number2;
	cout << "Enter the Number1 and Number2.\n";
	cin >> Number1 >> Number2;
	cout << PowNumber(Number1, Number2) << endl;
	_getch();
	return 0;
}