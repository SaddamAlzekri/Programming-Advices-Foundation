#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

char ReadCharacter()
{
	char S1;
	cout << "Please enter your Character?\n";
	cin >> S1;

	return S1;
}

bool IsVowel(char ch)
{
	ch = tolower(ch);
	return ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'));
}

int main()
{
	char ch = ReadCharacter();
	if (IsVowel(ch))
		cout << "Yes: Letter \' " << ch << "\' is vowel.\n";
	else 
		cout << "No: Letter \' " << ch << "\' isnot vowel.\n";

	_getch();
	return 0;
}