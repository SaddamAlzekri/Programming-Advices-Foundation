#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadPositiveNumber(string Message)
{
	int Number = 0;
	do
	{
		cout << Message << endl;
		cin >> Number;
	} while (Number < 1);
	return Number;
}

void öAddArrayelemenets(int arr[100], int arrLength)
{
	
		arr[arrLength] = ReadPositiveNumber("Please enter a number?");
}

bool ConditionYesOrNo()
{
	int Logic;
	cout << "\nDo you want to add more number ? [0] : No, [1] : yes ? \n";
	cin >> Logic;
	return Logic;
}


void AddNumber(int arr[100], int &arrLength)
{
	bool Logic = true;
	do
	{
		öAddArrayelemenets(arr, arrLength);
		arrLength++;
		Logic = ConditionYesOrNo();

	} while (Logic);
}

void PrintArray(int arr[100],int arrLength)
{
	cout << "\nArray Length: " << arrLength;
	cout << "\nArray elemenets: ";
	for (int i = 0; i < arrLength; i++)
	{
		cout << arr[i] << "\t";
	}
}

int main()
{
	int arr[100], arrLength = 0;
	AddNumber(arr, arrLength);
	PrintArray(arr, arrLength);

	_getch();
	return 0;
}