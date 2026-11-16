#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
int ReadNumber()
{
	int Number;
	cout << "Please enter a number: ";
	cin >> Number;

	while (cin.fail())
	{
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

		cout << "Please enter a number: ";
		cin >> Number;
	}
	return Number;
}
int main()
{
	cout << "your Number is: " << ReadNumber();
	_getch();
	return 0;
}

