#include<iostream>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
using namespace std;

int Random3Numberfrom1To10(int From, int To)
{
	int Random = rand() % (To - From + 1) + From;
	return Random;
}

enum  encharType { SmallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4};

char GetRandomcharacter(encharType Char)
{
	switch (Char)
	{
	case encharType::SmallLetter:
		return char(Random3Numberfrom1To10(97, 122));
		break;
	case encharType::CapitalLetter:
		return char(Random3Numberfrom1To10(65, 90));
		break;
	case encharType::SpecialCharacter:
		return char(Random3Numberfrom1To10(33,47));
		break;
	case encharType::Digit:
		return char(Random3Numberfrom1To10(48, 57));
		break;
		default:
			break;
	}
}
int main()
{
	encharType Char;
	srand((unsigned)time(NULL));
	cout << GetRandomcharacter(encharType::SmallLetter) << endl;
	cout << GetRandomcharacter(encharType::CapitalLetter) << endl;
	cout << GetRandomcharacter(encharType::SpecialCharacter) << endl;
	cout << GetRandomcharacter(encharType::Digit) << endl;


	_getch();
	return 0;
}