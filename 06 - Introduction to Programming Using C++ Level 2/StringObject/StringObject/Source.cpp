#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	string s = "I am Saddam Al-zekri, I love Programming and Cyper security.";

	cout << s.length() << endl;
	
	for (int i = 5; i < 20; i++)
	{
		cout << s.at(i);
	}

	cout << endl;
	s.append("I donot love in Hospital");
	cout << s << endl;

	s.insert(11, " Hussein");
	cout << s << endl;
	 
	cout << endl;
	cout << s.substr(5, 6) << endl;

	s.push_back('x');
	cout << s << endl;

	s.pop_back();
	cout << s << endl;

	cout << s.find("Saddam") << endl;
	if (s.find("Ali") == s.npos)
	{
		cout << "ali is not found";
	}
	_getch();
	return 0;
}
