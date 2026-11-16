#include<iostream>
#include<conio.h>
using namespace std;
void ReadArrayData(int arr[100], int& Length)
{
	cout << "How many number that want to enterin array?\n";
	cin >> Length;
	for (int i = 0; i <= Length - 1; i++)
	{
		cout << "The number " << i + 1 << endl;
		cin >> arr[i];
	}
}
void PrintArrayData(int arr[100], int Length)
{
	for (int i = 0; i <= Length - 1; i++)
	{
		cout << "Number [" << i + 1 << "] = " << arr[i] << endl;
	}
}
int CalculateArraySum(int arr[100], int Length)
{
	int Sum = 0;
	for (int i = 0; i <= Length - 1; i++)
	{
		Sum+=arr[i];
	}

	return Sum;
}
float CalculateArrayAverage(int arr[100], int Length)
{
	return (float)CalculateArraySum(arr, Length) / Length;
}
int main()
{
	int arr[100], Length = 0;
	ReadArrayData(arr, Length);
	PrintArrayData(arr, Length);

	float Sum = CalculateArraySum(arr, Length);

	//************************First Method************************
	//cout << "*********************************\n";
	//cout << "Sum : " << CalculateArraySum(arr, Length) << endl;
	//cout << "Average : " << CalculateArrayAverage(arr, Length) << endl;

	//******Second Method without CalculateArrayData Fuction******
	cout << "*********************************\n";
	cout << "Sum : " << Sum << endl;
	cout << "Average : " << Sum / Length << endl;

	_getch();
	return 0;
}