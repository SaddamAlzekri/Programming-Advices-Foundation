#include<iostream>
#include<conio.h>
using namespace std;
void SumOddNumber(int Num)
{
	int Sum = 0;
	for (int i = 1; i <= Num; i++)
	{
		if (i % 2 != 0)
		{
			Sum += i;
		}
	}
	cout << "The Sum of Odd Number " << Sum << endl;
}
int main()
{
	short Num;
	cout << "Plaese, enter the number\n";
	cin >> Num;
	SumOddNumber(Num);
	_getch();
	return 0;
}
