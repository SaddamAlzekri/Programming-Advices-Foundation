#include<iostream>
#include<conio.h>
using namespace std;
void ReadArray(int array[5])
{
	for (int i = 0; i <= 4; i++)
	{
		cout << "Please enter the number [" << i + 1 << "].\n";
		cin >> array[i];
	}

}

int SumBelow50(int array[5])
{
	int Sum = 0;
	for (int i = 0; i <= 4; i++)
	{
		if (array[i] > 50)
		{
			continue;
		}
		Sum += array[i];
	}
	return Sum;
}
int main()
{
	int Array[5];
	ReadArray(Array);
	cout << "The Sum of below 50 = " << SumBelow50(Array) << endl;
	_getch();
	return 0;
}