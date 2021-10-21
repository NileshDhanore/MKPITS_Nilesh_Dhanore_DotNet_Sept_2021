/* Addition using function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
int Add(int,int);
int Sub(int,int);
int Mul(int,int);
float Div(int,int);
int Modulus(int,int);
/* global variable declaration */
int main()
{
 int x,y,result;
 printf("\nEnter any two value\n");
 scanf("%d %d",&x,&y);
 result=Add(x,y);
 printf("addition %d\n", result);
 result=Sub(x,y);
 printf("substraction %d\n", result);
  result=Mul(x,y);
  printf("Multiplication %d\n", result);
  result=Div(x,y);
  printf("Division %f\n", result);
  result=Modulus(x,y);
  printf("Remainder %d\n", result);
  return 0;
}
int Add(int a,int b)
{
return a+b;
}
int Sub(int a,int b)
{
return a-b;
}
int Mul(int a,int b)
{
return a*b;
}
float Div(int a,int b)
{
return a/b;
}
int Modulus(int a,int b)
{
return a%b;
}

