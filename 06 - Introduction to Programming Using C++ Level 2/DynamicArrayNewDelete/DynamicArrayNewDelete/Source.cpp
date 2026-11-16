#include<iostream>
#include<iomanip>
#include<conio.h>
using namespace std;

int main()
{
	int *Ptr, Num;
	cout << "Please enter the total number of student: ";
	cin >> Num;
	Ptr = new int[Num];

	cout << "\n\nEnter grades of student." << endl;
	for (int i = 0; i < Num; i++)
	{
		cout << setw(10) << "Student" << i + 1 << ":  ";
		cin >> *(Ptr + i);
	}

	cout << "\nDisplay grades of student." << endl;
	for (int i = 0; i < Num; i++)
	{
		cout << endl <<setw(10) << "Student" << i + 1 << ":  " << *(Ptr + i);
	}

	delete[] Ptr;
	_getch();
	return 0;
}
