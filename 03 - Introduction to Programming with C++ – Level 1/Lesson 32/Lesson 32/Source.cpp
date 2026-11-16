#include<iostream>
#include<conio.h>
using namespace std;
void DisplayMycardInfo()
{
	cout << "Name : Saddam Al-zekri.\n";
	cout << "City : Taiz.\n";
	cout << "Country : YEMEN" << endl;
}

void DisplayStarSquar()
{
	cout << "************.\n";
	cout << "************."<<endl;
	cout << "************.\n";
	cout << "************."<<endl;
}

void PrintILoveProgramming()
{
	cout << "I love programming.\n\n";
	cout << "I promise to be the best developer ever!\n\n";
	cout << "I know it will take some time to practice, but I will Achieve my goal.\n" << endl;
	cout << "Best Regards.\n";
	cout << "Saddam Al-zekri.\n";
}

void H()
{
	cout << "*\t\t*\n";
	cout << "*\t\t*\n";
	cout << "*\t\t*\n";
	cout << "*****************\n";
	cout << "*\t\t*\n";
	cout << "*\t\t*\n";
	cout << "*\t\t*\n";

}
int main()
{
	cout << "************************.\n";
	DisplayMycardInfo();
	cout << "************************.\n\n";
	DisplayStarSquar();
	cout << endl << endl;
	PrintILoveProgramming();
	cout << endl << endl;
	H();

	_getch();
	return 0;
}