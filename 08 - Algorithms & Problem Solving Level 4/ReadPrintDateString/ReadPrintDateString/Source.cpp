#include<iostream>
#include<conio.h>
#include<string.h>
#include<string>
using namespace std;

struct sDate
{
	short Day = 0;
	short Month = 0;
	short Year = 0;
};

string ReadDate()
{
	string Date;
	cout << "Please Enter Date dd/mm/yyyy? ";
	getline(cin >> ws, Date);

	return Date;
}

sDate StringToDigit(sDate Date, string Delim, string Str)
{
	short Pos = 0, Num = 0, Counter = 0;
	string sWord = "";

	while ((Pos = Str.find(Delim)) != std::string::npos)
	{
		sWord = Str.substr(0, Pos);
		if (sWord != "" && Counter == 0)
		{
			Date.Day = stoi(sWord);
		}
		if (sWord != "" && Counter == 1)
		{
			Date.Month = stoi(sWord);
		}
		sWord = "";
		Counter++;
		Str.erase(0, Pos + Delim.length());
	}

	if (Str != "")
	{
		Date.Year = stoi(Str);
	}
	return Date;
}

string DigitToString(sDate Date)
{
	string Str = to_string(Date.Day) + "/";
	Str += to_string(Date.Month) + "/";
	Str += to_string(Date.Year);

	return Str;
}

int main()
{
	sDate Date;
	string Str = ReadDate();
	Date = StringToDigit(Date, "/", Str);

	cout << "\nDay  : " << Date.Day << endl;
	cout << "Month: " << Date.Month << endl;
	cout <<"Year  :"<<Date.Year << endl;

	cout << "\nYou Entered: " << DigitToString(Date) << endl;

	_getch();
	return 0;
}