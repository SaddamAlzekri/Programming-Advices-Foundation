#include<iostream>
#include<conio.h>
using namespace std;
void PrintCapitalLetters()
{
	cout << "\t\t\t\tCAPITAL LITTERIS\n\n";
	for (int i = 65; i <= 90; i++)
	{
		cout << char(i) << "\t";
	}
	cout << "\n\n\t\t\t\tSMALL LITERS\n\n";
	for (int i = 97; i <= 122; i++)
	{
		cout << char(i) << "\t";
	}
}
int main()
{

	PrintCapitalLetters();
	_getch();
	return 0;
}