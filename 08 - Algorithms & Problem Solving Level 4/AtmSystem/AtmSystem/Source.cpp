#include<iostream>
#include<fstream>
#include<vector>
#include<string>
using namespace std;

const string ClientFileName = "Clients.txt";

struct sClients
{
	string UserName;
	int PassWord;
	int CountBalance;
};

vector<string> SplitString(string Line, string Delim)
{
	int Pos = 0;
	string sWord = "";
	vector<string> Client;
	while ((Pos = Line.find(Delim)) != std::string::npos)
	{
		sWord = Line.substr(0, Pos);

		if (sWord != "")
		{
			Client.push_back(sWord);
		}
		Line.erase(0, Pos + Delim.length());
	}
	if (Line != "")
	{
		Client.push_back(Line);
	}
	return Client;
}

sClients  ConvertLineToRecord(string Line)
{
	sClients Client;
	vector<string> Clients = SplitString(Line, "#//#");

	Client.PassWord = stoi(Clients[2]);
	Client.UserName = Clients[3];
	Client.CountBalance = stoi(Clients[5]);

	return Client;
}

vector<sClients> LoadClientFromFile()
{
	fstream File;
	vector<sClients> Clients;
	File.open(ClientFileName, ios::in);

	if (File.is_open())
	{
		string Line;
		sClients Client;

		while (getline(File, Line))
		{
			Client = ConvertLineToRecord(Line);
			Clients.push_back(Client);
		}
	}	

	File.close();

	return Clients;
}

int main()
{

	vector<sClients> Client = LoadClientFromFile();

	for (sClients x : Client)
	{
		cout << x.UserName << endl;
	}

	system("pause");
	return 0;
}