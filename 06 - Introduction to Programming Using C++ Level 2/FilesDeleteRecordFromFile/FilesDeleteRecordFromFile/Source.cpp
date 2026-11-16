#include<iostream>
#include<conio.h>
#include<vector>
#include<fstream>
#include<string>
using namespace std;
void LoadDataFromFileToVector(string FileName, vector <string> &vFileContent)
{
	fstream MyFile;
	MyFile.open(FileName, ios::in);
	if (MyFile.is_open())
	{
		string Line;
		while (getline(MyFile, Line))
		{
			if (Line != "")
			{
				vFileContent.push_back(Line);
			}
		}
		MyFile.close();
	}
}

void saveVectorToFile(string FileName, vector <string> vFileContent)
{
	fstream Myfile;
	Myfile.open(FileName, ios::out);
	if (Myfile.is_open())
	{
		for (string &Line: vFileContent)
		{
			Myfile << Line << endl;
		}
		Myfile.close();
	}
}
void DeleteRecordeFromFile(string FileName, string Record, string UpdateTo)
{
	vector <string> vFileContent;
	LoadDataFromFileToVector(FileName, vFileContent);
	for (string &Line : vFileContent)
	{
		if (Line == Record)
		{
			Line = UpdateTo;
		}
	}
	saveVectorToFile(FileName, vFileContent);
}

void PrintFileContent(string FileName)
{
	fstream MyFile;
	MyFile.open(FileName, ios::in);
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
	string FileName = "D:\MyFile.txt";
	cout << "File Content Befor Delete.\n\n";
	PrintFileContent(FileName);

	DeleteRecordeFromFile(FileName, "Ali", "Omar");

	cout << "\nFile Content After Delete.\n\n";
	PrintFileContent(FileName);

	_getch();
	return 0;
}