#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
string Reada3LetterPassword(string Message)
{
	string Password = "";
	int Counter = 0;
	do
	{
		cout << Message << endl;
		cin >> Password;
		Counter = Password.length();
	} while (Counter != 3);
	return Password;
}

string ChangeSmallToCapital(string Letter)
{
	string  PassWord = "";
	for (int i = 97; i <= 122; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			if (char(i) == Letter[j])
			{
				PassWord += char(i - 32);
			}
		}
	}
	return PassWord;
}

bool PrintAllWordsFromAAAToZZZ(string PW)
{
	string PPP = PW;
	for (int i = 97; i <= 122; i++)
	{
		if (PW[0] == char(i))
			PPP = ChangeSmallToCapital(PW);
	}

	int Counter = 0;
	string PW2 = "";
	for (int i = 65; i < 91; i++)
	{
		for (int j = 65; j < 91; j++)
		{
			for (int k = 65; k < 91; k++)
			{
				Counter++;
				PW2 += char(i);
				PW2 += char(j);
				PW2 += char(k);
				cout << "Trial [" << Counter << "]" << PW2 << endl;
				if (PW2 == PPP)
				{
					cout << "Password is " << PPP << endl;
					cout << "Found after " << Counter << " Trail(s)" << endl;
					return true;
				}
				PW2 = "";
			}
		}
	}
}

int main()
{
	string str = Reada3LetterPassword("Please Enter 3 Letter Password");
	cout<<PrintAllWordsFromAAAToZZZ(str);
	_getch();
	return 0;
}