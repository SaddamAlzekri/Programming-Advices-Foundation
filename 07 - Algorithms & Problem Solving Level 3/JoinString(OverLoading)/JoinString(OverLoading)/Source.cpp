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

string JoinStringx(string arrName[3] ,short Length, string Delim)
{
	string S1 = "";
	for (short i = 0; i < Length; i++)
	{
		S1 += arrName[i] + Delim;
	}
	return S1.substr(0, S1.length() - Delim.length());
}
int main()
{
	vector <string> vName{ "Saddam", "Hussein", "Alzekri" };
	string arrName[3] = { "Saddam", "Hussein", "Alzekri" };

	cout << "Vector after join: \n";
	cout << JoinString(vName, " ") << endl;

	cout << "\nArray after join: \n";
	cout << JoinStringx(arrName, 3, " ") << endl;

	_getch();
	return 0;
}