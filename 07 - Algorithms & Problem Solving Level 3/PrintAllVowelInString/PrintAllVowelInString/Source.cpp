#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReadString()
{
	string S1;
	cout << "Please enter your Character?\n";
	getline(cin, S1);

	return S1;
}

bool IsVowel(char Ch)
{
	Ch = tolower(Ch);
	return ((Ch == 'a') || (Ch == 'u') || (Ch == 'i') || (Ch == 'e') || (Ch == 'o'));
}

void CountVowel(string S1)
{
	short Counter = 0;
	cout << "Vowels in string are:\t";
	for (short i = 0; i < S1.length(); i++)
	{
		if (IsVowel(S1[i]))
			cout << S1[i] << "\t";
	}
}

int main()
{
	string S1 = ReadString();
	CountVowel(S1);

	_getch();
	return 0;
}