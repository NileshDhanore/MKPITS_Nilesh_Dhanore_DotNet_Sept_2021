/* Large number using arry */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
 int a[5],i,b;
 printf("Enter the number\n");
 for(i=0;i<5;i++)
 {
   scanf("%d",&a[i]);
 } 
  for(i=0;i<5;i++)
        {
		 if(a[i]>a[i+1])
		   {
		   a[i+1]=a[i];
	         b=a[i];
		   }
		   else
		   {
		   b=a[i];
		   }
		   }
	   
	printf("\nthe greatest number is=\n");
	printf("%d",b);

	return 0;
	}

