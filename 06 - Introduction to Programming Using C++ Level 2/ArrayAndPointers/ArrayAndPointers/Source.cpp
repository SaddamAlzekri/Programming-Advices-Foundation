#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;

int main()
{
	int arr[4] = { 10, 20, 30, 40};
	int* Ptr;
	Ptr = arr;

	cout << "Address are: \n\n";

	cout << Ptr + 1 << endl;
	cout << Ptr + 2 << endl;
	cout << Ptr + 3 << endl;
	cout << Ptr + 4 << endl;

	cout << "\n\nValues are: \n\n";

	cout << *(Ptr)<< endl;
	cout << *(Ptr + 1) << endl;
	cout << *(Ptr + 2) << endl;
	cout << *(Ptr + 3) << endl;

	_getch();
	return 0;
}
