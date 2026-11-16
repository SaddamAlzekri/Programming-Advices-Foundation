#include<iostream>
#include<conio.h>
#include<vector>
#include<fstream>
#include<string>
using namespace std;

void SaveVectorToFile(string FileName, vector <string> vFileContent)
{
	fstream MyFile;
	MyFile.open(FileName, ios::out);

	if (MyFile.is_open())
	{
		string Line;
		for (string &Line: vFileContent)
		{
			if (Line != "")
			{
				MyFile << Line << endl;
			}
		}
		MyFile.close();
	}

}
int main()
{
	string FileName = "D:\MyFile.txt";
	vector <string> vFileContent{ "Ali", "Maher", "Tareq", "Lame", "Ala" };
	SaveVectorToFile(FileName, vFileContent);
	_getch();
	return 0;
}
