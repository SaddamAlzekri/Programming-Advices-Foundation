#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int arrNumbers[] = {1, 2, 3, 4, 5, 6, 7, 8, 9};

	/*for (int i : arrNumbers)
	{
		cout << i << endl;
	}*/

	for (int i : {1, 2, 3, 4, 5, 6, 7, 8, 9})
	{
		cout << i << endl;
	}
	_getch();
	return 0;
}