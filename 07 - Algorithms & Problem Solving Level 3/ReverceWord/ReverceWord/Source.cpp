#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
#include<vector>
using namespace std;

string Readstring()
{
	string S1;
	cout << "Please enter your string!!!\n";
	getline(cin, S1);
	return S1;
}

vector <string>  Splitstring(string S1, string Delim)
{
	int Pos = 0;
	string SWord = "";
	int i = 0;
	vector <string> vWords;

	while ((Pos = S1.find(Delim)) != std::string::npos)
	{
		SWord = S1.substr(0, Pos);

		if (SWord != "")
		{
			vWords.push_back(SWord);
		}

		S1.erase(0, Pos + Delim.length());
	}
	if (S1 != "")
	{
		vWords.push_back(S1);
	}

	return vWords;
}

string ReverceWordInString(string S1)
{
	vector <string> vWords = Splitstring(S1, " ");
	string S2;

	vector <string>::iterator iter = vWords.end();
	while (iter != vWords.begin())
	{
		--iter;

		S2 += *iter + " ";
	}
	S2 = S2.substr(0, S2.length() - 1);

	return S2;
}

int main()
{

	string S1 = Readstring();
	cout << "string after reverce words:\n";
	cout << ReverceWordInString(S1);

	_getch();
	return 0;
}