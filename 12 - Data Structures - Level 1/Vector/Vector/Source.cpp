#include<iostream>
#include<vector>
#include<conio.h>
using namespace std;

int main()
{
	vector <int> vNumber1;
	vector <int> vNumber2;

	vNumber1.push_back(10);
	vNumber1.push_back(20);
	vNumber1.push_back(30);
	vNumber1.push_back(40);
	vNumber1.push_back(50);

	vNumber2.push_back(60);
	vNumber2.push_back(70);
	vNumber2.push_back(80);
	vNumber2.push_back(90);
	vNumber2.push_back(100);

	vNumber1.swap(vNumber2);

	cout << "The elements of vector is :\t" << vNumber1.size() << endl;
	cout << "The Elements is :\t";
	while (!vNumber1.empty())
	{
		cout << vNumber1.back() << "\t";
		vNumber1.pop_back();
	}

	cout << "\nThe elements of vector is :\t" << vNumber2.size() << endl;
	cout << "The Elements is :\t";
	while (!vNumber2.empty())
	{
		cout << vNumber2.back() << "\t";
		vNumber2.pop_back();
	}
	_getch();
	return 0;
}