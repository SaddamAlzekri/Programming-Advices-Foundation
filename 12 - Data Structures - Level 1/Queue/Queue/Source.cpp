#include<iostream>
#include<queue>
#include<conio.h>
using namespace std;

int main()
{
	queue <int> qNumber1;
	queue <int> qNumber2;


	qNumber1.push(10);
	qNumber1.push(20);
	qNumber1.push(30);
	qNumber1.push(40);
	qNumber1.push(50);

	qNumber2.push(100);
	qNumber2.push(200);
	qNumber2.push(300);
	qNumber2.push(400);
	qNumber2.push(500);

	qNumber1.swap(qNumber2);

	cout << "The count Elements is :\t" << qNumber1.size() << endl;
	cout << "The Elements is :\t";

	while (!qNumber1.empty())
	{
		cout << qNumber1.front() << "\t";
		qNumber1.pop();	
	}

	cout << "\nThe count Elements is :\t" << qNumber2.size() << endl;
	cout << "The Elements is :\t";

	while (!qNumber2.empty())
	{
		cout << qNumber2.front() << "\t";
		qNumber2.pop();
	}

	_getch();
	return 0;
}