#include<iostream>
#include<vector>
#include<conio.h>
using namespace std;

void ReadNumber(vector <int> &vNumber)
{
	int Number = 0;
	char YOrN;
	do
	{
		cout << "Read Number to Vector: ";
		cin >> Number;
		vNumber.push_back(Number);
		cout << "\nClick \'Y\\y\' to continue\n";
		cin >> YOrN;
	} while (YOrN == 'Y'||YOrN == 'y');
}

void PrintVector(vector <int> vNumber)
{
	cout << "Vector Number is: ";
	for (int &vNum : vNumber)
	{
		cout << vNum << "\t";
	}
}

int main()
{
	vector <int> vNumber;
	ReadNumber(vNumber);
	PrintVector(vNumber);
	_getch();
	return 0;
}