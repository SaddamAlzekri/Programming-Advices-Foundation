#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadCharacter()
{
	string S1 = " ";
	cout << "Please enter a string.\n";
	getline(cin, S1);

	return S1;
}

//Anthor one for Answer
int StringLength(string S1)
{
	int TextLengthCount = 0;

	for (short i = 0; i < S1.length(); i++)
	{
		TextLengthCount++;
	}
	return TextLengthCount;
}

int CapitalLetterCount(string S1)
{
	int CapitalLetterCount = 0;
	for (short i = 0; i < S1.length(); i++)
	{
		if (isupper(S1[i]))
			CapitalLetterCount++;
	}

	return CapitalLetterCount;
}

int  SmallCapitalLetterCount(string S1)
{
	int SmallLetterCount = 0;
	for (short i = 0; i < S1.length(); i++)
	{
		if (islower(S1[i]))
			SmallLetterCount++;
	}

	return SmallLetterCount;
}

//Anthor two for Answer
enum enCountLetter{
	SmallLetter = 0,
	CapitalLetter = 1,
	All = 2
};

short CountLetter(string S1, enCountLetter CountLetter = enCountLetter::All)
{
	if (CountLetter == enCountLetter::All)
		return S1.length();

	int Counter = 0;
	for (short i = 0; i < S1.length(); i++)
	{
		if (CountLetter == enCountLetter::SmallLetter && islower(S1[i]))
			Counter++;

		if (CountLetter == enCountLetter::CapitalLetter && isupper(S1[i]))
			Counter++;
	}

	return Counter;

}
int main()
{
	string text = ReadCharacter();

	cout << "string Length = ";
	cout << CountLetter(text);
	
	cout << "\n\nCapital Letter Count = ";
	cout << CountLetter(text, enCountLetter::CapitalLetter);

	cout << "\n\nSmall Letter Count = ";
	cout << CountLetter(text, enCountLetter::SmallLetter);

	_getch();
	return 0;

}
