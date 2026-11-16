#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
#include<vector>
#include<cstdio>
#include<iomanip>
#include<fstream>
using namespace std;
const string FileName = "ClientsInfo.txt";

struct ClientIfo
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	bool isMark = false;
	double AccountBalance;
};

enum ClientServece
{
	ShowClientList = 1,
	AddNewClient = 2,
	DeleteClient = 3,
	UpdateClient = 4,
	FindClient = 5,
	Exit = 6
};

ClientServece MainMenueScreen()
{
	short Number = 0;
	cout << "=====================================================\n";
	cout << "\t\t\tMain Menue Screen";
	cout << "\n=====================================================\n";
	cout << "[1] Show Client List.\n";
	cout << "[2] Add New Client.\n";
	cout << "[3] Delete Client.\n";
	cout << "[4] Update Client Info.\n";
	cout << "[5] Find Client.\n";
	cout << "[6] Exit.\n";
	cout << "\n=====================================================\n";
	cout << "Choice what do you want to do? [1 to 6]? ";
	cin >> Number;

	return (ClientServece)Number;
}

vector <string>  SplitString(string Line, string Seperator)
{
	string sWords = "";
	short Pos = 0;
	vector <string> vString;

	while ((Pos = Line.find(Seperator)) != std::string::npos)
	{
		sWords = Line.substr(0, Pos);

		if (sWords != "")
		{
			vString.push_back(sWords);
		}
		Line.erase(0, Pos + Seperator.length());
	}

	if (Line != "")
	{
		vString.push_back(Line);
	}

	return vString;
}

ClientIfo  ConvertLineToRecord(string Line)
{
	vector <string> vClients;
	ClientIfo Client;

	vClients = SplitString(Line, "#//#");

	Client.AccountNumber = vClients[0];
	Client.PinCode = vClients[1];
	Client.Name = vClients[2];
	Client.Phone = vClients[3];
	Client.AccountBalance = stod(vClients[4]);

	return Client;
}

vector <ClientIfo> LoadClientsFromFile(string FileName)
{
	fstream MyFile;
	vector <ClientIfo> Clients;

	MyFile.open(FileName, ios::in);

	if (MyFile.is_open())
	{
		string Line;
		ClientIfo Client;
		while (getline(MyFile, Line))
		{
			Client = ConvertLineToRecord(Line);
			Clients.push_back(Client);
		}
	}
	return Clients;
}

int main()
{
	vector <ClientIfo> vClients = LoadClientsFromFile(FileName);

	for (ClientIfo &S : vClients)
	{
		cout << S.Name << endl;
	}

	_getch();
	return 0;
}