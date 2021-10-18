/* This is gmtokg_converter_Program */
/* pre processor directive */
#include<stdio.h>

/* global variable declaration */
int main()
{
int gm,kg;
 printf(" Gram to Kilogram converter. \n Enter the value in gm\n");
 scanf("%d",&gm);
 kg=gm/1000;
 gm=gm%1000;
 printf(" \n The value %d kg %d gm",kg,gm);
return 0;
}

