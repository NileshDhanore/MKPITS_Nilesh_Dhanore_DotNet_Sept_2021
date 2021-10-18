/* To find the minimum value if integer data type */
/* pre processor directive */
#include<stdio.h>
#include<limits.h>
/* global variable declaration */
int main()
{
char a=CHAR_MIN;
signed char b=SCHAR_MIN;
short c=SHRT_MIN;
int d=INT_MIN;
long e=LONG_MIN;
long long f=LLONG_MIN;


printf("\n Maximum Int value \na=%d \nb=%d \nc=%d \nd=%d \ne=%d \nf=%d",a,b,c,d,e,f);
return 0;

}

