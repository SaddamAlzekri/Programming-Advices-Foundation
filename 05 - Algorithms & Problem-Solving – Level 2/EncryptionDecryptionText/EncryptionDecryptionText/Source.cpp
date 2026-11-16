#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

string ReadAText(string Message)
{
	string TextMessage = "";
	cout << Message << endl;
	cin >> TextMessage;
	return TextMessage;
}

string EncryptionText(string Message, short EncryptionKey)
{
	for (int j = 0; j <= Message.length(); j++)
	{
		Message[j] = char((int)Message[j] + EncryptionKey);
	}
	return Message;
}

string DecryptionText(string Message, short EncryptionKey)
{
	for (int j = 0; j <= Message.length(); j++)
	{
		Message[j] = char((int)Message[j] - EncryptionKey);
	}
	return Message;
}

int main()
{
	const short EncryptionKey = 2;
	string Message = ReadAText("Input");
	string AfterEncryption = EncryptionText(Message, EncryptionKey);
	string AfterDecryption = DecryptionText(AfterEncryption, EncryptionKey);
	cout << "Output" << endl;
	cout << "Text Before Encryption: " << Message<<endl;
	cout << "Text After Encryption: " << AfterEncryption << endl;
	cout << "Text After Decryption: " << AfterDecryption << endl;
	_getch();
	return 0;
}

