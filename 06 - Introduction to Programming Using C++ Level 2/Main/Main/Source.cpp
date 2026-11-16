#include<iostream>
#include<conio.h>
#include "MyLibrary.h"
#include "MyInputLibrary.h"
using namespace std;
using namespace MyLibrary;

int main()
{
	float Num1 = MyInputLibrary::ReadNumber();
	float Num2 = MyInputLibrary::ReadNumber();
	MyLibrary::CharactorType;
	CharactorType ChoiceCharactorType = MyLibrary::ChoiceCharactorType();
	cout <<"The Result Of Operation is: "<< MyLibrary::simpleCalculator(ChoiceCharactorType, Num1, Num2);

	_getch();
	return 0;

}