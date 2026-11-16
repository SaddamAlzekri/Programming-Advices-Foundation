#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadString()
{
	string text = " ";

	cout << "Please enter the string.\n";
	getline(cin, text);

	return text;

}

char readCharacter()
{
	char Character = 0;
	cout << "\nPlease enter Charater.\n";
	cin >> Character;

	return Character;
}

int CountSpecificeLetter(string S1, char Char1)
{
	int CountSpecificeLetter = 0;
	for (short i = 0; i < S1.length(); i++)
	{
		if (S1[i] == Char1)
			CountSpecificeLetter++;
	}
	return CountSpecificeLetter;
}

int main()
{
	string text = ReadString();

	char Char1 = readCharacter();

	int CountOfLetter = CountSpecificeLetter(text, Char1);

	cout << "\nLetter \'"<< Char1 << "\' Count  = " << CountOfLetter << endl;

	_getch();
	return 0;
}