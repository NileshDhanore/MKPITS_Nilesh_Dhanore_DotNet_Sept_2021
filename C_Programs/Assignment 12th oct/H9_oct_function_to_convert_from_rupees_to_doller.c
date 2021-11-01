/* Convert dollar into rupees function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
float Rupee(int);
/* global variable declaration */
int main()
{
 int r;
 float d;
 printf("Enter the amount in rupee");
 scanf("%d",&r);
 d=Rupee(r);
 printf("\n The amount Rs %d in doller is $ %0.2f",r,d);
 
   return 0;
}
float Rupee(int a)
{
return a/74.78;
}


