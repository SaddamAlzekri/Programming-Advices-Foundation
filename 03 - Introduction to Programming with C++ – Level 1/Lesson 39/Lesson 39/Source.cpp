#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

int main()
{
	float Grades[3];
	cout << "Please, enter Grade1?\n";
	cin >> Grades[0];
	cout << "Please, enter Grade2?\n";
	cin >> Grades[1];
	cout << "Please, enter Grade3?\n";
	cin >> Grades[2];
	cout << "\n*************************\n";
	float Avg = (Grades[0] + Grades[1] + Grades[2]) / 3;
	cout <<"The average of grades "<<Avg << endl;
	cout<<
	_getch();
	return 0;
}