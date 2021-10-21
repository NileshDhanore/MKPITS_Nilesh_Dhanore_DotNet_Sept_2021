/* This is Divisibel_by_5_Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
  int i;
  printf("Divisible by 7      Divisible by 3      Divisible by both    \n");
  for(i=1;i<=100;i++)
  {
     if(i%7==0)
   {
    printf("%d\n",i); 
   }
   if(i%3==0)
     {
    printf("\t \t %5d\n",i); 
   }
   if(i%3==0 && i%7==0)
     {
    printf("\t \t \t \t  %10d\n",i); 
   }
  }
return 0;
}

