#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<cstdlib>
using namespace std;

enum enQuestionLevel { Easy = 1, Med = 2, Hard = 3, Mix = 4 };

enum OperationType { Add = 1, Sub = 2, Mul = 3, Div = 4, Mixx = 5 };

struct Gameresult
{
	short NumberOfQuestion = 0;
	int FirstNumber = 0;
	int SecondNumber = 0;
	enQuestionLevel QuestionLevel;
	OperationType Operation;
	char OperationType = '+';
};

struct stBunosInfo
{
	short NumberOfQuestion = 0;
	string QuestionLevel = "";
	string OpType = "";
	short NumberOfRightAnswer = 0;
	short NumberOfWrongAnswer = 0;
};
short HowManyRounds()
{
	int Num = 0;
	do
	{
		cout << "How Many Question do you want to answer. ";
		cin >> Num;
	} while (Num > 10);
	return Num;
}
enQuestionLevel ReadQuestionLevel()
{
	int Num = 0 ;
	do
	{
		cout << "Enter question Level [1] Easy, [2] Med, [3] Hard, [4] Mix ? ";
		cin >> Num;

	} while (Num > 4||Num < 1);
	return enQuestionLevel(Num);
}
OperationType ReadOperation()
{
	int Num = 0;
	do
	{
		cout << "Enter question Level [1] Add, [2] Sub, [3] Mul, [4] Div, [5] Mix ? ";
		cin >> Num;
	} while (Num > 5 || Num < 1);
	return OperationType(Num);
}
int RandomNumber(Gameresult Gameresult)
{
	stBunosInfo BunosInfo;
	switch (Gameresult.QuestionLevel)
	{
	case enQuestionLevel::Easy:
		return rand() % (10 - 1 + 1) + 1;
		break;
	case enQuestionLevel::Med:
		return rand() % (50 - 10 + 1) + 10;
		break;
	case enQuestionLevel::Hard:
		return rand() % (100 - 50 + 1) + 50;
		break;
	case enQuestionLevel::Mix:
		return rand() % (100 - 1 + 1) + 1;
		break;
	}
}
short RandomNumber2()
{
	return rand() % (4 - 1 + 1) + 1;
}
char CharOperation(short GameResult)
{
	char arrOperation[5] = { '+', '-', '*', '/'};
	return arrOperation[GameResult - 1];
}
char CharOperation2(Gameresult &GameResult)
{
	stBunosInfo BunosInfo;
	switch (GameResult.Operation)
	{
	case OperationType::Add:
		return '+';
		break;
	case OperationType::Sub:
		return '-';
		break;
	case OperationType::Mul:
		return '*';
		break;
	case OperationType::Div:
		return '/';
		break;
	case OperationType::Mixx:
		return CharOperation(RandomNumber2());
		break;
	}
}
void TheResultAllExam(stBunosInfo BunosInfo)
{
	cout << "\n___________________________________\n";
	if (BunosInfo.NumberOfRightAnswer > BunosInfo.NumberOfWrongAnswer)
		cout << "Final Result is Successful :-)\n";
	else if (BunosInfo.NumberOfRightAnswer < BunosInfo.NumberOfWrongAnswer)
		cout << "Final Result is Fail :-(\n";
	cout << "\n___________________________________\n";
	cout << "Number of Question    : " << BunosInfo.NumberOfQuestion << endl;
	cout << "Question Level        : " << BunosInfo.QuestionLevel << endl;
	cout << "Optype                : " << BunosInfo.OpType << endl;
	cout << "Number Of Right Answer: " << BunosInfo.NumberOfRightAnswer << endl;
	cout << "Number Of Wrong Answer: " << BunosInfo.NumberOfWrongAnswer << endl;


}
void GetTrueResult(Gameresult Gameresult)
{
	int Result = 0, RealResult = 0;
	stBunosInfo BunosInfo;
	cin >> Result;
	switch (Gameresult.OperationType)
	{
	case '+':
		RealResult = Gameresult.FirstNumber + Gameresult.SecondNumber;
		break;
	case '-':
		RealResult = Gameresult.FirstNumber - Gameresult.SecondNumber;
		break;
	case '*':
		RealResult = Gameresult.FirstNumber * Gameresult.SecondNumber;
		break;
	case '/':
		RealResult = Gameresult.FirstNumber / Gameresult.SecondNumber;
		break;
	}
	if (Result == RealResult)
	{
		system("color 2f");
		cout << "\nRight Answer :-)\n";
	}
	else
	{
		system("color 4f");
		cout << "Wrong Anwer :-(\n";
		cout << "The right answer is: " << RealResult << endl;
	}

}
void MathOperation( Gameresult Gameresult, short HowManyRounds)
{
	cout << "\n\nQuestion [" << Gameresult.NumberOfQuestion + 1<< "/" << HowManyRounds << "]\n\n";
	cout << Gameresult.FirstNumber << endl;
	cout << Gameresult.SecondNumber << "\t" << Gameresult.OperationType << endl;
	cout << "------------------\n";
	GetTrueResult(Gameresult);
}

stBunosInfo FillBunosProject(short HowManyRounds,string QuestionLevel,string OpType)
{
	stBunosInfo BunosInfo;
	Gameresult Gameresult;
	BunosInfo.NumberOfQuestion = HowManyRounds;
	BunosInfo.QuestionLevel = QuestionLevel;
	BunosInfo.OpType = OpType;
	return BunosInfo;
}
stBunosInfo PlayGame(short HowManyRounds)
{
	string QuestionLevel, OpType ;
	Gameresult Gameresult;
	stBunosInfo BunosInfo;
	Gameresult.QuestionLevel = ReadQuestionLevel();
	Gameresult.Operation = ReadOperation();
	BunosInfo.NumberOfQuestion = HowManyRounds;
	for (int i = 0; i < HowManyRounds; i++)
	{
		Gameresult.NumberOfQuestion = i;
		Gameresult.OperationType = CharOperation2(Gameresult);
		Gameresult.FirstNumber = RandomNumber(Gameresult);
		Gameresult.SecondNumber = RandomNumber(Gameresult);
		MathOperation(Gameresult , HowManyRounds);
	}
	if (Gameresult.QuestionLevel == enQuestionLevel::Easy)
		QuestionLevel = "Easy";
	else if (Gameresult.QuestionLevel == enQuestionLevel::Med)
		QuestionLevel = "Med";
	else if (Gameresult.QuestionLevel == enQuestionLevel::Hard)
		QuestionLevel = "Hard";
	else if (Gameresult.QuestionLevel == enQuestionLevel::Mix)
		QuestionLevel = "Mix";

	if (Gameresult.Operation == OperationType::Add)
		OpType = "Add";
	else if (Gameresult.Operation == OperationType::Sub)
		OpType = "Sub";
	else if (Gameresult.Operation == OperationType::Mul)
		OpType = "Mul";
	else if (Gameresult.Operation == OperationType::Div)
		OpType = "Div";
	else if (Gameresult.Operation == OperationType::Mixx)
		OpType = "Mixx";

	return FillBunosProject(HowManyRounds, QuestionLevel, OpType);
	
}

void Restart()
{
	system("color 0f");
	system("cls");
}
void StartGame()
{
	char YesNo = 'Y';
	do
	{
		Restart();
		stBunosInfo BunosInfo = PlayGame(HowManyRounds());
		TheResultAllExam(BunosInfo);
		cout << "Do you want to play again? Y/N?";
		cin >> YesNo;
	} while (YesNo == 'Y' || YesNo == 'y');
}
int main()
{
	srand((unsigned)time(NULL));
	StartGame();
	_getch();
	return 0;
}