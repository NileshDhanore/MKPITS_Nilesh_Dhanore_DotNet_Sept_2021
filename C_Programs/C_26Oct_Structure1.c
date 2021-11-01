/* This is compare two string  Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
struct Date
{
int day,month,year;
};

int main()
{
     struct Date today,bday={8,7,1987};
	 int x=10;
	 printf("\n enter todays date in DD/MM/YYYY formate");
	 scanf("%d/%d/%d",&today.day,&today.month,&today.year);
	 printf("\n Today is %d / %d / %d", today.day,today.month,today.year);
	 printf("\n Birthday is %d / %d / %d", bday.day,bday.month,bday.year);

}

