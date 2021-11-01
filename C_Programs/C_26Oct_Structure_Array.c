/* pre processor directive */
#include<stdio.h>
#include<string.h>
/* global variable declaration */

int main() 
{
 FILE *filepointer;
 
 char dataToBeWritten[50] = "I am Nilesh and want to learn C";
    Person *People;
	int n,i;
	printf("\n How many people are there?");
	scanf("%d",&n);
	People=(Person*)malloc(n*sizeof(Person));
	for(i=0;i<n;i++)
	{
	fflush(stdin);
	printf("\n Enter the name of person");
	scanf("%s",&(People+i)->Name);
	printf("\n Enter age of preson");
	scanf("%d",&(People+i)->age);
	}
	printf("\n List of People\n");
	
	for(i=0;i<n;i++)
	{
	printf("\n  %s    %d",(People+i)->Name,(People+i)->age);
    }
 }

