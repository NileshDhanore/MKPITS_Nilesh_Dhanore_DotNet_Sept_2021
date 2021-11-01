/* Convert dollar into rupees function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
float Doller(int);
/* global variable declaration */
int main()
{
 int d;
 float r;
 printf("Enter the amount in doller");
 scanf("%d",&d);
 r=Doller(d);
 printf("\n The amount $ %d in indian rupees is Rs.%0.2f",d,r);
 
   return 0;
}
float Doller(int a)
{
return 74.78*a;
}

