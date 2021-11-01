/* This is my fifth Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
char str[20],n;
printf("Enter a charater\n");
n=getchar();
printf("\n.............\n");
printf("Enter a string\n");
fflush(stdin);
gets(str);
printf("%s\n",str);
puts(str);
return 0;
}

