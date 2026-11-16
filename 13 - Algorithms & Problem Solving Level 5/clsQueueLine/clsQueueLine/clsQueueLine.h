//#pragma once
//#include <iostream>
//#include <string>
//#include <string.h>
//#include <vector>
//#include "clsDate.h"
//using namespace std;
//
//class clsQueueLine
//{
//protected:
//
//	struct stQueueInfo
//	{
//		string _Prefix = "";
//		int _TotalTickets = 0;
//		int _ServedClient = 0;
//		int _WaitingClients = 0;
//	};
//
//	struct stTicketinfo
//	{
//		string _NameOfTicket = "";
//		string _Time = "";
//		int _waintingClients = 0;
//		int _RestTime = 0;
//	};
//
//	stQueueInfo QueueInfo;
//	stTicketinfo Ticketinfo;
//	vector <stTicketinfo> vTicketinfo;
//	vector <stTicketinfo> vTicketinfo2;
//	clsDate Date;
//	int _TicketCount = 1;
//	int _RestTime = 0;
//	int _MinuteCount = 0;
//
//public:
//
//	clsQueueLine(string Prefix, int MinuteCount)
//	{
//		QueueInfo._Prefix = Prefix;
//		_MinuteCount = MinuteCount;
//	}
//
//	void PrintInfo()
//	{
//		cout << "\t\t\t_______________________________\n";
//		cout << "\t\t\tQueue Info\n";
//		cout << "\t\t\t_______________________________\n";
//		cout << "\t\t\tPrefix           = " << QueueInfo._Prefix << endl;
//		cout << "\t\t\tTotal Tickets    = " << QueueInfo._TotalTickets << endl;
//		cout << "\t\t\tServed Clients   = " << QueueInfo._ServedClient << endl;
//		cout << "\t\t\tWaiting Clients  = " << QueueInfo._WaitingClients << endl;
//		cout << "\t\t\t_______________________________\n\n";
//	}
//
//	void IssueTicket()
//	{
//		Ticketinfo._NameOfTicket = QueueInfo._Prefix + "" + to_string(_TicketCount);		_TicketCount++;
//		Ticketinfo._Time = Date.GetSystemDateTimeString();
//		Ticketinfo._waintingClients = vTicketinfo.size() - 1;
//		Ticketinfo._RestTime = (_MinuteCount * _RestTime);		_RestTime++;
//
//		vTicketinfo.push_back(Ticketinfo);
//
//		QueueInfo._TotalTickets = vTicketinfo.size();
//		QueueInfo._WaitingClients = vTicketinfo.size();
//
//	}
//
//	void PrintTicketLineLTR()
//	{
//		cout << "\t\t\t";
//		int count = 0;
//
//		for (stTicketinfo &Ticketinfo : vTicketinfo)
//		{
//			cout <<Ticketinfo._NameOfTicket << "<------";
//		}
//		cout << "\n";
//	}
//
//	void PrintTicketLineRTL()
//	{
//		vTicketinfo2 = vTicketinfo;
//
//		int left = 0;
//		int right = vTicketinfo.size() - 1;
//		
//		cout << "\t\t\t";
//
//		while (left<right)
//		{
//			swap(vTicketinfo2[left], vTicketinfo2[right]);
//			left++;
//			right--;
//		}
//
//		for (stTicketinfo &Ticketinfo : vTicketinfo2)
//		{
//			cout << "------>" << Ticketinfo._NameOfTicket;
//		}
//		cout << "\n\n";
//	}
//
//	void ServedNextClient()
//	{
//		vTicketinfo.pop_back();
//		QueueInfo._ServedClient += 1;
//		QueueInfo._WaitingClients = (QueueInfo._TotalTickets - QueueInfo._ServedClient);
//	}
//
//	void PrintAllTicket()
//	{
//
//		for (stTicketinfo &Ticketinfo : vTicketinfo)
//		{
//			cout << "\t\t\t         ---Tickets---\n";
//			cout << "\t\t\t_______________________________\n";
//			cout << "\t\t\t             " << Ticketinfo._NameOfTicket << endl;
//			cout << "\t\t\t" << Ticketinfo._Time << endl;
//			cout << "\t\t\tWaiting Client = " << Ticketinfo._waintingClients << endl;
//			cout << "\t\t\t     Serve Time In" << "\n\t\t\t     " << Ticketinfo._RestTime << " Mintutes." << endl;
//			cout << "\t\t\t_______________________________\n\n\n";
//
//
//		}
//	}
//
//
//};
//

