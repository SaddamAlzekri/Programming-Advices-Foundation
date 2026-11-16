#pragma once

#include <iostream>
#include <stack>
#include <string>
#include <string.h>
using namespace std;

template <class T>
class clsString
{
	stack<string> _Undo;
	stack<string> _Redo;
	string _Value = "";

public:
	//string Value = "";


	void Set(string value)
	{
		_Undo.push(_Value);
		_Value = value;
	}

	string Get()
	{
		return _Value;
	}

	_declspec(property(get = Get, put = Set)) string Value;

	void Undo()
	{
		if (!_Undo.empty())
		{
			_Redo.push(_Value);
			_Value = _Undo.top();
			_Undo.pop();
		}
	}

	void Redo()
	{
		if (!_Redo.empty())
		{
			_Undo.push(_Value);
			_Value = _Redo.top();
			_Redo.pop();
		}
	}

};

