#include<iostream>
#include<conio.h>
#include "clsQueueLine.h"
using namespace std;

int main()
{
	clsQueueLine QueueLine("A0", 10);

	QueueLine.IssueTicket();
	QueueLine.IssueTicket();

	QueueLine.PrintInfo();

	QueueLine.PrintTicketLineLTR();
	QueueLine.PrintTicketLineRTL();

	QueueLine.PrintAllTicket();

	QueueLine.ServedNextClient();
	_getch();
	return 0;
}