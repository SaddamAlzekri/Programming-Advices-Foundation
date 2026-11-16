#include<iostream>
#include<conio.h>
using namespace std;

void SumevenNumber(int Num)
{
	int Sum = 0;
	for (int i = 1; i <= Num; i++)
	{
		if (i % 2 == 0)
		{
			Sum += i;
		}
	}
	cout << Sum << endl;
}
int main()
{
	short Num;
	cout << "Please, enter the Number\n";
	cin >> Num;
	SumevenNumber(Num);
	_getch();
	return 0;
}
