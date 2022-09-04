string fy=Console.ReadLine() ??"0";
int year=Convert.ToInt32(fy.ToString());
year=year+1;
fy=Convert.ToString(year);
while (fy[0]==fy[1] | fy[0]==fy[2] | fy[0]==fy[3] | fy [1]== fy[2] | fy[1]==fy[3] | fy[2]==fy[3])
{
    year=year+1;
    fy=Convert.ToString(year);
}
Console.WriteLine(fy);