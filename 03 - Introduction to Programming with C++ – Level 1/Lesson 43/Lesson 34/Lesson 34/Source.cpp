#include<iostream>
#include<conio.h>
using namespace std;
float PercentageSAles(int TotalSales)
{
	if (TotalSales >= 1000000)
	{
		return (TotalSales*0.01);
	}
	else if (TotalSales >= 500000 && TotalSales <= 1000000)
	{
		return (TotalSales*0.02);
	}
	else if (TotalSales >= 100000 && TotalSales <= 500000)
	{
		return (TotalSales*0.03);
	}
	else if (TotalSales >= 50000 && TotalSales <= 100000)
	{
		return (TotalSales*0.05);
	}
	else if (TotalSales == 0)
	{
		return (TotalSales*0.01);
	}
}
int main()
{
	int TotalSales;
	cout << "Please, enter the TOTALSALES\n";
	cin >> TotalSales;
	cout << "************************\n";
	cout <<"The Percentage is "<<PercentageSAles(TotalSales) << endl;
	_getch();
	return 0;
}