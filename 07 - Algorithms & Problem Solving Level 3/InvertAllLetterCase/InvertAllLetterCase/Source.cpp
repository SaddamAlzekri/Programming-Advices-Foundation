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

char InverceCharacter(char S1)
{
	return isupper(S1) ? tolower(S1) : toupper(S1);
}

string PrintInvertAllLetter(string S1)
{
	for (short i = 0; i < S1.length(); i++)
	{
		S1[i] = InverceCharacter(S1[i]);
	}
	return S1;
}

int main()
{
	string text = ReadCharacter();
	cout<<PrintInvertAllLetter(text);
	_getch();
	return 0;

}
