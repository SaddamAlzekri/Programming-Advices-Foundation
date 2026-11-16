#include<iostream>
#include<conio.h>
#include<string>
#include<vector>
#include<string.h>
#include<fstream>
using namespace std;
const string MyFille = "MyFile.txt";

struct ClientInfo
{
	string AccountNumner;
	string PinCode;
	string Name;
	string Phone;
	double AccountBalace;
};

ClientInfo ReadClientInfo()
{
	ClientInfo ClientInformation;
	cout << "Enter Account Number  : ";
	getline(cin >> ws, ClientInformation.AccountNumner);
	cout << "Enter PinCode         : ";	
	getline(cin , ClientInformation.PinCode);
	cout << "Enter Name            : ";
	getline(cin , ClientInformation.Name);
	cout << "Enter Phone           : ";
	getline(cin , ClientInformation.Phone);
	cout << "Enter Account Balance : ";
	cin >> ClientInformation.AccountBalace;

	return ClientInformation;
}

string RecordToLine(ClientInfo ClientInformation, string Delim)
{
	string S1 = "";

	S1 += ClientInformation.AccountNumner + Delim;
	S1 += ClientInformation.PinCode + Delim;
	S1 += ClientInformation.Name + Delim;
	S1 += ClientInformation.Phone + Delim;
	S1 += to_string(ClientInformation.AccountBalace);

	return S1;
}

void AddDataLineToFile(string S1)
{
	fstream MyFile;
	MyFile.open(MyFille, ios::app | ios::out);

	if (MyFile.is_open())
	{
		MyFile << S1 << endl;
	}
	MyFile.close();
}

void AddNewClient()
{
	ClientInfo ClientInformation;
	ClientInformation = ReadClientInfo();

	AddDataLineToFile(RecordToLine(ClientInformation, "#\#"));
}

void AddClients()
{
	char isSighn = 'Y';
	while (toupper(isSighn == 'Y'))
	{
		system("cls");
		cout << "Adding New Client:\n\n";
		AddNewClient();
		cout << "\nClient Added Successfully, do you want to add more clients? Y/N?";
		cin >> isSighn;
	}
}
int main()
{
	AddClients();
	_getch();
	return 0;
}