#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

void ReadGradesArray(float Grades[3])
{
	cout << "Please, enter the grade1?\n";
	cin >> Grades[0];
	cout << "Please, enter the grade2?\n";
	cin >> Grades[1];
	cout << "Please, enter the grade2?\n";
	cin >> Grades[2];
}

float ReturnAvg(float Grades[3])
{
	float GradesAvg = (Grades[0] + Grades[1] + Grades[2]) / 3;
	return GradesAvg;
}

int main()
{
	float Grades[3];
	ReadGradesArray(Grades);
	cout << "*************************************\n";
	cout << "The Average of grades is " << ReturnAvg(Grades) << endl;
	_getch();
	return 0;
}