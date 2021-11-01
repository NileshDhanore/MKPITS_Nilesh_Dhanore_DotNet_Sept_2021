/* This is compare two string  Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
typedef struct 
{
int day,month,year;
}date;

typedef struct 
{
int empid;
char empname[20];
date doj;
}emp;


int main()
{
     emp e1={1,"Mr Bill Gates",19,8,1967};
	 printf(" Employess details are\n");
	 printf("\nEmployess ID \n", e1.empid);
	 printf("\nEmployee Name\n");
	 puts(e1.empname);
	 printf("\nDate of Joining is %d /%d /%d\n",e1.doj.day,e1.doj.month,e1.doj.year);
}	  
	 

