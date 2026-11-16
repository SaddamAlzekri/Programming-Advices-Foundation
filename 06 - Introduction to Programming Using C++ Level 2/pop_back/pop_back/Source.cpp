#include<iostream>
#include<conio.h>
#include<vector>
#include<string>
using namespace std;

int main()
{
	vector <int> vNumber;

	vNumber.push_back(12);
	vNumber.push_back(34);
	vNumber.push_back(76);
	vNumber.push_back(98);
	vNumber.push_back(56);

	//vNumber.clear();
	cout << vNumber.size() << endl;

	vNumber.pop_back();
	vNumber.pop_back();
	vNumber.pop_back();
	vNumber.pop_back();

	//if (!vNumber.empty())
	//	vNumber.pop_back();

	//if (vNumber.size())
	//	vNumber.pop_back();

	cout << "Numbers vectors: ";

	for (int &vNum: vNumber)
	{
		cout << vNum << "\t";
	}

	_getch();
	return 0;
}