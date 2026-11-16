#include<iostream>
#include<conio.h>
#include<string>
#include<vector>
#include<string.h>
#include<fstream>
#include<iomanip>
using namespace std;

struct ClientInfo
{
	string AccountNumber;
	string PinCode;
	string Name;
	string Phone;
	double AccountBalance = 0;
};

vector <string>  SplitString(string S1, string Delim)
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

ClientInfo ReadToVector(string S1)
{
	ClientInfo Client;
	vector <string> vWords;
	vWords = SplitString(S1, "    ");


		Client.AccountNumber = vWords[0];
		Client.PinCode = vWords[1];
		Client.Name = vWords[2];
		Client.Phone = vWords[3];
		Client.AccountBalance = stod(vWords[4]);

	return Client;
}

vector <ClientInfo> ReadFile()
{

	vector <ClientInfo> vClient;
	fstream MyFile;
	MyFile.open("MyFile.txt", ios::in);

	if (MyFile.is_open())
	{
		ClientInfo Client;
		string Line;
		while (getline(MyFile, Line))
		{
			Client = ReadToVector(Line);
			vClient.push_back(Client);

		}
		MyFile.close();
	}
	return vClient;
}

void PrintClientRecord(ClientInfo Client, string S1, vector <ClientInfo> vWords, short &Counter)
{
	
	if (Client.AccountNumber == S1)
	{
    cout << "|" << setw(12) << left << Client.AccountNumber;
	cout << "|" << setw(12) << left << Client.PinCode;
	cout << "|" << setw(40) << left << Client.Name;
	cout << "|" << setw(12) << left << Client.Phone;
	cout << "|" << setw(12) << left << Client.AccountBalance;
	}
	else
	{
		Counter++;
		if (vWords.size() == Counter)
		{
			cout << "Client With Account Number(" << S1 << ") Not Found!\n";
		}
			
		
	}
	
}

void PrintAllVlientRecords(vector <ClientInfo> vWords)
{
	string S1;
	short Counter = 0;
	//vector <ClientInfo> vString;
	cout << "\n\t\t\t\tClient List(" << vWords.size() << ") Client(s)\n";
	cout << "Please enter AccountNumber? ";
	cin >> S1;
	
	cout << "\n__________________________________________________________________________________________________\n";
	cout << "|" << setw(12) << left << "AccountNumber";
	cout << "|" << setw(12) << left << "PinCode";
	cout << "|" << setw(40) << left << "Name";
	cout << "|" << setw(12) << left << "Phone";
	cout << "|" << setw(12) << left << "AccountBalance";
	cout << "\n__________________________________________________________________________________________________\n";
	for (ClientInfo &Client : vWords)
	{
		PrintClientRecord(Client, S1, vWords, Counter);
		cout << endl;
		//vString.push_back(Client)
	}
	cout << "__________________________________________________________________________________________________\n";
}

int main()
{
	vector <ClientInfo> vClient = ReadFile();

	PrintAllVlientRecords(vClient);

	_getch();
	return 0;
}