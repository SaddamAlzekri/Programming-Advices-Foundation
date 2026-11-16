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

string PrintUpperFirstLetterEachWord(string S1)
{
	bool FirstLtter = true;

	cout << "\nString after conversation.\n";

	for (short i = 0; i < S1.length(); i++)
	{
		if (S1[i] != ' ' && FirstLtter)
		{
			S1[i] = toupper(S1[i]);
		}
		FirstLtter = (S1[i] == ' ' ? true : false);
	}
	return S1;
}

int main()
{
	cout<< PrintUpperFirstLetterEachWord(ReadString());
	_getch();
	return 0;
}