/* This is LCM_no._Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
  int i,a,b;
  printf("Enter two numbers");
  scanf("%d %d",&a,&b);
  for(i=(a>b?a:b);i<=a*b;i+=(a>b?a:b))
  {
    if(i%a==0 && i%b==0)
     {
       printf("The LCM of numbers is =%d",i);
	   break;
 
     }
	 
  }
   
  
return 0;
}

