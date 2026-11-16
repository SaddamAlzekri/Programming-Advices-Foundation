#include<iostream>
#include<conio.h>
using namespace std;
void AcceptOrNot(short Age)
{
	if ( Age >= 18 && Age <= 45)
	{
		cout << "You are valide age\n";
	}
	else
	{
		cout << "You are invalide age\n";
	}
}
int main()
{
	short Age;
	cout << "Please, enter the your age.\n";
	cin >> Age;
	AcceptOrNot(Age);
	_getch();
	return 0;
}

