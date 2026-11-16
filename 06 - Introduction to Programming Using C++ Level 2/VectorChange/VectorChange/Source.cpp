#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> Numbers{ 1, 2, 3};

	cout << "Initial vector: ";
	for (const int &Num : Numbers)
	{
		cout << Num << "\t";
	}

	cout << "\n\nUpdated vectors: ";
	for (int &Num : Numbers)
	{
		Num = 20;
		cout << Num << "\t";
	}

	Numbers.at(0) = 20;
	Numbers[1] = 10;
	Numbers.at(2) = 30;

	cout << "\n\nUpdated vectors: ";
	for (int &Num : Numbers)
	{
		cout << Num << "\t";
	}
	_getch();
	return 0;
}
