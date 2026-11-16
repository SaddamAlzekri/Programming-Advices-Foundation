//#include<iostream>
//#include<conio.h>
//using namespace std;
//
//class Node
//{
//public:
//	int value;
//	Node *Next;
//};
//
//void InsertAtBegining(Node* &head, int Number)
//{
//	Node *NewNode = new Node;
//
//	NewNode->value = Number;
//	NewNode->Next = head;
//	head = NewNode;
//}
//
//void InsertAfter(Node * head, int Number)
//{
//	Node *newNode = new Node;
//	newNode->value = Number;
//
//	newNode->Next = head->Next;
//	head->Next = newNode;
//}
//
//void InsertEnd(Node * &head, int Number)
//{
//	Node *newNode = new Node;
//
//	newNode->value = Number;
//	newNode->Next = NULL;
//
//	if (head == NULL)
//	{
//		head = newNode;
//		return;
//	}
//
//	Node *LastNode = head;
//	
//	while (LastNode->Next != NULL)
//	{
//		LastNode = LastNode->Next;
//	}
//	
//	LastNode->Next = newNode; 
//	return;
//}
//
//void Print(Node* head)
//{
//	while (head != NULL)
//	{
//		cout << head->value << "\t";
//		head = head->Next;
//	}
//}
//// One way
//void Find1(Node * head, int Number)
//{
//	while (head != NULL)
//	{
//		if (head->value == Number)
//		{
//			cout <<"The Number that search is : "<<head->value << endl;
//		}
//		head = head->Next;
//	}
//}
////Anothor Way
//Node *Find2(Node * head, int Number)
//{
//	while (head != NULL)
//	{
//		if (head->value == Number)
//			return head;
//
//		head = head->Next;
//	}
//
//	return NULL;
//}
//
//int main()
//{
//	Node *head = NULL;
//	
//	InsertAtBegining(head, 1);
//	InsertAtBegining(head, 2);
//	InsertAtBegining(head, 3);
//	InsertAtBegining(head, 4);
//
//	Find1(head, 3);
//	Node *N = Find2(head, 2);
//	InsertAfter(N, 23);
//	InsertEnd(head, 24);
//
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

void Insert(Node* &head, int Num1)
{
	Node* NewNode = new Node;

	NewNode->value = Num1;

	NewNode->Next = head;
	head = NewNode;
}

Node* Find(Node *head, int Num)
{
	while (head != NULL)
	{
		if (head->value == Num)
			return head;

		head = head->Next;
	}
	return NULL;
}

void InsertAt(Node* head, int Num)
{
	Node* newNode = new Node;
	newNode->value = Num;

	newNode->Next = head->Next;
	head->Next = newNode;
}

void InsertEnd(Node* head, int Num)
{
	Node* newNode = new Node;

	newNode->value = Num;
	newNode->Next = NULL;

	if (head == NULL)
	{
		head = newNode;
		return;
	}

	Node* LastNode = head;

	while (LastNode->Next != NULL)
	{
		LastNode = LastNode->Next;
	}
	LastNode->Next = newNode;
	return;
}

void Delete(Node* &head, int Num)
{

	Node* Current = head, * Prev = head;

	if (head == NULL)
		return;

	if (Current->value == Num)
	{
		head = Current->Next;
		delete Current;
		return;
	}

	while (Current != NULL && Current->value != Num)
	{
		Prev = Current;
		Current = Current->Next;
	}

	if (Current = NULL) return;
	
	Prev->Next = Current->Next;
	delete Current;
}

void DeleteAtFirst(Node* head)
{
	Node* Current = head;

	head = Current->Next;
	delete Current;
	return;
}
void Print(Node* head)
{
	while (head != NULL)
	{
		cout << head->value << "\t";
		head = head->Next;
	}
}

int main()
{
	Node* head = NULL;

	Insert(head, 1);
	Insert(head, 2);
	Insert(head, 4);
	//Node*N = Find(head, 2);
	//InsertAt(N, 3);
	//InsertEnd(head, 5);
	Delete(head, 2);
	//DeleteAtFirst(head);

	Print(head);


	_getch();
	return 0;
}