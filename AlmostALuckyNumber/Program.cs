string number = Console.ReadLine()??"0";
int count=0;
for (int i=0; i<number.Length;i++)
{
    if (number[i]=='4' | number[i]=='7')
    {
        count++;
    }
}
if (count==4 | count ==7)
{
    Console.WriteLine("YES");
}
else {Console.WriteLine ("NO");}