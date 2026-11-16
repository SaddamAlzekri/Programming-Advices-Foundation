#include<iostream>
#include<string>
#include<vector>
#include<conio.h>
using namespace std;

struct sDate
{
	short Day;
	short Month;
	short Year;
};

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
	vector<string> String = SplitString(Str, "/");
	sDate Date;

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

string DigitToString(sDate Date)
{
	return (to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year));
}
int main()
{

	string Str = ReadDate("Please Enter Date dd/mm/yyy? ");
	sDate Date = StringToDigit(Str);

	cout << "\nDay   : " << Date.Day << endl;
	cout << "Month : " << Date.Month << endl;
	cout << "Year  : " << Date.Year << endl;

	cout << "\n\nYour Entered: " << DigitToString(Date) << endl;
	_getch();
	return 0;

}