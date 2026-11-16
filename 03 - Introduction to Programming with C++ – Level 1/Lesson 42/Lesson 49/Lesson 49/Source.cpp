#include<iostream>
#include<conio.h>
using namespace std;

void ATMPIN(int PassWord)
{
	if (PassWord == 1234)
	{
		cout << "User Balance is 7500" << endl;
	}
	else
	{
		cout << "Wrong PIN\n";
	}
}

int main()
{
	int PassWord;
	cout << "Please, enter the PASSWORD\n";
	cin >> PassWord;
	ATMPIN(PassWord);
	_getch();
	return 0;
}