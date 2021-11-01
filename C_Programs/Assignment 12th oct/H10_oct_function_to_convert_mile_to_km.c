/* Convert dollar into rupees function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
float mile_km(int);
/* global variable declaration */
int main()
{
 int mile;
 float km;
 printf("Enter the distance in miles\n");
 scanf("%d",&mile);
 km=mile_km(mile);
 printf("\n The distance %d mile is  %0.2f km",mile,km);
 
   return 0;
}
float mile_km(int a)
{
return a*1.609;
}

