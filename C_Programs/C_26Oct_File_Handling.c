/* Funcion salary and Struture  Program */
/* pre processor directive */
#include<stdio.h>
/* global variable declaration */

typedef struct 
{
char studname[30];
int Rollno,Marks;
}student;

void display(student*);
int main()
{
   student s[3],s2;
   int i;
   char n[30];
   for(i=0;i<3;i++)
{
printf("\nEnter Roll No. :");
scanf("%d",&s[i].Rollno);
fflush(stdin);
printf("\n Enter Marks");
scanf("%d",&s[i].Marks);
printf("\nEnter student Name\n");
fflush(stdin);
gets(s[i].studname);
}
display(s);
return 0; 
}

void display(student *s)
{
int i;
FILE *outfile;
outfile=fopen("student.txt","a");
for(i=0;i<=3;i++)
{
printf("\n Stdents details are\n");
printf("\n Rollno. is %d \n ",(s+i)->Rollno);
puts((s+i)->studname);
if((s+i)->Marks>=40 && (s+i)->Marks<100)
{
printf("\n Result=Pass");
}
else
{
printf("\n Result = fails");
}

fwrite(&s[i], sizeof(student),1,outfile);
}
}


