
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

void PrintResult(int Age)
{
	if (ValidateNumberInAge(Age, 18, 45))
		cout << "Is a valid age\n";
	else
		cout << "Is not valid Age\n";
}
int main()
{
	PrintResult(ReadAge());
	_getch();
	return 0;
}