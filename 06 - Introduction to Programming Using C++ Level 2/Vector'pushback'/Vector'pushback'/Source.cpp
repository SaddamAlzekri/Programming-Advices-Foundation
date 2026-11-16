#include<iostream>
#include<conio.h>
#include<vector>
using namespace std;

int main()
{
	vector <int> vNumber;

	vNumber.push_back(10);
	vNumber.push_back(20);
	vNumber.push_back(30);
	vNumber.push_back(45);

	vNumber.push_back(90);
	cout << "Vector vNumber: \n";

	for (int &vNum : vNumber)
	{
		cout << vNum << endl;
	}
	cout << endl;
	_getch();
	return 0;
}