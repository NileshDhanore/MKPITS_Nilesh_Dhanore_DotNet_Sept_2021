/* Area of circle using function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
float Area (int,float);
/* global variable declaration */
int main()
{
 int radius;
 float A,Pi=3.14;
 printf("Enter radius of circle\n");
 scanf("%d",&radius);
 A=Area(radius,Pi);
 printf("\nThe area of circle is =%0.2f",A);
 radius=2;
 Pi=5;
 A=Area(radius,Pi);
  printf("\nThe area of circle is =%0.2f",A);
  A=Area(3,3.14);
  printf("\nThe area of circle is =%0.2f",A);
  radius=2;
  Pi=3.14;
  printf("\nThe area of circle is =%0.2f",Area(radius,Pi));
  printf("\nThe area of circle is =%0.2f",Area(4,3.14));
  return 0;
}
float Area (int r,float pie)
{
return pie*r*r;
}


