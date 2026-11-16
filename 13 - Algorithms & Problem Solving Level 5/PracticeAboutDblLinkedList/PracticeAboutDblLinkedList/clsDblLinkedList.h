#pragma once
#include<iostream>
using namespace std;

template <class T> 
class clsDblLinkedList
{

public:
	class Node
	{
	public:
		T value;
		Node *Next;
		Node *Prev;
	};
	
	Node* head = NULL;

	void insertBegining(T value)
	{
		Node *newNode = new Node;
		newNode->value = value;
		newNode->Prev = NULL;
		newNode->Next = head;
		if (head != NULL)
			head->Prev = newNode;
		head = newNode;
	}
	void PrintList()

	{
		Node* Current = head;

		while (Current != NULL) {
			cout << Current->value << " ";
			Current = Current->Next;
		}
		cout << "\n";
	}

	Node *Find(T value)
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
	
	void DeleteAfter(Node *&Current)
	{
		if (head == NULL || Current == NULL) return;

		if (head == Current)
			head = head->Next;
		
		if (Current->Next != NULL)
			Current->Next->Prev = Current->Prev;

		if (Current->Prev != NULL)
			Current->Prev->Next = Current->Next;
	
		delete Current;
	}
	void DeleteNode(Node*& NodeToDelete) {

		if (head == NULL || NodeToDelete == NULL) {
			return;
		}
		if (head == NodeToDelete) {
			head = NodeToDelete->Next;
		}
		if (NodeToDelete->Next != NULL) {
			NodeToDelete->Next->Prev = NodeToDelete->Prev;
		}
		if (NodeToDelete->Prev != NULL) {
			NodeToDelete->Prev->Next = NodeToDelete->Next;
		}
		delete NodeToDelete;
	}
	void Print()
	{
		Node *Current = head;

		while (Current != NULL)
		{
			cout << Current->value << "\t";
			Current = Current->Next;
		}
		cout << "\n";
	}


};

