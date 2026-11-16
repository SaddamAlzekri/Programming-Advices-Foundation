#include<iostream>
#include<conio.h>
#include<string>
#include<time.h>
#include<cstdlib>
using namespace std;
enum enQuestionLevel
{
	EasyLevel = 1, MedLevel = 2, HardLevel = 3, Mix = 4
};

enum enOperationType
{
	Add = 1, Sub = 2, Mul = 3, Div = 4, MixOp = 5
};

struct stQuestion
{
	int Number1 = 0;
	int Number2 = 0;
	enQuestionLevel QuestionLevel;
	enOperationType OperationType;
	int CorrectAnswer = 0;
	int PlayerAnswer = 0;
	bool AnswerResult = 0;
};

struct stQuizz
{
	stQuestion Question[100];
	short NumberOfQuestion = 0;
	enQuestionLevel QuestionLevel;
	enOperationType OperationType;
	int NumberOfRightAnswer = 0;
	int NumberOfWrongeAnswer = 0;
	bool isSuccess = 0;

};

short HowManyQuestion()
{
	int Num = 0;
	do
	{
		cout << "How many Question do you want to answer ? ";
		cin >> Num;

	} while (Num > 100 || Num < 1);
	return Num;
}
enQuestionLevel QuestionLevel()
{
	int Num = 0;
	do
	{
		cout << "Enter Question Level [1] Easy, [2] Med, [3] Hard, [4] Mix ? ";
		cin >> Num;

	} while (Num > 4 || Num < 1);
	return (enQuestionLevel)Num;
}
enOperationType OperationType()
{
	int Num = 0;
	do
	{
		cout << "Enter Operation Type [1] Add, [2] Sub, [3] Mul, [4] Div, [5] Mix ? ";
		cin >> Num;

	} while (Num > 5 || Num < 1);
	return (enOperationType)Num;
}
short RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}
int SimpleCalculator(int Number1, int Number2, enOperationType OperationType)
{
	switch (OperationType)
	{
	case enOperationType::Add:
		return Number1 + Number2;
		break;
	case enOperationType::Sub:
		return Number1 - Number2;
		break;
	case enOperationType::Mul:
		return Number1 * Number2;
		break;
	case enOperationType::Div:
		return Number1 / Number2;
		break;
	default:
		return Number1 + Number2;
		break;
	}
}
stQuestion FillQuestion(enQuestionLevel QuestionLevel, enOperationType OperationType)
{
	stQuestion Question;
	if (QuestionLevel == enQuestionLevel::Mix)
	{
		QuestionLevel = (enQuestionLevel)RandomNumber(1, 3);
	}
	if (OperationType == enOperationType::MixOp)
	{
		OperationType = (enOperationType)RandomNumber(1, 4);
	}

	Question.OperationType = OperationType;

	switch (QuestionLevel)
	{
	case enQuestionLevel::EasyLevel:
		Question.Number1 = RandomNumber(1, 10);
		Question.Number2 = RandomNumber(1, 10);

		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
		Question.QuestionLevel = QuestionLevel;
		return Question;
	case enQuestionLevel::MedLevel:
		Question.Number1 = RandomNumber(10, 50);
		Question.Number2 = RandomNumber(10, 50);

		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
		Question.QuestionLevel = QuestionLevel;
		return Question;
	case enQuestionLevel::HardLevel:
		Question.Number1 = RandomNumber(50, 100);
		Question.Number2 = RandomNumber(50, 100);

		Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OperationType);
		Question.QuestionLevel = QuestionLevel;
		return Question;
	}
	return Question;
}
void FillQuizzQuestion(stQuizz &Quizz)
{
	for (short Question = 0; Question < Quizz.NumberOfQuestion; Question++)
	{
		Quizz.Question[Question] = FillQuestion(Quizz.QuestionLevel, Quizz.OperationType);
	}

}
string GetOpType(enOperationType OpType)
{
	string arrOpType[4] = { "+", "-", "*", "/" };
	return arrOpType[OpType - 1];
}
void PrintQuestion(stQuizz Quizz, short Question)
{
	cout << "\n\nQuestion [" << Question + 1 << "/" << Quizz.NumberOfQuestion << "]\n\n";
	cout << Quizz.Question[Question].Number1 << endl;
	cout << Quizz.Question[Question].Number2 << "\t";
	cout << GetOpType(Quizz.Question[Question].OperationType) << endl;
	cout << "_______________________\n";
}
int ReadPlayeranswer()
{
	int Num = 0;
		cin >> Num;
		return Num;
}
void SetColor(stQuestion Question)
{
	if (Question.PlayerAnswer == Question.CorrectAnswer)
		system("color 2f");
	else 
		system("color 4f");

}
void CorrectQuestionAnswer(stQuizz& Quizz, short Question)
{
	if (Quizz.Question[Question].CorrectAnswer != Quizz.Question[Question].PlayerAnswer)
	{
		cout << "Wrong Answer :-(\n";
		cout << "The right answer is: " << Quizz.Question[Question].CorrectAnswer << endl;
		Quizz.NumberOfWrongeAnswer++;

		Quizz.Question[Question].AnswerResult = false;
	}
	else
	{
		cout << "Right Answer :-)\n";
		Quizz.NumberOfRightAnswer++;
	}
	cout << endl;
	SetColor(Quizz.Question[Question]);
}
void AskAndCorrectQustionanswer(stQuizz& Quizz)
{
	for (short Question = 0; Question < Quizz.NumberOfQuestion; Question++)
	{
		PrintQuestion(Quizz, Question);
		Quizz.Question[Question].PlayerAnswer = ReadPlayeranswer();
		CorrectQuestionAnswer(Quizz, Question);
		
	}
}
string QuestionLevel2(enQuestionLevel QueLevel)
{
	string arrQuesLevel[4] = { "EasyLevel", "MedLevel", "HardLevel", "Mix" };
	return arrQuesLevel[QueLevel - 1];
}
string OperationType2(enOperationType OperationType)
{
	string arrQuesLevel[5] = { "Add", "Sub", "Mul", "Div", "Mix" };
	return arrQuesLevel[OperationType - 1];
}
string SeccessOrFail(stQuizz Quizz)
{
	if (Quizz.NumberOfRightAnswer > Quizz.NumberOfWrongeAnswer)
		return "Final Results is Seccess :-)";
	else
		return "Final Results is Fail :-(";
}
void PrintGames(stQuizz Quizz)
{
	cout << "\n___________________________________\n";
	cout << SeccessOrFail(Quizz);
	cout << "\n___________________________________\n";
	cout << "Number of Questions     : " << Quizz.NumberOfQuestion << endl;
	cout << "Question Level          : " << QuestionLevel2(Quizz.QuestionLevel) << endl;
	cout << "OpType                  : " << OperationType2(Quizz.OperationType) << endl;
	cout << "Number of Right Answer  : " << Quizz.NumberOfRightAnswer << endl;
	cout << "Number of Wrong Answer  : " << Quizz.NumberOfWrongeAnswer << endl;
	cout << "\n___________________________________\n";
}
void PlayMathGame()
{
	stQuizz Quizz;
	Quizz.NumberOfQuestion = HowManyQuestion();
	Quizz.QuestionLevel = QuestionLevel();
	Quizz.OperationType = OperationType();

	FillQuizzQuestion(Quizz);
	AskAndCorrectQustionanswer(Quizz);
	PrintGames(Quizz);
}
void ReStart()
{
	system("cls");
	system("color 0f");
}
void StartGame()
{
	char PlayYN = 'Y';
	do
	{
		ReStart();
		PlayMathGame();
		cout << "\n\nDo you want to play again? Y/N? ";
		cin >> PlayYN;
	} while (PlayYN == 'Y' || PlayYN == 'y');
}
int main()
{
	srand((unsigned)time(NULL));
	StartGame();

	_getch();
	return 0;
}