#include<iostream>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
using namespace std;

int Random3Numberfrom1To10(int From, int To)
{
	int Random = rand() % (To - From + 1) + From;
	return Random;
}
int main()
{
	srand((unsigned)time(NULL));
	cout << Random3Numberfrom1To10(30, 40) << endl;
	cout << Random3Numberfrom1To10(40, 50) << endl;
	cout << Random3Numberfrom1To10(50, 60) << endl;

	_getch();
	return 0;
}