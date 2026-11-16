#include<iostream>
#include<conio.h>
#include<string>
using namespace std;
enum enDayOfWeek
{
	Sunday = 1,
	Monday = 2,
	Tuesday = 3,
	Wednesday = 4,
	Thursday = 5,
	Friday = 6,
	Satuerday = 7

};

int ReadPositiveNuber(string Message, int From, int To)
{
	int Num;
	do
	{
		cout << Message << endl;
		cin >> Num;

	} while (Num < From || Num > To);
	return Num;
}

enDayOfWeek DayOfWeek()
{
	return (enDayOfWeek)ReadPositiveNuber("Please Enter Number Of Day.", 0, 8);
}

string PrintDayOfWeek(enDayOfWeek NumberOfday)
{
	string Message = "Please Enter Arrange Number Between 1-7 ";
	switch (NumberOfday)
	{
	case enDayOfWeek::Sunday:
		return "Sunday";
		break;
	case enDayOfWeek::Monday:
		return "Monday";
		break;
	case  enDayOfWeek::Tuesday:
		return "Thursday";
		break;
	case enDayOfWeek::Wednesday:
		return "Wednesday";
		break;
	case enDayOfWeek::Thursday:
		return "Thursday";
		break;
	case enDayOfWeek::Friday:
		return "Friday";
		break;
	case enDayOfWeek::Satuerday:
		return "Satuerday";
	default:
		return Message;
		break;
	}
}

int main()
{
	cout<<PrintDayOfWeek(DayOfWeek());
	_getch();
	return 0;
}