/* Thisstructure medicine details Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
typedef struct 
{
int day,month,year;
}date;

typedef struct 
{
char madename[20] ;
int price;
date mdate;
date exdate;
}med;


int main()
{
     /*med e1={"OmeeD",123,19,8,1997,20,3,2000};*/
	 med e1;
	 printf("Enter the name of madicine\n");
	 gets(e1.madename);
	 printf("Enter the price of madicine\n");
	 scanf("%d",&e1.price); 
	 printf(" Enter the manufaturing date in dd/mm/yyyy\n");
	 scanf("%d/%d/%d",&e1.mdate.day,&e1.mdate.month,&e1.mdate.year);
	 printf(" Enter the expiry date in dd/mm/yyyy\n");
	 scanf("%d/%d/%d",&e1.exdate.day,&e1.exdate.month,&e1.exdate.year);
	 printf("The details of medicine are\n");
	 puts(e1.madename);
	 printf("\nPrice of medicine = Rs. %d\n",e1.price);
	 printf("\nManufacturing date is %d /%d /%d\n",e1.mdate.day,e1.mdate.month,e1.mdate.year);
	 printf("\nExpiry date is %d /%d /%d\n",e1.exdate.day,e1.exdate.month,e1.exdate.year);
}	  

