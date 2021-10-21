/* No input to user difeine finction(UDF) but output function type two*/
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
void Area_Circle(int);
void Area_Rect(int);
void Area_Tri(int);
/* global variable declaration */
int main()
{
int radius,l,b,ba,hi;
printf("\n Enter the value of radius\n");
scanf("%d",&radius);
 Area_Circle(radius);
printf("\n Enter the value of length and Breadth\n");
scanf("%d %d",&l,&b);
  Area_Rect();
 printf("\n Enter the value of base and height\n");
scanf("%d %d",&ba,&hi);
 Area_Tri();
 
   return 0;
}

void Area_Circle(int r)
{
float A;
A=3.14*r*r;
printf("\n The area of circle is = %0.3f",A);

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

