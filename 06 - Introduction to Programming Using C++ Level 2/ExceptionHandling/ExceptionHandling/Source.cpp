#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> Numbers{ 1, 2, 3, 4, 5 };
	try
	{
		cout << Numbers.at(5);
	}
	catch (...)
	{
		cout << "Out Of bound\n";
	}
	_getch();
	return 0;
}