#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
#include<vector>
using namespace std;

struct Clientinfo
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	double AccountBalance;
};

vector <string> SplitString(string S1, string Delim)
{
	string sWords = "";
	int Pos = 0;
	vector <string> vWords;
	while ((Pos = S1.find(Delim)) != std::string::npos)
	{
		sWords = S1.substr(0, Pos);

		if (sWords != "")
		{
			vWords.push_back(sWords);
		}
		S1.erase(0, Pos + Delim.length());
	}
	if (S1 != "")
		vWords.push_back(S1);
	return vWords;
}

Clientinfo ConvertLineToRecord( string S1)
{
	vector <string> sWords;
	sWords = SplitString(S1, "#//#");
	Clientinfo ClientInfo;

	ClientInfo.AccountNumber = sWords[0];
	ClientInfo.PinCode = sWords[1];
	ClientInfo.Name = sWords[2];
	ClientInfo.Phone = sWords[3];
	ClientInfo.AccountBalance =stod(sWords[4]);

	return ClientInfo;
}

void PrintClientRecord(Clientinfo ClientInfo)
{
	
	cout << "The following is extracted Client record:\n\n";
	cout << "Account Number : " << ClientInfo.AccountNumber << endl;
	cout << "PinCode        : " << ClientInfo.PinCode << endl;
	cout << "Name           : " << ClientInfo.Name << endl;
	cout << "Phone          : " << ClientInfo.Phone << endl;
	cout << "Account Balance: " << ClientInfo.AccountBalance << endl;
	
}

int main()
{

	Clientinfo ClientInfo;
	string S1 = "A123#//#1234#//#Saddam Alzekri#//#712126932#//#5000.000000";
	cout << "Line Record is: \n";
	cout << S1 << "\n\n";

	ClientInfo = ConvertLineToRecord(S1);
	PrintClientRecord(ClientInfo);

	_getch();
	return 0;
}