string str=Console.ReadLine()??"0";
string [] s=str.Split(' ');
decimal[] a=new decimal [3];
for (int i=0;i<3;i++)
a[i]=Convert.ToInt32(s[i].ToString());
decimal d=(Math.Ceiling(a[0]/a[2])*Math.Ceiling(a[1]/a[2]));
Console.Write(d);