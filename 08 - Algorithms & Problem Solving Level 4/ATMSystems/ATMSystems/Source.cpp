#include<iostream>
#include<fstream>
#include<vector>
#include<string>
using namespace std;

const string ClientFileName = "Clients.txt";
void MainSreen();

struct sClients
{
	string AccountNumber;
	int PinCode;
	string Name;
	string phoneNumber;
	int CountBalance;
};

sClients AimClient;

enum ATMOption
{
	QuickWithdraw = 1, NormalWithdraw = 2, Deposit = 3, CheckBalance = 4, Logout = 5
};

enum QuickwithdrawOption
{
	Twenty = 1, Fivty = 2, OneHundred = 3, TowHundred = 4, FourHundred = 5, SexHundred = 6, EightHundred = 7, OneThausand = 8, Exit = 9
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
	Client.AccountNumber = Clients[0];
	Client.PinCode = stoi(Clients[1]);
	Client.Name = Clients[2];
	Client.phoneNumber = Clients[3];
	Client.CountBalance = stoi(Clients[4]);

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

string AccountNumber()
{
	string AccountNumber;
	cout << "Enter Account Number : ";
	cin >> AccountNumber;

	return AccountNumber;
}

int PinCode()
{
	int Pincode;
	cout << "Enter Pin Code : ";
	cin >> Pincode;

	return Pincode;
}

short ChooseATMOptions()
{
	int Num;
	cout << "Choose what do you want to do? [1 to 5]? ";
	cin >> Num;
	return Num;
}

short ChooseQuickWithdraw()
{
	int Num;
	cout << "Choose what do you want to do? [1 to 9]? ";
	cin >> Num;
	return Num;
}

void Login()
{
	bool MarkClient = true;
	vector<sClients> Clients = LoadClientFromFile();
	
	cout << "------------------------------\n";
	cout << "\tLogin Screen" << endl;
	cout << "------------------------------\n";
	
	while (MarkClient)
	{
		string Accountnumber = AccountNumber();
		int Pincode = PinCode();

		for (sClients Client : Clients)
		{
			if (Client.AccountNumber == Accountnumber && Client.PinCode == Pincode)
			{
				MarkClient = false;
				AimClient = Client;
				MainSreen();
			}
		}
		system("cls");
		cout << "Invlaid Account Number/PinCode!\n";
	}
}

void ReturnToMainScreen()
{
	cout << "Press Any Key to Return Main Screen...";
	system("pause>0");
	MainSreen();
}

vector<sClients> ExchangeOfClientsInfo(vector<sClients> Cleints, int Number)
{
	vector<sClients> vClients;
	for (sClients Client : Cleints)
	{
		if (Client.AccountNumber == AimClient.AccountNumber)
		{
			AimClient.CountBalance -= Number;
			Client = AimClient;
			vClients.push_back(Client);
		}
		else
		{
			vClients.push_back(Client);
		}
	}

	return vClients;
}

vector<sClients> DepositeOfClientsInfo(vector<sClients> Cleints, int Number)
{
	vector<sClients> vClients;
	for (sClients Client : Cleints)
	{
		if (Client.AccountNumber == AimClient.AccountNumber)
		{
			AimClient.CountBalance += Number;
			Client = AimClient;
			vClients.push_back(Client);
		}
		else
		{
			vClients.push_back(Client);
		}
	}

	return vClients;
}

void ExchangeOfClientsInfo2(vector<sClients> Cleints, int Number)
{
	vector<sClients> vClients;
	for (sClients Client : Cleints)
	{
		if (AimClient.AccountNumber == Client.AccountNumber)
		{
			cout << Client.CountBalance << endl;

			if (Number > Client.CountBalance)
			{
				cout << "Enter an amount exceeds your balance, make another choice.\n";
				ReturnToMainScreen();
			}
		}
	}
}

vector<string> ChangeRecordToString(vector<sClients> Cleints)
{
	vector<string> vLines;
	string Line = "";

	for (sClients Client : Cleints)
	{
		Line += Client.AccountNumber + "#//#";
		Line += to_string(Client.PinCode) + "#//#";
		Line += Client.Name + "#//#";
		Line += Client.phoneNumber + "#//#";
		Line += to_string(Client.CountBalance);

		vLines.push_back(Line);
		Line = "";
	}

	return vLines;
}

void WriteClientInfoToFile(vector<string> vLine)
{
	fstream MyFile;
	MyFile.open(ClientFileName, ios::out);

	if (MyFile.is_open())
	{
		for (string Line : vLine)
		{
			if (Line != "")
			{
				MyFile << Line << endl;
			}
			cout << "\n";
		}
		MyFile.close();
	}
}

void YourBalance(vector<sClients> vLine)
{
	for (sClients Client : vLine)
	{
		if (Client.AccountNumber == AimClient.AccountNumber)
		{
			cout << "Your Balance is " << Client.CountBalance << endl;
		}

	}
}

void YourBalance2(vector<sClients> vLine)
{
	for (sClients Client : vLine)
	{
		if (Client.AccountNumber == AimClient.AccountNumber)
		{
			cout << "New Balance is " << Client.CountBalance << endl;
		}

	}
}

void YourBalance3()
{
	vector<sClients> Cleints = LoadClientFromFile();

	for (sClients Client : Cleints)
	{
		if (Client.AccountNumber == AimClient.AccountNumber)
		{
			system("cls");
			cout << "===================================\n";
			cout << "\tCheck Balance Screen" << endl;
			cout << "===================================\n";
			cout << "Your Balance is: " << Client.CountBalance << endl;
		}

	}
	cout << "\n\nPress Any Key to Return Main Screen...";
	system("pause>0");
	MainSreen();
	
}

void WithdrawOfAccountBalance(int Number)
{
	char Ch = 'n';

	vector<sClients> Cleints = LoadClientFromFile();
	Cleints = ExchangeOfClientsInfo(Cleints, Number);
	vector<string> vLine = ChangeRecordToString(Cleints);

	cout << "Are you sure you want perform rhis transaction? y/n?  ";
	cin >> Ch;

	if (Ch == 'Y' || Ch == 'y')
	{
		WriteClientInfoToFile(vLine);
		cout << "Done Successfully. ";
		YourBalance2(Cleints);
	}
	ReturnToMainScreen();
}

void DepositeOfAccountBalance(int Number)
{
	char Ch = 'n';

	vector<sClients> Cleints = LoadClientFromFile();
	Cleints = DepositeOfClientsInfo(Cleints, Number);
	vector<string> vLine = ChangeRecordToString(Cleints);

	cout << "Are you sure you want perform rhis transaction? y/n?  ";
	cin >> Ch;

	if (Ch == 'Y' || Ch == 'y')
	{
		WriteClientInfoToFile(vLine);
		cout << "Done Successfully. ";
		YourBalance2(Cleints);
	}
	ReturnToMainScreen();
}

void ShowQuickwithdrawOption(QuickwithdrawOption OptionNumber)
{
	
	switch (OptionNumber)
	{
	case QuickwithdrawOption::Twenty:
		WithdrawOfAccountBalance(20);       break;
	case QuickwithdrawOption::Fivty:
		WithdrawOfAccountBalance(50);       break;
	case QuickwithdrawOption::OneHundred:
		WithdrawOfAccountBalance(100);		break;
	case QuickwithdrawOption::TowHundred:
		WithdrawOfAccountBalance(200);		break;
	case QuickwithdrawOption::FourHundred:
		WithdrawOfAccountBalance(400);		break;
	case QuickwithdrawOption::SexHundred:
		WithdrawOfAccountBalance(600);		break;
	case QuickwithdrawOption::EightHundred:
		WithdrawOfAccountBalance(800);		break;
	case QuickwithdrawOption::OneThausand:
		WithdrawOfAccountBalance(1000);		break;
	case QuickwithdrawOption::Exit:
		ReturnToMainScreen();
		break;

	default:
		break;
	}
}

void QuickdWithdraw()
{
	system("cls");
	cout << "===================================\n";
	cout << "\tQuick Withdraw Screen" << endl;
	cout << "===================================\n";

	cout << "\t[1] 20\t\t"; cout << "[2] 50" << endl;
	cout << "\t[3] 100\t\t"; cout << "[4] 200" << endl;
	cout << "\t[5] 400\t\t"; cout << "[6] 600" << endl;
	cout << "\t[7] 800\t\t"; cout << "[8] 100" << endl;
	cout << "\t[9] Exit" << endl;

	cout << "===================================\n";
	vector<sClients> Cleints = LoadClientFromFile();
	YourBalance(Cleints);
	ShowQuickwithdrawOption((QuickwithdrawOption)ChooseQuickWithdraw());
}

void Normalwithdraw()
{
	system("cls");
	int Num = 0;
	vector<sClients> Cleints = LoadClientFromFile();
	cout << "===================================\n";
	cout << "\tNormal Withdraw Screen" << endl;
	cout << "===================================\n";

	cout << "Enter an amount Multiple of 5's ? ";
	cin >> Num;

	ExchangeOfClientsInfo2(Cleints, Num);

	while (Num % 5 != 0)
	{
		cout << "Enter an amount Multiple of 5's ? ";
		cin >> Num;

	} 

	WithdrawOfAccountBalance(Num);

}

void Deposite()
{
	system("cls");
	cout << "===================================\n";
	cout << "\tDeposite Screen" << endl;
	cout << "===================================\n";
	int Deposite = 0;
	cout << "Enter a positive Deposite Amount? ";
	cin >> Deposite;

	DepositeOfAccountBalance(Deposite);

}

void ShowATMSystemOption(ATMOption OptionNumber)
{

	switch (OptionNumber)
	{
	case ATMOption::QuickWithdraw:
		QuickdWithdraw();
		break;
	case ATMOption::NormalWithdraw:
		Normalwithdraw();
		break;
	case ATMOption::Deposit:
		Deposite();
		break;
	case ATMOption::CheckBalance:
		YourBalance3();
		break;
	case ATMOption::Logout:
		Login();
		break;
	default:
		break;
	}
}

void MainSreen()
{
	system("cls");
	cout << "===================================\n";
	cout << "\tATM Main Menue Screen" << endl;
	cout << "===================================\n";

	cout << "\t[1] Quick Withdraw.\n";
	cout << "\t[2] Normal Withdraw.\n";
	cout << "\t[3] Deposit.\n";
	cout << "\t[4] Check Balance.\n";
	cout << "\t[5] Logout.\n";
	cout << "===================================\n";

	ShowATMSystemOption((ATMOption)ChooseATMOptions());
}

int main()
{
	Login();

	system("pause");
	return 0;
}
