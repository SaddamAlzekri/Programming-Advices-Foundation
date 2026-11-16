#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
int sum4Numbers(int a, int b, int c = 0, int Sum = 0)
{
	Sum += a + b + c;
	return Sum;
}
int main()
{
	cout << "Result is: " << sum4Numbers(3, 3) << endl;
	cout << "Result is: " << sum4Numbers(3, 3, 3) << endl;
	cout << "Result is: " << sum4Numbers(3, 3, 3, 3) << endl;

	_getch();
	return 0;
}