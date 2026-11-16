#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadString()
{
	string  S1 = "";
	cout << "Please enter your string.\n";
	getline(cin, S1);

	return S1;
	
}

void PrintFirstLetterEachWord(string S1)
{
	bool isFirstLetter = true;
	cout << "First Letter of this string.\n";
	for (short i = 0; i < S1.length(); i++)
	{
		if (S1[i] != ' ' && isFirstLetter)
			cout << S1[i] << endl;
		isFirstLetter = (S1[i] == ' ' ? true : false);
	}
}
int main()
{

//	PrintFirstLetterEachWord(ReadString());
	char C = 'D';
    char v = toupper(C);
	cout << v;
	_getch();
	return 0;
}
