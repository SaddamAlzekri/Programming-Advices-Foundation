#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

void Swape(int &Number1, int &Number2)
{
	int Current;

	Current = Number1;
	Number1 = Number2;
	Number2 = Current;
	cout << Number1 << "\t\t" << Number2 << endl;

}

int main()
{
	int Number1, Number2;
	cout << "Please, enter the number1.\n";
	cin >> Number1;
	cout << "Please, enter the number2.\n";
	cin >> Number2;
	cout << endl << endl;
	cout << Number1 << "\t\t" << Number2 << endl;
	Swape(Number1, Number2);
	cout << Number1 << "\t\t" << Number2 << endl;

	_getch();
	return 0;
}