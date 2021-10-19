/* Addition using function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
int outsource(int,int);
/* global variable declaration */
int main()
{
 int x=10,y=20,z;
 z=outsource(x,y);
 printf("addition %d\n",z);
 z=outsource(45,45);
 printf("addition %d\n",z);
 x=67;
 y=8;
 printf("addition %d\n", outsource(x,y));
 printf("addition %d\n", outsource(23,43));
 return 0;
}
int outsource(int a,int b)
{
int c;
c=a+b;
return c;
}


