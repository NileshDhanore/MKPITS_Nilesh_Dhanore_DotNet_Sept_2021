/* fuction 4th type */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
void Printline();
void InputMessage();
/* global variable declaration */
int main()
{
 int a,b,c;
 Printline();
 InputMessage();
 scanf("%d%d",&a,&b);
 c=a+b;
 printf("\n Addition =%d",c);
 Printline();
   return 0;
}
void Printline()
{
printf("\n ___________________ \n");
}
void InputMessage()
{
printf("\nEnter any two numbers\n");
}


