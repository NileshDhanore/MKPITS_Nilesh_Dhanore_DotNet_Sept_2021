
/* pre processor directive */
#include<stdio.h>
#include"my_header_1.h"
#define Line  "\n________________________\n"
#define Square(x) (x)*(x)
#define Function(a,b,c)     a*a+b*b+c*c
#define output printf
/* global variable declaration */
int main()
{
int n1=2,n2=3,n3=5;
printf(Line);
output("\n Square of 5 is =%d",Square(5));
output("\n function(n1,n2,n3)=%d",Function(n1,n2,n3));
  printf("\n 3rd Power of 2 is =%d",Power(3));	    
	
return 0;
}

