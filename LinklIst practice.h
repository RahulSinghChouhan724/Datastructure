//include header file
#include<stdio.h>
#include<stdlib.h>

//Link list Node
struct node
{
	int data;
	struct node *next;
};

//Insert a new node in front
void push( struct node ** head_ref,int new_data)
{
	//allocate node
	struct node *new_node =(struct node*)malloc(sizeof(struct node));
	//insert Data
	new_node->data=new_data;
	//Make  next of new_node as head 
	new_node->next =(*head_ref);
	// head point to new_node 
	(*head_ref)=new_node;
}

//Insert a new node in between Link List
void Insertbetween(struct node * prev_node,int new_data)
{
	if(prev_node==NULL)
	{
		printf("The given previous node  cannot be null");
		return ;
	}
	
	struct node *new_node =(struct node*)malloc(sizeof(struct node));
	new_node->data=new_data;
	//Make next of prev_node as new_node 
	new_node->next =prev_node->next;
	//Next of prev_node as new_node
	prev_node->next=new_node;
}

//Insert a new node in the end of link list
void  InsertEnd(struct node**  head_ref, int new_data)
{
	struct node *new_node =(struct node*)malloc(sizeof(struct node));	
	struct node *last =*head_ref;
	new_node->data=new_data;
	new_node->next=NULL;
	//if link list is empty
	if(*head_ref == NULL)
	{
		*head_ref= new_node;
		return;
	}
	//else traverse till end
	while(last->next!=NULL)
	{
		last = last-><next;
	}
	
	last-next=new_node;
	return;

	//Print Link List
	void PritList(struct node *node)
	{
		while (node !=null)
		{
			printf("%d",node->data);
			node =node->next;
		}
	}
	
	int Main()
	{
		strruct node* head =NULL;
		push(&head,01);
		push(&head,02);
		push(&head,03);
		Insertbetween(&head,04);
		InsertEnd(&head, 00);
		push(&head,05);
		
		printf("Link List data is :");
		PrintList(head);
		
		return 0;
	}
}