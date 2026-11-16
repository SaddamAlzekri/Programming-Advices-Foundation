#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadPincode()
{
	string PinCode;
	cout << "Please Enter PinCode.\n";
	cin >> PinCode;
	return PinCode;
}

bool Login()
{
	int Counter = 3;
	string PinCode;
	do
	{
		Counter--;
		PinCode = ReadPincode();
		if (PinCode == "1234")
		{
			return 1;
		}
		else if (Counter == 0)
		{
			return 0;
		}
		else
		{
			cout << "\nWrong PIN, You have " << Counter << " More Tries\n";
			system("color 4F");
		}
	} while (PinCode != "1234" && Counter >= 1);
}

int main()
{
	if (Login())
	{
		system("color 2F");
		cout << "\nYour account balance is " << 7500 << endl;
	}
	else
	{
		cout << "Your card blocked call the bank for help. \n";
	}
	_getch();
	return 0;
}