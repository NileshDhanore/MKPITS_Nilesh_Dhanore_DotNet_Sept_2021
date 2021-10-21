/* Addition using function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
int Add(int);
/* global variable declaration */
int main()
{
 int A,limit;
 printf("Enter upper limit to find 1 to n numbers");
 scanf("%d",&limit);
 A=Add(limit);
 printf("\n The addition =%d",A);
   return 0;
}
int Add(int n)
{
int i,sum=0;
for(i=0;i<n;i++)
{
sum+=i;
}
return sum;
}