#pragma once
#include <iostream>
#include <string>
#include <string.h>
#include <queue>
#include <stack>
#include "clsDate.h"
using namespace std;

class clsQueueLine
{
protected:

	struct stQueueInfo
	{
		string _Prefix = "";
		int _TotalTickets = 0;
		int _ServedClient = 0;
		int _WaitingClients = 0;
	};

	struct stTicketinfo
	{
		string _NameOfTicket = "";
		string _Time = "";
		int _waintingClients = -1;
		int _RestTime = 0;
	};

	stQueueInfo QueueInfo;
	stTicketinfo Ticketinfo;
	queue <stTicketinfo> vTicketinfo;
	queue <stTicketinfo> vTicketinfo2;
	stack <stTicketinfo> vTicketinfo3;
	clsDate Date;
	int _TicketCount = 1;
	int _RestTime = 0;
	int _MinuteCount = 0;

public:

	clsQueueLine(string Prefix, int MinuteCount)
	{
		QueueInfo._Prefix = Prefix;
		_MinuteCount = MinuteCount;
	}

	void PrintInfo()
	{
		QueueInfo._WaitingClients = (vTicketinfo.size() - QueueInfo._ServedClient);
		cout << "\t\t\t_______________________________\n";
		cout << "\t\t\tQueue Info\n";
		cout << "\t\t\t_______________________________\n";
		cout << "\t\t\tPrefix           = " << QueueInfo._Prefix << endl;
		cout << "\t\t\tTotal Tickets    = " << QueueInfo._TotalTickets << endl;
		cout << "\t\t\tServed Clients   = " << QueueInfo._ServedClient << endl;
		cout << "\t\t\tWaiting Clients  = " << QueueInfo._WaitingClients << endl;
		cout << "\t\t\t_______________________________\n\n";
	}

	void IssueTicket()
	{
		Ticketinfo._NameOfTicket = QueueInfo._Prefix + "" + to_string(_TicketCount);		_TicketCount++;
		Ticketinfo._Time = Date.GetSystemDateTimeString();
		Ticketinfo._waintingClients += 1;
		Ticketinfo._RestTime = (_MinuteCount * _RestTime);		_RestTime++;

		vTicketinfo.push(Ticketinfo);

		QueueInfo._TotalTickets = vTicketinfo.size();

		QueueInfo._WaitingClients = (vTicketinfo.size() - QueueInfo._ServedClient);
	

	}

	void PrintTicketLineLTR()
	{
		cout << "\t\t\t";
		int count = 0;
		vTicketinfo2 = vTicketinfo;
		for (int i = 0; i <= vTicketinfo2.size(); i++)
		{
			stTicketinfo Ticketinfo = vTicketinfo2.front();
			vTicketinfo3.push(Ticketinfo);
			cout << Ticketinfo._NameOfTicket << "<------";
			vTicketinfo2.pop();
		}
		cout << "\n";
	}

	void PrintTicketLineRTL()
	{
		cout << "\t\t\t";
		int count = 0;
		for (int i = 0; i <= vTicketinfo3.size(); i++)
		{
			stTicketinfo Ticketinfo = vTicketinfo3.top();
			cout << "------>" << Ticketinfo._NameOfTicket ;
			vTicketinfo3.pop();
		}
		cout << "\n";
	}

	void ServedNextClient()
	{
		vTicketinfo.pop();
		QueueInfo._ServedClient += 1;
		cout << ".Pay Bill Queue After serving One Client...\n";
	}

	void PrintAllTicket()
	{
		vTicketinfo2 = vTicketinfo;
		for (int i = 0; i <= vTicketinfo2.size(); i++)
		{
		stTicketinfo Ticketinfo = vTicketinfo2.front();
			cout << "\t\t\t         ---Tickets---\n";
			cout << "\t\t\t_______________________________\n";
			cout << "\t\t\t             " << Ticketinfo._NameOfTicket << endl;
			cout << "\t\t\t" << Ticketinfo._Time << endl;
			cout << "\t\t\tWaiting Client = " << Ticketinfo._waintingClients << endl;
			cout << "\t\t\t     Serve Time In" << "\n\t\t\t     " << Ticketinfo._RestTime << " Mintutes." << endl;
			cout << "\t\t\t_______________________________\n\n\n";

			vTicketinfo2.pop();
		}
	}

};

