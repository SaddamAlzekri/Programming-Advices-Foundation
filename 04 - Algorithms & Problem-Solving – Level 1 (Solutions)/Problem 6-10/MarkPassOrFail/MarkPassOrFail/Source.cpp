#include<iostream>
#include<conio.h>
using namespace std;

enum enPassFail
{
	Pass = 1,
	Fail = 2
};

int readMArk()
{
	int Num;
	cout << "Please enter the Number\n";
	cin >> Num;
	return Num;
}

enPassFail checkMark(int Mark)
{
	if (Mark >= 50)
		return enPassFail::Pass;
	else
		return enPassFail::Fail;
}

void Printresult(enPassFail Result)
{
	if (Result == enPassFail::Pass)
		cout << "You are Pass\n";
	else
		cout << "You are Fail\n";
}

int main()
{
	Printresult(checkMark(readMArk()));
	_getch();
	return 0;
};
