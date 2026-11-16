#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void PrintTabHeader()
{
	cout << "\t\t\t   Multiplication Table 1 To 10\n\n";
	for (int Counter2 = 1; Counter2 <= 10; Counter2++)
	{
		cout << "\t" << Counter2;
	}
	cout << "\n___________________________________________________________________________________\n";
}

string CulomnSperator(int Num)
{
	if (Num > 9)
		return "   | ";
	else
		return "    |";
}

void Multiplication()
{
	PrintTabHeader();

	for (int Counter1 = 1; Counter1 <= 10; Counter1++)
	{
		cout << Counter1 << CulomnSperator(Counter1);
		for (int Counter2 = 1; Counter2 <= 10; Counter2++)
		{
			cout << "\t" << Counter1 * Counter2;
		}
		cout << endl;
	}

}

int main()
{
	Multiplication();
	_getch();
	return 0;
}