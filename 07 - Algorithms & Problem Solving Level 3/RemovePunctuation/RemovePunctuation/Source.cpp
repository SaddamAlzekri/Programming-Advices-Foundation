#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

string ReadString()
{
	string S1;
	cout << "Please enter Your string!!!\n";
	getline(cin, S1);
	return S1;

}

string RemovePunctuation(string S1)
{
	string S2;
	for (short i = 0; i < S1.length(); i++)
	{
		if (!ispunct(S1[i]))
		{
			S2 += S1[i];
		}


	}
	return S2;
}

int main()
{
	string S1 = ReadString();
	cout << "\n Puanctuation Removed:\n";
	cout<<RemovePunctuation(S1);

	_getch();
	return 0;
}