/* This is compare two string  Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */

typedef struct 
{
char bookname;
char author;
int price;
int num_pg;
}
Book;


int main()
{
    Book b={"CBSE Book","H.C. Verma","Rs"123"/-",0"-"320};
	printf("\n The book detais are \n %s \n %s  \n %d   \n %d", b.bookname,b.author,b.price,b.num_pg);
	
}

