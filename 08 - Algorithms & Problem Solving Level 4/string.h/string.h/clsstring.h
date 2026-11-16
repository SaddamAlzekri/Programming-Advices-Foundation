#pragma once
#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsstring
{
private:
	string _value;
public:
	clsstring()
	{
		_value = "";
	}
	clsstring(string value)
	{
		_value = value;
	}

	void SetValue(string value)
	{
		_value = value;
	}

	string Getvalue()
	{
		return _value;
	}
	
	__declspec(property(get = Getvalue, put = SetValue)) string value;

	int countWord(string S1)
	{
		int Pos = 0;
		string sWord;
		string Delim = " ";
		int Counter = 0;
		while ((Pos = S1.find(Delim)) != std::string::npos)
		{
			sWord = S1.substr(0, Pos);

			if (sWord != "")
			{
				Counter++;
			}

			S1.erase(0, Pos + Delim.length());
		}

		if (S1 != "")
		{
			Counter++;
		}
		return Counter;
	}
};

