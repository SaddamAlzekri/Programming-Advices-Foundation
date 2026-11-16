#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<stdlib.h>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;
	} while (Num < 1);
	return Num;
}

void FillArrayBeforShuffle(int Num)
{
	string Array[100] = {};int N = 0;
	cout << "\nArray elements :\n\n";
	for (int i = 0; i < 4; i++)
	{
		
		for (int j = 0; j < 4; j++)
		{
			N = (rand() % (90 - 65 + 1) + 65);
			Array[i] = char(N);
			cout << Array[i];
		}
		if (i == 3)
			continue;
		cout << "-";
	
	}
}

int main()
{
	srand((unsigned)time(NULL));
	/*FillArrayBeforShuffle(ReadPositiveNumber(""));*/

	_getch();
	return 0;
}

