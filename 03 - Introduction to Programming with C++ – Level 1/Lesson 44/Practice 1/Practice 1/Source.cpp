#include<iostream>
#include<conio.h>
using namespace std;
enum enColor {Red = 1, Blue = 2, Green = 3, Yellow = 4};

int main()
{
	cout << "**********************\n";
	cout << "(1) Red\n";
	cout << "(2) Blue\n";
	cout << "(3) Green\n";
	cout << "(4) Yellow\n";
	cout << "**********************\n";
	int Color1;
	enColor Color2;
	cout << "Choice one of this Number\n";
	cin >> Color1;
	Color2 = (enColor)Color1;

	if (Color2 == enColor::Red)
	{
		cout << system("color 4F");
	}
	if (Color2 == enColor::Blue)
	{
		cout << system("color 1F");
	}
	if (Color2 == enColor::Green)
	{
		cout << system("color 2F");
	}
	if (Color2 == enColor::Yellow)
	{
		cout << system("color 6F");
	}
	_getch();
	return 0;
}