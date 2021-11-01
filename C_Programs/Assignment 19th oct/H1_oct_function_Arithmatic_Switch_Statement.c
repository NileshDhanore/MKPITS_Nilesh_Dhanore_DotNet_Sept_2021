/* Arithmatic program operation using switch and function */
/* pre processor directive */
#include<stdio.h>
#include<math.h>
/* Declaration prototype */
int Arithmatic_Sum(int,int);
int Arithmatic_Sub(int,int);
int Arithmatic_Mul(int,int);
float Arithmatic_Div(int,int);
int Arithmatic_Pow(int,int);
int Arithmatic_Rem(int,int);
/* global variable declaration */
int main()
{
 int a,b,n,sum,sub,mul,pow,rem;
 float div;
 printf("Enter any two values");
 scanf("%d%d",&a,&b);
 printf("\n Select arithmatic operation as per requirement\n 1.Addition \n2.Substraction \n3.Multiplication \n4.Division  \n5.power \n6.Remainder  ");
 scanf("%d",&n);
 switch (n)
 {
 case 1: sum=Arithmatic_Sum(a,b);
		 printf("%d + %d = %d",a,b,sum);
		 break;
 case 2: sub=Arithmatic_Sub(a,b);
          printf("%d - %d = %d",a,b,sub);
		  break;
 case 3: mul=Arithmatic_Mul(a,b);
         printf("%d * %d = %d",a,b,mul);
		  break;
 case 4: div=Arithmatic_Div(a,b);
          printf("%d / %d = %d",a,b,div);
		  break;
 case 5: pow=Arithmatic_Pow(a,b);
          printf("%d^%d = %d",a,b,pow);
		  break;
 case 6: rem=Arithmatic_Rem(a,b);
         printf("%d modulus %d = %d",a,b,rem);
		  break;
 default : printf("your have selected wrong option");
 } 
   return 0;
}
int Arithmatic_Sum(int x,int y)
{
return x+y;
}
int Arithmatic_Sub(int x,int y)
{
return x-y;
}
int Arithmatic_Mul(int x,int y)
{
return x*y;
}
float Arithmatic_Div(int x,int y)
{
return x/y;
}
int Arithmatic_Pow(int x,int y)
{
return pow(x,y);
}
int Arithmatic_Rem(int x,int y)
{
return x%y;
}

