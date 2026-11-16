#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
#include<vector>
using namespace std;

void FillvName(vector <string> & vName)
{
	string S1;

	for (int i = 0; i < 3; i++)
	{
		cout << "Please Enter your Names " << i + 1 << endl;
		cin >> S1;
		vName.push_back(S1);
	}
}

string JoinString(vector <string> vName, string Delim)
{
	string S1 = "";
	for (string &S2 : vName)
	{
		S1 = S1 + S2 + Delim;
	}
	return S1.substr(0, S1.length() - Delim.length());
}

int main()
{
	vector <string> vName{"Saddam", "Hussein", "Alzekri"};
	cout<<JoinString(vName, " ");

	_getch();
	return 0;
}