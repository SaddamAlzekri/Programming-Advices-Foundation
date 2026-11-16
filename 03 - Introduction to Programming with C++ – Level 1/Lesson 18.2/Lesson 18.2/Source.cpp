#include<iostream>
#include<conio.h>
using namespace std;

int main()
{
	int num1, num2, num3, result;
	cout << "Enter the number one.\n";
	cin >> num1;
	cout << "Enter the number two.\n";
	cin >> num2;
	cout << "Enter the number three.\n";
	cin >> num3;

	result = num1 + num2 + num3;

	cout << endl << endl;

	cout << num1 << endl;
	cout << num2 << endl;
	cout << num3 << endl;
	cout << "----------" << endl;
	cout << result;
	_getch();
	return 0;
}