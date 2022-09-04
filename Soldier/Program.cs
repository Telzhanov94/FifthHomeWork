string soldier = Console.ReadLine()??"0";
string [] money = soldier.Split(' ');
int price = Convert.ToInt32(money[0].ToString());
int HaveMoney = Convert.ToInt32(money[1].ToString());
int quantity = Convert.ToInt32(money[2].ToString());
int CostBabans = 0;
for (int i=1;i<=quantity;i++)
CostBabans = CostBabans + (price * i);
int friendMoney = CostBabans - HaveMoney ;
if (friendMoney<0) friendMoney=0;
Console.WriteLine(friendMoney);