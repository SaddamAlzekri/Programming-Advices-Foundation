#include<iostream>
#include<conio.h>
#include<string>
#include<string.h>
using namespace std;

struct MyInfo
{
	string AccountNumber = "";
	int PINCode = 0;
	int Phone = 0;
	string Name = "";
	float AccountBalance = 0;

};

MyInfo FillEmpleeInfo(MyInfo emploeeInfo)
{
	cout << "Enter Name!!!\n";
	getline(cin, emploeeInfo.Name);

	cout << "Enter Phone!!!\n";
	cin >>emploeeInfo.Phone;

	cout << "Enter AccountBalace!!!\n";
	cin >> emploeeInfo.AccountBalance;

	cout << "Enter Account Number!!!\n";
	cin >> emploeeInfo.AccountNumber;

	cout << "Enter PinCode!!!\n";
	cin >> emploeeInfo.PINCode;

	
	return emploeeInfo;

}

string ConvertRecordToLine(MyInfo EmplyeeInfo, string Delim)
{
	string S1 = "";
	
	
	S1 += EmplyeeInfo.AccountNumber + Delim;
	S1 += to_string(EmplyeeInfo.PINCode) + Delim;
	S1 += EmplyeeInfo.Name + Delim;
	S1 += to_string(EmplyeeInfo.Phone) + Delim;
	S1 += to_string(EmplyeeInfo.AccountBalance) + Delim;

	return S1;
}

int main()
{
	
	MyInfo Infor;
	Infor = FillEmpleeInfo(Infor);
	cout << "Client Records for saving is:\n";
	cout << ConvertRecordToLine(Infor, " ");

	_getch();
	return 0;
}