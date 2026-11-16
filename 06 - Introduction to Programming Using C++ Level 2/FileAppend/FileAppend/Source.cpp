#include<iostream>
#include<conio.h>
#include<fstream>
#include<string>
using namespace std;

void PrintFileContent(string FileNeme)
{
	fstream MyFile;

	MyFile.open(FileNeme, ios::in);

	
	if (MyFile.is_open())
	{
		string Line;

		while (getline(MyFile, Line))
		{
			cout << Line << endl;
		}

		MyFile.close();
	}
}

int main()
{
	string FileNeme = "D:\MyFile.txt";

	PrintFileContent(FileNeme);
	
	_getch();
	return 0;
}
 