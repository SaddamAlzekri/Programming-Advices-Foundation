#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	char Name[] = "I am Saddam Hussein Al-zekri";
	char SchoolName[] = "ArabSecure";

	//Print String
	printf("Dear %s, How are you\n?", Name);
	printf("Wellcom to %s School\n\n", Name);

	//Print Character
	char C = 'S';
	printf("Setting the width of C:%*C \n", 1, C);
	printf("Setting the width of C:%*C \n", 2, C);
	printf("Setting the width of C:%*C \n", 3, C);
	printf("Setting the width of C:%*C \n", 4, C);
	printf("Setting the width of C:%*C \n", 5, C);

	_getch();
	return 0;
}