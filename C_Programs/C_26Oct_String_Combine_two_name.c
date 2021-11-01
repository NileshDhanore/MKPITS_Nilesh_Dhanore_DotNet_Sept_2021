/* This is my fifth Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */
int main()
{
char firstname[]="Nilesh";
char lastname[]="Dhanore";
char fullname[50];
int strlength;

strcat(firstname, lastname);
puts(firstname);

/*strlength=strlen(firstname);
printf("\n length of string firstname=%d",strlength);

strrev(firstname);
printf("\n reverse string is\n");
puts(firstname);*/

strcpy(fullname,firstname);
printf("\n Full Name is\n");
puts(fullname);
return 0;
}

