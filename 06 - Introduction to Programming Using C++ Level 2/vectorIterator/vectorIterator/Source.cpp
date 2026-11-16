#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> Numbers{ 1, 2, 3, 4, 5 };

	vector <int>::iterator iter;

	for (iter = Numbers.begin(); iter != Numbers.end(); iter++)
	{
		cout << *iter << "\t";
	}
	_getch();
	return 0;
}
