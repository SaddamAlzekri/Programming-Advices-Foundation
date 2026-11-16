#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReadString()
{
	string S1 = " ";
	cout << "Please enter your String?\n";
	getline(cin, S1);

	return S1;
}

string PrintUpperAllLetters(string S1)
{
	bool FirstLtter = true;

	cout << "\nString after Upper.\n";

	for (short i = 0; i < S1.length(); i++)
	{
			S1[i] = toupper(S1[i]);
	}
	return S1;
}

string PrintLowerAllLetters(string S1)
{
	bool FirstLtter = true;

	cout << "\nString after Lower.\n";

	for (short i = 0; i < S1.length(); i++)
	{
		S1[i] = tolower(S1[i]);
	}
	return S1;
}

int main()
{
	string text = ReadString();
	cout << "\n";
	cout << PrintUpperAllLetters(text) << endl;

	cout << PrintLowerAllLetters(text) << endl;
	_getch();
	return 0;
}