#include<iostream>
#include<conio.h>
using namespace std;
void Factorial(int Num)
{
	int Mul = 1;
	for (int i = Num; i >= 1; i--)
	{
		Mul *= i;
	}
	cout << Mul;
}
int main()
{
	short Num;
	cout << "Please, enter the Number\n";
	cin >> Num;
	Factorial(Num);
	_getch();
	return 0;
}