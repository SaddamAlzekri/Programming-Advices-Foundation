#include<iostream>
#include<stack>
#include<conio.h>
using namespace std;

int main()
{
	stack<int> stkNumber1;
	stack<int> stkNumber2;

	stkNumber1.push(10);
	stkNumber1.push(20);
	stkNumber1.push(30);
	stkNumber1.push(40);
	stkNumber1.push(50);

	stkNumber2.push(60);
	stkNumber2.push(70);
	stkNumber2.push(80);
	stkNumber2.push(90);
	stkNumber2.push(100);

	stkNumber1.swap(stkNumber2);

	cout << "The count of Elements :  " << stkNumber1.size() << endl;
	cout << "Elements of stack1 :\t";

	while (!stkNumber1.empty())
	{
		cout << stkNumber1.top() << "\t";

		stkNumber1.pop();
	}

	cout << "\nThe count of Elements :  " << stkNumber2.size() << endl;
	cout << "Elements of stack2 :\t";

	while (!stkNumber2.empty())
	{
		cout << stkNumber2.top() << "\t";

		stkNumber2.pop();
	}

	_getch();
	return 0;
}