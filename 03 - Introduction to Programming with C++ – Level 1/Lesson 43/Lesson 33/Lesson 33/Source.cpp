#include<iostream>
#include<conio.h>
using namespace std;
char YourGrade(int Grade)
{
	if (Grade >= 90 && Grade <= 100)
	{
		return 'A';
	}
	if (Grade >= 80 && Grade <= 89)
	{
		return 'B';
	}
	if (Grade >= 70 && Grade <= 79)
	{
		return 'C';
	}
	if (Grade >= 60 && Grade <= 69)
	{
		return 'D';
	}
	if (Grade >= 50 && Grade <= 59)
	{
		return 'E';
	}
	else
	{
		return 'F';
	}
}
int main()
{
	short Grade;
	cout << "Please, enter your GRADE\n";
	cin >> Grade;
	cout << YourGrade(Grade);
	_getch();
	return 0;
}