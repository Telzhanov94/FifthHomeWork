int Long=int.Parse(Console.ReadLine());
int count=0;
int res = Long;
int i=5;
while(Long!=0)
{
if (Long>=i)
{
    Long=Long-i;
    count++;
}
else
{
    i--;
}
}
Console.WriteLine(count);