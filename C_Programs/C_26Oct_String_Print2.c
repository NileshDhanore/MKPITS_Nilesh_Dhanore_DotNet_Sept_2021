/* This is string basic Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
char str[20];
printf("Enter a string\n");
scanf("%[^\n]",&str);
printf("%s",str); 
return 0;
}

