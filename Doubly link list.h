//Program to implement Doubly link list
#includes<stdio.h>
#includes<stdlib.h>

//Link List Node
struct node{
	int data;
	struct node* next;
	struct node* prev;
};


//insert a new node In front of link list
void push(struct node** head_ref, int new_data)
{
	//allocate node
	struct node*   new_node=(struct node*)malloc(sizeof(strruct node));
	new_node->data = new_data;
	new_node->next(*head-ref);
	new_node->prev =Null;
	
	//change prev  head node to new node
		if((*head_ref)!=NULL)
			(*head_ref)->prev=new_node;
		//move the head point to new node
		(*head_ref)=new_node;
	}
	
//Insert new node after given node
void InsertAfter(struct node* pre_node,int new_data)
{
	//check pre_node  is null
	if(prev_node ==  NULL)
	{
		printf("the given previous node  cannot  be null");
		return;
	}
	
	struct node*   new_node=(struct node*)malloc(sizeof(strruct node));
	new_node->data = new_data;
	//Make next of new node as next of prev node
	new_node->next = pre_node->next;
	//Make the next of pre_node as new node
	pre_node_>next =new_node;
	//make pre_node as previous  of new_node
	new_node->prev =prev_node;
	//change previous of new_node next node
	if(new_node-next !=NULL)
		new_node->next->prev =new_node;
}

//Insert new node at the end
void InsertAtEnd(struct node ** head_ref, int new_data)
{
	struct node * new_node = (struct node*)malloc(sizeof(struct node));
	new_node->data =new_data;
	new_node->next =NULL;
	if(*head_ref==NULL)
	{
		new_node->prev=NULL;
		*head_ref =new_node;
		return;
	}
		
		while( last->next !=NULL)
					last =last->next;
				
				last->next=new_node;
				new_node->prev=last;
				
			return;
}

void PrintLinkList(struct node * node)
{
	struct node* last;
	printf("\n Travers in forward direction");
	while(node !=null)
	{
		printf("%d",node->data);
		last=node;
		node=node->next;
	}
	printf("\n Travers in reverse direction");
	while(last!=NULL)
	{
		printf("%d" last->data);
		last =last->prev;
	}
}


int main()
{
	struct node* head = NULL;
	InsertAtEnd(&head, 6);
	push(&head, 42)
	InsertAtEnd(&head, 4);
	push(&head, 24);
	InsertAfter(head->next,22);
	
	PrintLinkList(head);
	getchar();
	return  0;
	
}