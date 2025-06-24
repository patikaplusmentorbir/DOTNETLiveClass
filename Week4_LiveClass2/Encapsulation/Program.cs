
using Encapsulation.Models;

BankAccount newBankAccount = new BankAccount();

Console.Write("Hesap oluşturan kişinin adı soyadı : ");
newBankAccount.Owner = Console.ReadLine();

Console.Write("Hesap şifreniz : ");
newBankAccount.Password = Console.ReadLine();

Console.WriteLine("Açılış tutarı ne kadar?");
newBankAccount.OpenningBalance = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Banka hesabınız aşağıdaki bilgiler ile oluşturuldu:");
Console.WriteLine("Hesap sahibi -> " + newBankAccount.Owner);
Console.WriteLine("Şifreniz -> " + newBankAccount.Password);
Console.WriteLine("Açılış bakiyesi -> " + newBankAccount.OpenningBalance);



