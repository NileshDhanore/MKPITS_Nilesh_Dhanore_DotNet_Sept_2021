/* pre processor directive */
#include<stdio.h>
#include<string.h>
/* global variable declaration */

int main() 
{
 FILE *filepointer;
 
 char dataToBeWritten[50]="Nilesh123";
 char password[50];
 char str[20];
  filepointer = fopen("Password.txt","r"); 
 if (filepointer == NULL)
 {
 printf("Password.txt file failed to open"); 
 }
 else
 {
 printf("The file is now opened \n");
   while(fgets(password,50,filepointer)!=NULL)
   
   {
   
   printf("\n %s",password);
   }
     
   fclose(filepointer);
   printf("Data successfully read from file Test.txt \n");
   printf("The file id Closed");
   }
   
   filepointer = fopen("Password.txt","w"); 
 if (filepointer == NULL)
 {
 printf("Password.txt file failed to open"); 
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
    

