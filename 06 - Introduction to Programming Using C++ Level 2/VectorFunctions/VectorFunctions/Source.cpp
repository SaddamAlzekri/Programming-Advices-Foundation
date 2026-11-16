#include<iostream>
#include<vector>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	vector <int> vNumber;

	
	vNumber.push_back(12);
	vNumber.push_back(13);
	vNumber.push_back(15);
	vNumber.push_back(17);

	cout << "First elements: " << vNumber.front() << endl;
	cout << "Back elements : " << vNumber.back() << endl;
	cout << "Size elements : " << vNumber.size() << endl;
	cout << "Capacity      : " << vNumber.capacity() << endl;
	cout << "Empty         : " << vNumber.empty() << endl;

	_getch();
	return 0;
}