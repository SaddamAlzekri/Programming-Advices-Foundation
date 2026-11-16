#include<iostream>
#include<vector>
#include<conio.h>
#include<string>
using namespace std;

struct sDate
{
	short Day = 0;
	short Month = 0;
	short Year = 0;
};

string ReplaceBeteenStringDigit(string String, string ReplaceTo, string Str)
{
	short
 pos = String.find(Str);

	while (pos != std::string::npos)
	{
		String = String.replace(pos, Str.length(), ReplaceTo);
		pos = String.find(Str);
	}
	
	return String;
}

string FormateDate(sDate Date, string ReplaceString)
{
	string FormatedDate = "";
	FormatedDate = ReplaceBeteenStringDigit(ReplaceString, to_string(Date.Day), "dd");
	FormatedDate = ReplaceBeteenStringDigit(FormatedDate, to_string(Date.Month), "mm");
	FormatedDate = ReplaceBeteenStringDigit(FormatedDate, to_string(Date.Year), "yyyy");

	return FormatedDate;
}

vector<string> SplitString(string Str, string Delim)
{
	vector<string> String;
	short Pos = 0;
	string sWord = "";

	while ((Pos = Str.find(Delim)) != std::string::npos)
	{
		sWord = Str.substr(0, Pos);

		if (sWord != "")
		{
			String.push_back(sWord);
		}
		Str.erase(0, Pos + Delim.length());
	}
	if (Str != "")
		String.push_back(Str);

	return String;
}

sDate StringToDigit(string Str)
{
	sDate Date;
	vector<string>  String = SplitString(Str, "/");

	Date.Day = stoi(String[0]);
	Date.Month = stoi(String[1]);
	Date.Year = stoi(String[2]);

	return Date;
}

string ReadDate(string Message)
{
	string Str;
	cout << Message;
	getline(cin >> ws, Str);

	return Str;
}

int main()
{
	string Str = ReadDate("Please Enter Date dd/mm/yyy? ");

	sDate Date = StringToDigit(Str);

	cout << FormateDate(Date, "yyyy/dd/mm") << endl;
	cout << FormateDate(Date, "mm/dd/yyyy") << endl;
	cout << FormateDate(Date, "mm-dd-yyyy") << endl;
	cout << FormateDate(Date, "dd-mm-yyyy") << endl;

	cout << FormateDate(Date, "Day: dd, Month: mm, Year: yyyy") << endl;

	_getch();
	return 0;
}