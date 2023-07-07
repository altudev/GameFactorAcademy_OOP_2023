using GFA.OOP.Models;

var fileText = File.ReadAllText("C:\\Users\\alper\\Desktop\\RussianMob.txt");

var lineSplittedText = fileText.Split('\n');

List<GameAccount> gameAccounts = new ();

foreach (var lineText in lineSplittedText)
{
    var lineItems = lineText.Split("---");


    GameAccount account = new()
    {
        
        UserName = lineItems[0],
        Password = lineItems[1],
        Platform = GameAccount.ConvertStringToPlatform(lineItems[2]),
        Level = GameAccount.ConvertStringToLevel(lineItems[3]),
        GameName = lineItems[4],
        Price = Convert.ToDecimal(lineItems[5].Replace("$",string.Empty)),
    };

    gameAccounts.Add(account);

}

gameAccounts.ForEach(x=>Console.WriteLine($"ID:{x.Id}, UserName:{x.UserName}, Password:{x.Password}, Platform:{x.Platform}, Level:{x.Level}, GameName:{x.GameName}, Price:{x.Price:C}"));

Console.ReadLine();