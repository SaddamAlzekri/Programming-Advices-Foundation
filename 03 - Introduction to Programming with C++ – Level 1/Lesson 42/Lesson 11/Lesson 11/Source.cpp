#include<iostream>
#include<conio.h>
using namespace std;
float DisplayAvg(short Mark1, short Mark2, short Mark3)
{
	float Avg = (Mark1 + Mark2 + Mark3) /3;
	return Avg;
}

void PassOrFail(float AvgDgree)
{
	if (AvgDgree >= 50)
	{
		cout << "You are PASS.\n";
	}
	else
	{
		cout << "You are Fail.\n";
	}
}
int main()
{
	float Mark1, Mark2, Mark3;
	cout << "Please, enter the MARK1.\n";
	cin >> Mark1;
	cout << "Please, enter the MARK2.\n";
	cin >> Mark2;
	cout << "Please, enter the MARK3.\n";
	cin >> Mark3;

	cout << "***************************\n";
	cout << DisplayAvg(Mark1, Mark2, Mark3) << endl;
	float AvgDgree = DisplayAvg(Mark1, Mark2, Mark3);
	PassOrFail(AvgDgree);
	_getch();
	return 0;
}