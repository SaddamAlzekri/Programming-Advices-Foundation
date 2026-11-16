#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

char ReadCharacter()
{
	char S1 = ' ';
	cout << "Please enter a character.\n";
	cin >> S1;
	return S1;
}

char InverceCharacter(char S1)
{
	
	cout << "Char after inverting case: \n";

	if (char(S1) > 90 )
		S1 = toupper(S1);
	else if (char(S1) < 90)
		S1 = tolower(S1);
	return S1;
}

int main()
{
cout<<	InverceCharacter(ReadCharacter());
	
	_getch();
	return 0;

}