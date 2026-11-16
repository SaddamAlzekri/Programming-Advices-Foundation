#include<iostream>
#include<conio.h>
using namespace std;
void SumFunctionNoReturnValue(float num1, float num2)
{
	float Result = num1 + num2;
	cout << "\n\n******************\n";
	cout << Result << endl;
}

float SumFunctionReturnValue(float num1, float num2)
{
	float Result = num1 + num2;
	return Result;
}
int main()
{
	float Num1, Num2;
	cout << "Please, enter the Number1.\n";
	cin >> Num1;
	cout << "Please, enter the Number2.\n";
	cin >> Num2;

	
	SumFunctionNoReturnValue(Num1, Num2);
	cout << "\n\n******************\n";
	cout << SumFunctionReturnValue(Num1, Num2);

	_getch();
	return 0;
}