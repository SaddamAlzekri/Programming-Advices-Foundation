#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

enum enGameChoicer{	Stone = 1, Paper = 2, Scissor = 3 };

enum enWinner{	Player1 = 1, Computer = 2, Draw = 3 };

struct stReadInfo
{
	short Round = 0;
	enGameChoicer Player1Choice;
	enGameChoicer ComputerChoice;
	enWinner RoundWinner;
	string WinnerName = "";
};

struct stGameresult
{
	short GameRound = 0;
	short Player1Choice = 0;
	short ComputerChoice = 0;
	short DrawTimes = 0;
	enWinner Winner;
	string WinnerName = "";
};

int RandomNumber(int From, int To)
{
	return rand() % (To - From + 1) + From;
}

enGameChoicer ReadPlayer1Choice()
{
	int Num = 0;
	do
	{
		cout << "Your Choice: [1]:Stone, [2]:Paper, [3]:scissor ?\n";
		cin >> Num;
	} while (Num > 3 || Num < 1);
	return enGameChoicer(Num);
}

enGameChoicer GetComputerChoice()
{
	return enGameChoicer(RandomNumber(1, 3));
}

string WinnerName(enWinner Winner)
{
	string arrWinner[3] = { "Player1", "Computer", "No Winner" };
	return arrWinner[Winner-1];
}

enWinner WhowonTheRounds(stReadInfo stReadInfo)
{
	if (stReadInfo.Player1Choice == stReadInfo.ComputerChoice)
	{
		return enWinner::Draw;
	}

	switch (stReadInfo.Player1Choice)
	{
	case enGameChoicer::Stone:
		if (stReadInfo.ComputerChoice == enGameChoicer::Paper)
		{
			return enWinner::Computer;
		}
		break;
	case enGameChoicer::Scissor:
		if (stReadInfo.ComputerChoice == enGameChoicer::Stone)
		{
			return enWinner::Computer;
		}
		break;
	case enGameChoicer::Paper:
		if (stReadInfo.ComputerChoice == enGameChoicer::Scissor)
		{
			return enWinner::Computer;
		}
		break;
	}
		
	return enWinner::Player1;

}

string GameChoice(enGameChoicer enGameChoicer)
{
	string arrWinner[3] = { "Stone", "Paper", "Scissor" };
	return arrWinner[enGameChoicer - 1];
}

void SetWinnerScreenColor(enWinner Winner)
{
	switch (Winner)
	{
	case enWinner::Player1:
		system("color 2f");
		break;
	case enWinner::Computer:
	{
							   system("color 4f");
							   cout << "\a";
							   break;
	}
		
		
	case enWinner::Draw:
		system("color 6f");
		break;
	}
}

void PrintRoundResults(stReadInfo RoundInfo)
{
	cout << "_____________Round [" << RoundInfo .Round + 1<< "]_____________\n";
	cout << "Player1 Choice : " << GameChoice(RoundInfo.Player1Choice) << endl;
	cout << "Computer Choice: " << GameChoice(RoundInfo.ComputerChoice) << endl;
	cout << "Round Winner   : " << WinnerName(RoundInfo.RoundWinner) << endl;
	cout << "_____________________________________\n";
	SetWinnerScreenColor(RoundInfo.RoundWinner);

}

enWinner WhoWonTheGame(short Player1Choice, short ComputerChoice)
{
	if (Player1Choice > ComputerChoice)
		return enWinner::Player1;
	else if (ComputerChoice > Player1Choice)
		return enWinner::Computer;
	else
		return enWinner::Draw;
}

stGameresult FillGameResults(short HowManyRounds, short Player1Choice, short ComputerChoice, short Draw)
{
	stGameresult Gameresult;
	Gameresult.GameRound = HowManyRounds;
	Gameresult.Player1Choice = Player1Choice;
	Gameresult.ComputerChoice = ComputerChoice;
	Gameresult.DrawTimes = Draw;
	Gameresult.Winner = WhoWonTheGame(Player1Choice, ComputerChoice);
	Gameresult.WinnerName = WinnerName(Gameresult.Winner);

	return Gameresult;
}

stGameresult PlayGame(short HowManyRounds)
{
	stReadInfo stReadInfo;
	short Player1Choice = 0, ComputerChoice = 0, Draw = 0;
	for (int GameRound = 0; GameRound < HowManyRounds; GameRound++)
	{
		cout << "Round [" << GameRound + 1 << "] begins\n";
		stReadInfo.Round = GameRound;
		stReadInfo.Player1Choice = ReadPlayer1Choice();
		stReadInfo.ComputerChoice = GetComputerChoice();
		stReadInfo.RoundWinner = WhowonTheRounds(stReadInfo);
		stReadInfo.WinnerName = WinnerName(stReadInfo.RoundWinner);

		if (stReadInfo.RoundWinner == enWinner::Player1)
			Player1Choice++;
		else if (stReadInfo.RoundWinner == enWinner::Computer)
			ComputerChoice++;
		else
			Draw++;

		PrintRoundResults(stReadInfo);
	}

	return FillGameResults(HowManyRounds, Player1Choice, ComputerChoice, Draw);

}

void ResetScreen()
{
	system("cls");
	system("color 0f");
}

short HowManyRounds()
{
	int Num = 0;
	do
	{
		cout << "How many rounds 1 to 10 ?\n";
		cin >> Num;
	} while (Num > 10|| Num < 1);
	return Num;
}

string Tap(short Length)
{
	string SpaceTab = "";
	for (int i = 0; i < Length; i++)
	{
		SpaceTab = SpaceTab + "    ";
	}
	return SpaceTab;
}

void showGameOverScreean()
{
	cout << "\n" << Tap(2) << "___________________________________________\n";
	cout << Tap(2) << "           +++ G a m e O v e r +++\n";
	cout << "\n" << Tap(2) << "___________________________________________\n";

}

void ShowFinalGameResults(stGameresult Gameresult)
{
	cout << Tap(2) << "_______________[" << "Game Results" << "]_______________\n";
	cout << Tap(2) << "Game Rounds        : " << Gameresult.GameRound << endl;
	cout << Tap(2) << "Player1 won times  : " << Gameresult.Player1Choice << endl;
	cout << Tap(2) << "Computer won times : " << Gameresult.ComputerChoice << endl;
	cout << Tap(2) << "Draw times         : " << Gameresult.DrawTimes << endl;
	cout << Tap(2) << "Final Winner       : " << Gameresult.WinnerName << endl;
	cout << Tap(2) << "______________________________________________\n";

}

void StartGame()
{
	char PlayAgain = 'Y';
	do
	{
		ResetScreen();
		stGameresult stGameresult = PlayGame(HowManyRounds());
		showGameOverScreean();
		ShowFinalGameResults(stGameresult);
		cout <<"\n\n"<<Tap(2) << "Do you want to Play again? Y/N?";
		cin >> PlayAgain;
	} while (PlayAgain == 'Y' || PlayAgain == 'y');
}

int main()
{
	StartGame();
	_getch();
	return 0;
}