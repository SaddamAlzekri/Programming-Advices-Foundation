#include<iostream>
#include<string>
#include<conio.h>
using namespace std;

int main()
{
	string str1 = "43.22";

	cout << stoi(str1) <<endl <<stod(str1)<<endl<<stof(str1)<<endl;
	cout << "###########################.\n";
	int N1 = 20;
	cout << to_string(N1)<<endl;
	double N2 = 33.5;
	cout << to_string(N2)<<endl;
	float N3 = 55.23;
	cout << to_string(N3);
	

	_getch();
	return 0;
}