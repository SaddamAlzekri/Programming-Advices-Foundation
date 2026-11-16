#include<iostream>
#include<conio.h>
using namespace std;

void Changevalues(int Number1, int Number2)
{
	int Current;
	cout << Number1 << "\n" << Number2 << endl<<endl<<endl;
	Current = Number1;
	Number1 = Number2;
	Number2 = Current;
	cout << Number1 << "\n" << Number2 << endl;
}

int main()
{
	//define the variables
	int Number1, Number2;
	//input the numbers
	cout << "Please, enter the number1.\n";
	cin >> Number1;
	cout << "Please, enter the number2.\n";
	cin >> Number2;
	cout << "******************************\n\n";
	//Function for change the values
	Changevalues(Number1, Number2);
	_getch();
	return 0;
}