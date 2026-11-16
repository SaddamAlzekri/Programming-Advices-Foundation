#pragma once
#include<iostream>
#include<string>
using namespace std;

namespace MyLibrary
{
	string ReadName()
	{
		string MyName;
		cout << "Enter Your name Please!!!" << endl;
		cin >> MyName;
		return MyName;
	}

	enum CharactorType
	{
		Add = 1, sub = 2, Mul = 3, Div = 4
	};

	CharactorType ChoiceCharactorType()
	{

		int Number;
		do
		{
			cout << "\n\'+\' Enter Number 1\n";
			cout << "\'-\' Enter Number 2\n";
			cout << "\'*\' Enter Number 3\n";
			cout << "\'/\' Enter Number 4\n\n";
			cin >> Number;
		} while (Number > 4 || Number < 1);
		return (CharactorType)Number;
	}

	int simpleCalculator(CharactorType Charactor, float Num1, float Num2)
	{
		switch (Charactor)
		{
		case CharactorType::Add:
			return Num1 + Num2;
		case CharactorType::sub:
			return Num1 - Num2;
		case CharactorType::Mul:
			return Num1 * Num2;
		case CharactorType::Div:
			return Num1 / Num2;
		default:
			return Num1 + Num2;
		}
	}
}