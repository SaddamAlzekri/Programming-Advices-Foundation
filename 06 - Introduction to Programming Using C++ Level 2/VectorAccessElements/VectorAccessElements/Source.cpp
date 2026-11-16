#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> Numbers{ 1, 2, 3, 4, 5 };
	cout << "Using .at(i)\n";

	cout << "Elements at Index 0: " << Numbers.at(0) << endl;
	cout << "Elements at Index 1: " << Numbers.at(1) << endl;
	cout << "Elements at Index 2: " << Numbers.at(2) << endl;
	cout << "Elements at Index 3: " << Numbers.at(3) << endl;

	cout << "\nUsing [i]\n\n";

	cout << "Elements at Index 0: " << Numbers[0] << endl;
	cout << "Elements at Index 1: " << Numbers[1] << endl;
	cout << "Elements at Index 2: " << Numbers[2] << endl;
	cout << "Elements at Index 3: " << Numbers[3] << endl;

	_getch();
	return 0;
}