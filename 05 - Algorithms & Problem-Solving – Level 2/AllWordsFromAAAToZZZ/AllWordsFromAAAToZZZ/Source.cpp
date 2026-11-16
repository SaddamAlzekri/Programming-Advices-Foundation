#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

void PrintAllWordsFromAAAToZZZ()
{
	cout << "\n";
	string Word = "";
	for (int i = 65; i < 91; i++)
	{
		for (int j = 65; j < 91; j++)
		{
			for (int k = 65; k < 91; k++)
			{
				Word += char(i);
				Word += char(j);
				Word += char(k);
				cout << Word <<endl;
				Word = "";
			}
		}
	}
	cout << "\n-----------------------------------\n";
}

int main()
{
	PrintAllWordsFromAAAToZZZ();
	_getch();
	return 0;
}