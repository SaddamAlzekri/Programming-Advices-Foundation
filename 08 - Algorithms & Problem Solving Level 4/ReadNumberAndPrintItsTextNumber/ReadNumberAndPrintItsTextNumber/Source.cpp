#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int ReadNumber()
{
	double Num;
	cout << "Please enter Any Number?\n";
	cin >> Num;
	return Num;
}

string NumberToText(int Number)
{
	string arrNum[] = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "sixteen", "Seventeen", "Eighteen", "Nineteen" };

	string arrNum2[] = { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "sixty", "Seventy", "Eighty", "Ninty" };

	if (Number == 0)
	{
		return "";
	}
	if (Number >= 1 && Number < 20)
	{
		return arrNum[Number] + " ";
	}
	if (Number >= 20 && Number <= 99)
	{
		return arrNum2[Number / 10] + " " + NumberToText(Number % 10);
	}
	if (Number >= 100 && Number <= 199)
	{
		return "One Hundred " + NumberToText(Number % 100);
	}
	if (Number >= 200 && Number <= 999)
	{
		return  NumberToText(Number / 100) +"Hundred " + NumberToText(Number % 100);
	}
	if (Number >= 1000 && Number <= 1999)
	{
		return   " One Thuosand " + NumberToText(Number % 1000);
	}
	if (Number >= 2000 && Number <= 999999)
	{
		return  NumberToText(Number / 1000) + "Thuosand " + NumberToText(Number % 1000);
	}
	if (Number >= 1000000 && Number <= 1999999)
	{
		return   " One Million " + NumberToText(Number % 1000000);
	}
	if (Number >= 2000000 && Number <= 999999999)
	{
		return  NumberToText(Number / 1000000) + "Million " + NumberToText(Number % 1000000);
	}
	if (Number >= 1000000000 && Number <= 1999999999)
	{
		return   " One Billion " + NumberToText(Number % 1000000000);
	}
	else
	{
		return  NumberToText(Number / 1000000000) + "Million " + NumberToText(Number % 1000000000);
	}
}

int main()
{
	cout << NumberToText(ReadNumber());

	_getch();
	return 0;
}