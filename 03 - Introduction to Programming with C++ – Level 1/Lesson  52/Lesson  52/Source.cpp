#include<iostream>
#include<conio.h>
using namespace std;
void ReadArray(int Array[10])
{
	for (int i = 0; i <= 9; i++)
	{
		cin >> Array[i];
	}
}

void SearchInArray(int Array[10])
{
	for (int i = 0; i <= 9; i++)
	{
		cout << "We are at [" << i + 1 << "] iteration\n";
		if (Array[i] == 20)
		{
			cout << Array[i] <<  endl;
			break;
		}
	}
}
int main()
{
	int Array[10];
	ReadArray(Array);
	SearchInArray(Array);
	_getch();
	return 0;
}