#include<iostream>
#include<conio.h>
#include "clsDblLinkedList.h"
using namespace std;

int main()
{
	clsDblLinkedList<int>  DblLinkedList;

	DblLinkedList.insertBegining(3);
	DblLinkedList.insertBegining(2);
	DblLinkedList.insertBegining(1);
	DblLinkedList.insertBegining(0);

	DblLinkedList.PrintList();

	clsDblLinkedList<int>::Node *N = DblLinkedList.Find(2);
	DblLinkedList.DeleteNode(N);
	DblLinkedList.PrintList();

	_getch();
	return 0;                           
}