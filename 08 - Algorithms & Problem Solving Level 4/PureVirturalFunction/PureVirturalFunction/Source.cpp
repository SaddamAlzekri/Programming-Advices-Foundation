#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsMobile
{
public:
	virtual void Dial(string PhoneNumber) = 0;
	virtual void SendSMS(string PhoneNumber, string Text) = 0;
	virtual void TakePicture() = 0;
};

class clsPhone : public clsMobile
{
public:
	virtual void SendText(string Text) = 0;

	void Dial(string PhoneNumber)
	{

	};
	void SendSMS(string PhoneNumber, string Text)
	{

	};

	void TakePicture()
	{

	};

};

class clsSumsongNot10 : clsPhone
{
public:
	void SendText(string Text)
	{

	};
};

int main()
{
	clsSumsongNot10 Note10;

	_getch();
	return 0;
}