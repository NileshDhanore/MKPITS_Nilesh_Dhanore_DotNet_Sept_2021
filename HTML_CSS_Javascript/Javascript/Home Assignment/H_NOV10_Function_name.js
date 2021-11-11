var fname,lname;
fname=prompt("Enter first name","Nilesh");
lname=prompt("Enter last name", "Dhanore");
fullname=Fullname(fname,lname);
document.getElementById("demo").innerHTML=fullname;
function Fullname(f,l)
{
return f + " " + l;
}