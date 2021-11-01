/* pre processor directive */
#include<stdio.h>
#include<string.h>
/* global variable declaration */

int main() 
{
 FILE *filepointer;
 
char dataToBeRead[50];
 filepointer = fopen("Test.txt","r"); 
 if (filepointer == NULL)
 {
 printf("Test.txt file failed to open"); 
 }
 else
 {
 printf("The file is now opened \n");
   while(fgets(dataToBeRead,50,filepointer)!=NULL)
   
   {
   
   printf("\n %s",dataToBeRead);
   }
     
   fclose(filepointer);
   printf("Data successfully read from file Test.txt \n");
   printf("The file id Closed");
   }
   return 0;
   }
   
  
    

