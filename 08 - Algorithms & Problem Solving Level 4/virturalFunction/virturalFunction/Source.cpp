#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

class clsPerson
{
public:
	virtual void Print()
	{
		cout << "Hi, I'm a person.\n";
	}
};

class clsEmployee : public clsPerson
{
public:
	void Print()
	{
		cout << "Hi, I'm a Employee.\n";
	}
};

class clsStudent : public clsPerson
{
public:
	void Print()
	{
		cout << "Hi, I'm a student.\n";
	}
};


int main()
{
	clsEmployee Employee1;
	clsStudent Student1;

	//Early-static Binding :-) is Meaning to know the address befor the run of program.
	Employee1.Print();
	Student1.Print();
	
	clsPerson *Person1 = &Employee1;
	clsPerson *Person2  = &Student1;

	//Late-Dynamic Binding :-) is Meaning to know the address after the run of program.
	Person1->Print();
	Person2->Print();

	_getch();
	return 0;
}