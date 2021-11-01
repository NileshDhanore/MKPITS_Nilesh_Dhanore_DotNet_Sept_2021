/* Funcion salary and Struture  Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */

typedef struct 
{
int id;
char name[20];
float sal;
}
Emp;

void display(Emp*);
int main()
{
   Emp e[3];
   int i;
   float s=35000;
   for(i=0;i<3;i++)
{
printf("\nEnter ID :");
scanf("%d",&e[i].id);
printf("\n Enter Name");
fflush(stdin);
gets(e[i].name);
e[i].sal=s;
}
display(e);
return 0; 
}

void display(Emp *e)
{
int i;
for(i=0;i<3;i++)
printf("\n Id is %d  \t  name %s  \t salary  Rs: %0.2f", (e+i)->id,(e+i)->name,(e+i)->sal);
}


