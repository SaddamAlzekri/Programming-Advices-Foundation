#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
#include<vector>
using namespace std;

string ReadString()
{
	string S1;
	cout << "Please enter the your string?\n";
	getline(cin, S1);
	return S1;
}

vector <string> SlitString(string S1, string Delim)
{
	vector <string> vString;
	string Blockspace = " ";
	int Pos = 0, Counter = 0;
	string SWord;

	while ((Pos = S1.find(Blockspace)) != std::string::npos)
	{
		SWord = S1.substr(0, Pos);

		if (SWord != "")
			vString.push_back(SWord);

		S1.erase(0, Pos + Blockspace.length());
	}

	if (S1 != "")
		vString.push_back(SWord);

	return vString;
}

int main()
{
	vector <string> vString;
	vString = SlitString(ReadString(), " ");

	cout << "\nToken = " << vString.size() << endl;

	for (string &vString : vString)
		cout << vString << endl;
	_getch();
	return 0;
}