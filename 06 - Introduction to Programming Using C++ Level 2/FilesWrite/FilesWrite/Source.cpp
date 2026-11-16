#include<iostream>
#include<conio.h>
#include<fstream>
using namespace std;

int main()
{
	fstream myFile;
	myFile.open("D:\MyFile.txt", ios::out);
	
	if (myFile.is_open())
	{
		myFile << "I am Saddam Al - zekri.I am From Yemen.\n";
		myFile << "I am Programming. I love My work.\n";
		myFile << "I love to learn cyper security.\n";
		myFile << "See you later.\n";
		myFile.close();
	}

	_getch();
	return 0;
}