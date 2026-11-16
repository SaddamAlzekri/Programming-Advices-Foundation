#include<iostream>
#include<conio.h>
#include<iomanip>
using namespace std;
void swap(int *Num1, int *Num2)
{
	int Temp = 0;
	Temp = *Num1;
	*Num1 = *Num2;
	*Num2 = Temp;
}
int main()
{
	int a = 10, b = 20;

	cout << setw(25) << "Before the change value!!!\n";

	cout << setw(15) << " A value: " << setw(10) << a << endl;
	cout << setw(15) << " A value: " << setw(10) << b << endl;

	swap(&a, &b);

	cout << setw(25) << "After the change value!!!\n";

	cout << setw(15) << " A value: " << setw(10) << a << endl;
	cout << setw(15) << " A value: " << setw(10) << b << endl;
	_getch();
	return 0;
}
