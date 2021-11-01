/* pre processor directive */
#include<stdio.h>
#include<string.h>
/* global variable declaration */

int main() 
{
 FILE *filepointer;
 
char dataToBeWritten[50]="I am Nilesh";
 filepointer = fopen("Test.txt","w"); 
 if (filepointer == NULL)
 {
 printf("Test.txt file failed to open"); 
 }
 else
 {
 printf("The file is now opened \n");
   if ( strlen(dataToBeWritten)>0)
   {
   
   fputs(dataToBeWritten,filepointer);
   fputs("\n",filepointer);
   }
   
   fclose(filepointer);
   printf("Data successfully written in file Test.txt \n");
   printf("The file is Closed");
   }
   return 0;
   }
   
  
    

