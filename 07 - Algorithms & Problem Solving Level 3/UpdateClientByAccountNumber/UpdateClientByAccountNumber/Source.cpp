#include<iostream>
#include<conio.h>
#include<string>
#include<vector>
#include<string.h>
#include<fstream>
#include<iomanip>
using namespace std;

const string FileName = "MyFile.txt";

struct SClient
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	int AccountBalance;
	bool MarkAccountNumber = false;
};

vector <string> SplitString(string S1, string Seperator)
{
	string sWords = "";
	int Pos = 0;
	vector <string> vWords;

	while ((Pos = S1.find(Seperator)) != std::string::npos)
	{
		sWords = S1.substr(0, Pos);

		if (sWords != "")
		{
			vWords.push_back(sWords);
		}
		S1.erase(0, Pos + Seperator.length());
	}
	if (S1 != "")
		vWords.push_back(S1);

	return vWords;
}
SClient LineToRecord(string S1)
{
	SClient Client;
	vector <string> vWords;
	vWords = SplitString(S1, "    ");

	Client.AccountNumber = vWords[0];
	Client.PinCode = vWords[1];
	Client.Name = vWords[2];
	Client.Phone = vWords[3];
	Client.AccountBalance = stod(vWords[4]);

	return Client;
}
vector <SClient> ReadFile()
{

	vector <SClient> vClient;
	fstream MyFile;
	MyFile.open("MyFile.txt", ios::in);

	if (MyFile.is_open())
	{
		SClient Client;
		string Line;
		while (getline(MyFile, Line))
		{
			Client = LineToRecord(Line);
			vClient.push_back(Client);

		}
		MyFile.close();
	}
	return vClient;
}


bool isAccountNumber(string S1, vector <SClient> vClient, SClient& Client)
{
	for (SClient S : vClient)
	{
		if (S.AccountNumber == S1)
		{
			Client = S;
			return true;
		}
	}
	return false;
}

void PrintClient(SClient Client)
{
	cout << "\nThe following are the client details:\n";
	cout << "Account Number  :" << Client.AccountNumber << endl;
	cout << "Pin Code        :" << Client.PinCode << endl;
	cout << "Name            :" << Client.Name << endl;
	cout << "Phone           :" << Client.Phone << endl;
	cout << "Account Balance :" << Client.AccountBalance << endl;
}

bool MarktrueAccountNumber(string S1, vector <SClient> &vClient, SClient& Client)
{
	for (SClient &S : vClient)
	{
		if (S.AccountNumber == S1)
		{
			S.MarkAccountNumber = true;

			return true;
		}

	}
	return false;
}

string ConvertRecordToLine(SClient& Client)
{
	string S1;
	S1 += Client.AccountNumber + "    ";
	S1 += Client.PinCode + "    ";
	S1 += Client.Name + "    ";
	S1 += Client.Phone + "    ";
	S1 += to_string(Client.AccountBalance) + "    ";

	return S1;
}

void UpdateClient(string S1, vector <SClient> &vClient, SClient& Client)
{
	for (SClient &S : vClient)
	{
		if (S.MarkAccountNumber != false)
		{

			cout << "PinCode : ";
			getline(cin >> ws, S.PinCode);

			cout << "Name : ";
			getline(cin, S.Name);

			cout << "Phone : ";
			getline(cin, S.Phone);

			cout << "AccountBalance : ";
			cin >> S.AccountBalance;
		}
	}

}

void WriteInFile(vector <SClient> vClient, SClient& Client)
{

	fstream MyFile;
	MyFile.open("MyFile.txt", ios::out);

	string St;
	if (MyFile.is_open())
	{
		for (SClient &S : vClient)
		{
			St = ConvertRecordToLine(S);
			MyFile << St << endl;
		}
		MyFile.close();
	}
}
SClient ReadClient(string AccountNamber)
{
	SClient Client;
	Client.AccountNumber = AccountNamber;

	cout << "Enter PinCode : \n";
	getline(cin >> ws, Client.PinCode);

	cout << "Enter Name : \n";
	getline(cin >> ws, Client.Name);

	cout << "Enter Phone : \n";
	getline(cin, Client.Phone);

	cout << "Enter Account Balance : \n";
	cin >> Client.AccountBalance;

	return Client;
}


void LoadedtoFile(string AccountNamber, vector <SClient> &vClient)
{
	SClient Client;
	char Answer = 'n';

	if (isAccountNumber(AccountNamber, vClient, Client))
	{
		PrintClient(Client);
		cout << "\n\nAre you sure you want Update this client? y/n";
		cin >> Answer;
		if (Answer == 'y' || Answer == 'Y')
		{
			for (SClient &S : vClient)
			{
				if (S.AccountNumber == AccountNamber)
				{
					S = ReadClient(AccountNamber);
				}
			}

			WriteInFile(vClient, Client);

			vClient = ReadFile();
			cout << "\n\nClient Update this Client.";
		}
	}
	else
	{
		cout << "\nClient with Account Number(" << AccountNamber << ") is not Found:!";
	}
}

string ReadAccountNumber()
{
	string S1;
	cout << "Please enter Account Number?\n";
	cin >> S1;

	return S1;
}

int main()
{
	vector <SClient> vClient;
	vClient = ReadFile();
	string AccountNamber = ReadAccountNumber();

	LoadedtoFile(AccountNamber, vClient);

	_getch();
	return 0;
}