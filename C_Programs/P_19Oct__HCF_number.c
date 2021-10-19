/* This is HCF_no._Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
  int i,a,b;
  printf("Enter two numbers");
  scanf("%d %d",&a,&b);
  for(i=(a>b?a:b);i>=1;i--)
  {
    if(a%i==0 && b%i==0)
     {
       printf("The HCF of numbers is =%d",i);
	   break;
 
     }
	 
  }
   
  
return 0;
}

