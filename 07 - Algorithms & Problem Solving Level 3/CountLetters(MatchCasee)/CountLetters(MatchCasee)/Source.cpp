#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReadString()
{
	string S1;
	cout << "Please enter your string?\n";
	getline(cin, S1);

	return S1;
}

char ReadCharacter()
{
	char S1;
	cout << "Please enter your Character?\n";
	cin >> S1;

	return S1;
}

char InvertCharacter(char Char1)
{
	return isupper(Char1) ? tolower(Char1) : toupper(Char1);
}

int CountLetter(string S1, char Letter, bool MatchCase = true)
{
	int Counter = 0;
	for (short i = 0; i < S1.length(); i++)
	{
		if (MatchCase)
		{
			if (S1[i] == Letter)
				Counter++;
		}
		else
		{
			if (tolower(S1[i]) == tolower(Letter))
				Counter++;
		}
	}
	return Counter;
}

int main()
{
	string Letter = ReadString();

	char Char1 = ReadCharacter();

  	cout << "Letter \' " << Char1 << "\' Count = " << CountLetter(Letter, Char1);

	cout << "\n\nLetter \' " << Char1 << "\' Or " << "\' " << InvertCharacter(Char1) << "\' " << "Count = " << CountLetter(Letter, Char1, false);

	_getch();
	return 0;
}