/* Swap using pointer function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
void Swap(int*,int *);
/* global variable declaration */
int main()
{
 int x=100,y=200;
 printf("\n Before swapping x=%d and y=%d",x,y);
 Swap(&x,&y);
 printf("\n After swapping x=%d and y=%d",x,y);
 
}

void Swap(int *a,int *b )
{
int temp;
temp=*a;
*a=*b;
*b=temp;
}


