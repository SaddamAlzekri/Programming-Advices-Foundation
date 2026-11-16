#include<iostream>
#include<conio.h>
using namespace std;

class Node
{
public:
	int value;
	Node *Next;
	Node *Prev;
};

void  insertatBegining(Node *&head, int value)
{
	Node *newNode = new Node;
	newNode->value = value;

	newNode->Next = head;
	newNode->Prev = NULL;
	head = newNode;
	return;
}

Node *Find(Node *head, int value)
{
	while (head != NULL)
	{
		if (head->value == value)
			return head;

		head = head->Next;
	}
}

void insertNode(Node *&Current, int value)
{
	Node *newNode = new Node;
	newNode->value = value;

	if (Current == NULL) return;
	
	newNode->Next = Current->Next;
	newNode->Prev = Current;

	if (Current->Next != NULL)
		Current->Next->Prev = newNode;
	
	Current->Next = newNode;
}

void insertEnd(Node *&head, int value)
{
	Node *newNode = new Node;
	newNode->value = value;
	newNode->Next = NULL;

	Node *Current = head;
	if (Current == NULL)
		insertatBegining(head, value);

	while (Current->Next != NULL)
	{
		Current = Current->Next;
	}

	Current->Next = newNode;
	newNode->Prev = Current;
}

void DeleteNode(Node *&head, int value)
{
	Node *PrevNode = head, *Current = head;

	if (head == NULL) return;

	if (head->value == value)
	{

		head = head->Next;
		if (head != NULL)
			head->Prev = NULL;
		delete Current;
		return;
	}

	while (Current->value != value)
	{
		PrevNode = Current;
		Current = Current->Next;
	}

	PrevNode->Next = Current->Next;
	if (Current->Next != NULL)
		Current->Next->Prev = PrevNode;
	
	delete Current;
	return;
}

void DeleteBegining(Node *&head)
{
	if (head == NULL) return;

	Node *Current = head;

	head = head->Next;
	if (head != NULL)
		head->Prev = NULL;
	delete Current;
	return;
}

void DeleteEnd(Node *&head)
{
	Node *Current = head, *Temp = head;
	if (head == NULL) return;

	if (head->Next == NULL)
		DeleteBegining(head->Next);

	while (Current->Next != NULL)
	{
		Temp = Current;
		Current = Current->Next;
	}

	Temp->Next = NULL;
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
	insertatBegining(head, 3);
	Node *N = Find(head, 3);
	insertNode(N, 4);
	DeleteNode(head, 3);
	insertEnd(head, 5);
//	DeleteBegining(head);
	DeleteEnd(head);

	Print(head);
	_getch();
	return 0;
}