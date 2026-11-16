#include<iostream>
#include<conio.h>
#include<string>
#include<vector>
#include<string.h>
using namespace std;

vector <string> SplitString(string S1, string Delim)
{
	vector <string> vWords;
	string sWord;
	int Pos = 0;

	while ((Pos = S1.find(Delim)) != std::string::npos)
	{
		sWord = S1.substr(0, Pos);

		if (sWord != "")
		{
			vWords.push_back(sWord);
		}
		S1.erase(0, Pos + Delim.length());
	}
	if (S1 != "")
		vWords.push_back(S1);
	return vWords;
}

string LowerAllCase(string S1)
{
	for (short i = 0; i < S1.length(); i++)
	{
		S1[i] = tolower(S1[i]);
	}
	return S1;
}

string JoinString(vector <string> vWords, string Delim)
{
	string S1;
	for (string S : vWords)
	{
		S1 += S + Delim;
	}

	return S1;
}

string ReplaceWordInStringInUsignSplit(string S1, string StringToReplace, string ReplaceTo, bool MatchCase = true)
{
	string Delim = " ";
	vector <string> vWords = SplitString(S1, Delim);
	
	for (string &S : vWords)
	{
		if (MatchCase)
		{
			if (S == StringToReplace)
				S = ReplaceTo;
		}
		else
		{
			if (LowerAllCase(S) == LowerAllCase(StringToReplace))
				S = ReplaceTo;
		}
	}

	return JoinString(vWords, Delim);
}
int main()
{
	string S1 = "I live in Eygpt";
	string StringReplaceTo = "eygpt";
	string ReplaceTo = "Yemen";

	cout << "Originel String:\n" << S1 << endl;

	cout << "Replace with Match case:  \n";
	cout << ReplaceWordInStringInUsignSplit(S1, StringReplaceTo, ReplaceTo) << "\n\n";

	cout << "Replace with donot Match case:  \n";
	cout << ReplaceWordInStringInUsignSplit(S1, StringReplaceTo, ReplaceTo, false) << "\n\n";

	_getch();
	return 0;
}