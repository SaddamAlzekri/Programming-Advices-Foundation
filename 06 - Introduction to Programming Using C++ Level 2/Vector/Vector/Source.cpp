#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> vNumber = { 1, 2, 3, 4, 5 };

	cout << "Number Vector is: ";
	for (int &vNum : vNumber)
	{
		cout << vNum << "\t";
	}
	_getch();
	return 0;
}