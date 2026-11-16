#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReadString()
{
	string S1;
	cout << "Please enter your string?\n";
	getline(cin,S1);

	return S1;
}

bool IsVowel(char ch)
{
	ch = tolower(ch);

	return ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'u') || (ch == 'o'));
}

short CountVowel(string S1)
{
	short Counter = 0;
	for (short i = 0; i < S1.length(); i++)
	{
			if (IsVowel(S1[i]))
				Counter++;
	}
	return Counter;
}

int main()
{
	string S1 = ReadString();

	cout << "\n\nNumber of vowel is = " << CountVowel(S1) << endl;

	_getch();
	return 0;
}