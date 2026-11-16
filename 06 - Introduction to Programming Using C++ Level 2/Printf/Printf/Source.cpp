#include<iostream>
#include<conio.h>
#include<string>
using namespace std;

int main()
{
	int Page = 1,TotalPage = 10;

	printf("The page number = %d \n", Page);
	printf("Your are in page %d of %d \n", Page, TotalPage);
	printf("The page number = %0*d \n", 2, Page);
	printf("The page number = %0*d \n", 3, Page);
	printf("The page number = %0*d \n", 4, Page);
	printf("The page number = %0*d \n", 5, Page);

	int Number1 = 20, Number2 = 30;
	printf("The Resukt of %d + %d = %d \n", Number1, Number2, Number1 + Number2);
	_getch();
	return 0;
}