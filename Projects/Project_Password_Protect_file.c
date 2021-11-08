/* pre processor directive */
#include<stdio.h>
#include<string.h>
/* global variable declaration */

int main() 
{
 FILE *filepointer,*filewrite;
 
 char dataToBeWritten[50];
 char password[7];
 char str1[20];
 char str2[20];
 int match;
 printf("Set Password:");
 scanf("%s",&dataToBeWritten);
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
   printf("Data successfully written in file Password.txt \n");
   printf("The file is Closed");
 }
 
     filepointer=fopen("Password.txt","r"); 
 if (filepointer == NULL)
 {
 printf("Password.txt file failed to open"); 
 }
 else
 {
 printf("The file is now opened \n");
   while(fgets(password,50,filepointer)!=NULL)
   
   {
   printf("%s",password);
   strcpy(str2,password);
   }
     
  /* fclose(filepointer);
   printf("Data successfully read from file Password.txt \n");
   printf("The file id Closed");*/
   }
   printf("\nEnter Password:");
   scanf("%s",str1);
   match=strcmp(str2,str1);
  /*if (match==0)*/
  printf("%d",match);
  puts("password accepted");
 /* else 
  puts("Incorrect Passord");*/
  /*filewrite = fopen("Test.txt","w"); 
 if (filewrite == NULL)
 {
 printf("Test.txt file failed to open"); 
 }
 else 
 {
 printf("The file is now opened \n");
   if ( strlen(dataToBeWritten)>0)
   {
   
   fputs(dataToBeWritten,filewrite);
   fputs("\n",filewrite);
   }
   
   fclose(filewrite);
   printf("Data successfully written in file Test.txt \n");
   printf("The file is Closed");
 }
 }*/
 
  return 0;
  }
    

