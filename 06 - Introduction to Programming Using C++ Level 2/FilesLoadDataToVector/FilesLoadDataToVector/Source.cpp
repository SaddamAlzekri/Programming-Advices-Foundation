#include<iostream>
#include<conio.h>
#include<vector>
#include<fstream>
#include<string>
using namespace std;

void FileContent(string FileName, vector <string> &vFileContent)
{
	fstream Myfile;
	Myfile.open(FileName, ios::in);

	if (Myfile.is_open())
	{
		string Line;
		while (getline(Myfile, Line))
		{
			vFileContent.push_back(Line);
		}
		Myfile.close();
	}
}

int main()
{
	vector <string> vFileContent;
	string FileName = "D:\MyFile.txt";
	FileContent(FileName, vFileContent);

	for (string &vConytent : vFileContent)
	{
		cout << vConytent << endl;
	}
	_getch();
	return 0;
}