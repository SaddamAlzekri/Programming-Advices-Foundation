#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

float ReadNumber(string Message)
{
	int Num;
	cout << Message << endl;
	cin >> Num;
	return Num;
}

float SumNumber()
{
	int Sum = 0, Number = 0, Counter = 1;

	do
	{
		Number = ReadNumber("Please enter the number " + to_string(Counter));
		if (Number == -99)
		{
			break;
		}

		Sum += Number;
		Counter++;
	} while (Number != 99);
	return Sum;
}

int main()
{
	cout << "The result is " << SumNumber();
	_getch();
	return 0;
}