/* No input to user difeine finction(UDF) but output function type two*/
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
float Area_Circle();
float Area_Rect();
float Area_Tri();
/* global variable declaration */
int main()
{
 float A;
 A=Area_Circle();
 printf("\n  Area of circle =%f\n",A);
 A=Area_Rect();
 printf("\n  Area of rectangle =%f\n",A);
 A=Area_Tri();
 printf("\n  Area of triangle =%f\n",A);
   return 0;
}

float Area_Circle()
{
int r;
printf("Enter the value of radius");
scanf("%d",&r);
return 3.14*r*r;
}
float Area_Rect()
{
int l,b;
printf("Enter the value of length and Bredth");
scanf("%d %d",&l,&b);
return l*b;
}
float Area_Tri()
{
int b,h;
printf("Enter the value of base and height");
scanf("%d %d",&b,&h);
return 0.5*b*h;
}

