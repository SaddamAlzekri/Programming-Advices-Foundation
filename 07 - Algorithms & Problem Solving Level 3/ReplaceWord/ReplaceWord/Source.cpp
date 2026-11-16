#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReplaceWordInString(string S1, string StringReplaceTo, string ReplaceTo)
{
	int Pos = S1.find(StringReplaceTo);

	while ((Pos != std::string::npos))
	{
		S1 = S1.replace(Pos, StringReplaceTo.length(), ReplaceTo);
		Pos = S1.find(StringReplaceTo);
	}
	return S1;
}

int main()
{
	string S1 = "Wellcome to Jordan , Jordan is a nice country\n";
	string StringReplaceTo = "Jordan";
	string ReplaceTo = "Yemen";

	cout << "Original string\n" << S1 << endl;
	cout << "\nString  after Replace: \n";
	cout << ReplaceWordInString(S1, StringReplaceTo, ReplaceTo);


	_getch();
	return 0;
}
