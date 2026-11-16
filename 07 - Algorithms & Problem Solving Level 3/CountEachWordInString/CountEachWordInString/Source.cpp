#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;
string ReadString()
{
	string S1;
	cout << "Please enter your string?\n";
	getline(cin, S1);
	return S1;
}


short CountEachWordInString(string S1)
{
	string S2 = " ";
	short Pos = 0;
	string SWord;
	int Counter = 0;

	while ((Pos = S1.find(S2)) != std::string::npos)
	{
		SWord = S1.substr(0, Pos);

		if (SWord != "")
			Counter++;

		S1.erase(0, Pos + S2.length());
	}

	if (S1 != "")
		Counter++;
	return Counter;
}

int main()
{
	string S1 = ReadString();
	cout << "\nThe Number Of Words in your String = " << CountEachWordInString(S1);
	_getch();
	return 0;
}