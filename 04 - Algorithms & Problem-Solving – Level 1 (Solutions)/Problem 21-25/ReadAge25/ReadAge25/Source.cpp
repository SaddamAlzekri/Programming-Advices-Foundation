
#include<iostream>
#include<conio.h>
using namespace std;

int ReadAge()
{
	int Age;
	cout << "Please enter the age.\n";
	cin >> Age;
	return Age;
}

bool ValidateNumberInAge(int Age, int From, int To)
{
	return (Age >= From && Age <= To);
}

int ReadUntilAgeBetween(int From, int To)
{
	int Age;

	do
	{

		Age = ReadAge();

	} while (!ValidateNumberInAge(Age, From, To));
	return Age;
}

void PrintResult(int Age)
{
	cout << "Your ae is " << ReadUntilAgeBetween(18, 45) << endl;
}

int main()
{
	PrintResult(ReadAge());
	_getch();
	return 0;
}