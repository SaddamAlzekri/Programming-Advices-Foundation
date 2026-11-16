#include<iostream>
#include<conio.h>
using namespace std;

int ReadIntNumberInRangeUsingWhile()
{
	int Number;
	cout << "Please enter the number.\n";
	cin >> Number;

	while (Number < 18 || Number > 45)
	{
		cout << "The Number is Wrong\n";
		cout << "Please enter the number again.\n";
		cin >> Number;
	}
	return Number;
}

int ReadIntNumberInRangeUsingDoWhile()
{
	int Number;
	do
	{
		cout << "Please, enter the Number.\n";
		cin >> Number;
	} while (Number < 18 || Number > 45);
	return Number;
}
int main()
{
	//cout <<"The Age is Accept "<<ReadIntNumberInRangeUsingWhile();    
	cout << "The Age is Accept " << ReadIntNumberInRangeUsingDoWhile();


	_getch();
	return 0;
}