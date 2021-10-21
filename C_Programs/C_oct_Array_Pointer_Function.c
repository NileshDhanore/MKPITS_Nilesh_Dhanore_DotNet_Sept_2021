/* Addition using function */
/* pre processor directive */
#include<stdio.h>
/* Declaration prototype */
void Display_Array(int*,int n);
/* global variable declaration */
int main()
{
 int a,j,n[100];
 printf("Enter the size of array");
 scanf("%d",&n);
 printf("\n Enter the value of array");
 for(j=0;j<n;j++)
 {
 scanf("%d",&a);
 }
 Display_Array(n,a);
}
void Display_Array(int *A,int b )
{
int i;
for(i=0;i<b;i++)
{
printf("%5d",*(A+i));
}
}

