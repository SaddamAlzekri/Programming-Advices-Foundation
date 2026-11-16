//#include<iostream>
//#include<conio.h>
//using namespace std;
//
//class  Node
//{
//public:
//	int value;
//	Node *Next;
//};
//
//void Insert(Node *&head, int value)
//{
//	Node *newNode = new Node;
//	newNode->value = value;
//
//	newNode->Next = head;
//	head = newNode;
//}
//
//Node *Find(Node *head, int value)
//{
//	while (head != NULL)
//	{
//		if (head->value == value)
//			return head;
//
//		head = head->Next;
//	}
//	return NULL;
//}
//
//void InsertAt(Node *&head, int value)
//{
//	Node *newNode = new Node;
//	newNode->value = value;
//
//	newNode->Next = head->Next;
//	head->Next = newNode;
//	
//	return;
//}
//
//void InsertEnd(Node *head, int value)
//{
//	Node * newNode = new Node;
//
//	newNode->value = value;
//	newNode->Next = NULL;
//
//	Node *LastNode = head;
//	while (LastNode->Next != NULL)
//	{
//		LastNode = LastNode->Next;
//	}
//	LastNode->Next = newNode;
//}
//
//void Print(Node* head)
//{
//	while (head != NULL)
//	{
//		cout << head->value << "\t";
//		head = head->Next;
//	}
//	cout << endl;
//}
//
//void Delete(Node *&head, int value)
//{
//	Node *Current = head, *Prev = head;
//
//	if (head == NULL)
//	{
//		return;
//	}
//
//	if (Current->value == value)
//	{
//		head = Current->Next;
//		delete Current;
//		return;
//	}
//
//	while (Current != NULL && Current->value != value)
//	{
//		Prev = Current;
//		Current = Current->Next;
//	}
//
//	if (Current == NULL) return;
//
//	Prev->Next = Current->Next;
//	delete Current;
//}
//
//void DeleteStart(Node *&head)
//{
//	Node *Current = head;
//
//	head = Current->Next;
//	delete Current;
//	return;
//}
//
//void DeleteEnd(Node *&head)
//{
//	Node *Prev = head, *Current = head;
//
//	while (Current->Next != NULL)
//	{
//		Prev = Current;
//		Current = Current->Next;
//	}
//
//	Prev->Next = NULL;
//	delete Current;
//	return;
//
//}
//
//int main()
//{
//	Node *head = NULL;
//
//	Insert(head, 3);
//	Insert(head, 2);
//	Insert(head, 1);
//
//	Node *N = Find(head, 3);
//	InsertAt(N, 4);
//	N = Find(head, 4);
//	InsertAt(N, 5);
//	InsertEnd(head, 6);
//	Print(head);
//
//	DeleteStart(head);
//	Delete(head, 3);
//	DeleteEnd(head);
//	Delete(head, 5);
//	Print(head);
//
//	_getch();
//	return 0;
//}
#include<iostream>
#include<conio.h>
using namespace std;

class Node
{
public:
	int value;
	Node *Next;
};

void Insertstart(Node *&head, int value)
{
	Node *newNode = new Node;
	newNode->value = value;

	newNode->Next = head;
	head = newNode;
}

Node *Find(Node *&head, int value)
{
	Node *Current = head;
	while (Current != NULL)
	{
		if (Current->value == value)
			return Current;

		Current = Current->Next;
	}
	return NULL;
}

void insertNode(Node *head, int value)
{
	Node *newNode = new Node;
	newNode->value = value;

	Node *Current = head;

	newNode->Next = Current->Next;
	Current->Next = newNode;
	return;
}

void insertEnd(Node *head, int value)
{
	Node *newNode = new Node;
	newNode->value = value;
	newNode->Next = NULL;

	Node *Current = head;
	while (Current->Next != NULL)
	{
		Current = Current->Next;
	}

	Current->Next = newNode;
	return;
}

void DeleteNode(Node *&head, int value)
{
	Node *Prev = head, *Current = head;

	if (head == NULL) return;

	if (Current->value == value)
	{
		head = Current->Next;
		delete Current;
		return;
	}

	while (Current != NULL && Current->value != value)
	{
		Prev = Current;
		Current = Current->Next;
	}

	if (Current == NULL) return;

	Prev->Next = Current->Next;
	delete Current;
	return;
}

void Deletestart(Node *&head)
{
	Node *Current = head;

	head = Current->Next;
	delete Current;
	return;

}

void DeleteEnd(Node *head)
{
	Node *Prev = head, *Current = head;
	while (Current->Next != NULL)
	{
		Prev = Current;
		Current = Current->Next;
	}
	
	Prev->Next = NULL;
	delete Current;
	return;
}

void Print(Node *head)
{
	while (head != NULL)
	{
		cout << head->value << "\t";
		head = head->Next;
	}
}

int main()
{
	Node *head = NULL;
	Insertstart(head, 4);
	Insertstart(head, 3);
	Insertstart(head, 2);
	Node *N = Find(head, 4);
	insertNode(N, 5);
	insertEnd(head, 6);
	DeleteNode(head, 2);
	DeleteNode(head, 4);
	DeleteNode(head, 6);
	//Deletestart(head);
	//DeleteEnd(head);
	Print(head);
	_getch();
	return 0;
}