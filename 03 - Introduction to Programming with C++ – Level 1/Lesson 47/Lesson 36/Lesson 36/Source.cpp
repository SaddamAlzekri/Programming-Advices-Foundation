#include<iostream>
#include<conio.h>
using namespace std;
void Power(int Num, int M)
{
	int Mul = 1;
	for (int i = 1; i <= M; i++)
	{
		Mul*=Num;
	}
	cout << "**********************************\n";
	cout <<"the power "<<Num<<"^"<<M<<" = "<<Mul;
}
int main()
{
	short Num, M;
	cout << "Please, enter the Number1\n";
	cin >> Num;
	cout << "Please, enter the Number2\n";
	cin >> M;
	Power(Num, M);
	_getch();
	return 0;
}