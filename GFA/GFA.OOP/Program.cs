
//using GFA.OOP.Common;
//using GFA.OOP.ComplexTypes;
//using GFA.OOP.Interfaces;
//using GFA.OOP.Models;
//using GFA.OOP.Services;

////Console.WriteLine("How do you want to save your content?");
////Console.WriteLine(".txt or .json");

////var usersAnswer = Console.ReadLine();

////var baseModel = new BaseModel<string>();

////IFileSaver fileSaver;

////if (usersAnswer == "txt")
////{
////    fileSaver = new TextFileSaver();

////    fileSaver.Save("ornek","Alper hoca interfaceleri anlatamıyor.");
////}
////else
////{
////    fileSaver = new JsonFileSaver();

////    fileSaver.Save("ornek", "Alper hoca interfaceleri anlatamıyor.");
////}

//var gameFactoryList = new GameFactoryAcademyList<Objective,Guid>();

using GFA.OOP.Models;
using GFA.OOP.Services;

var logger = new FileLogger(filePath: "C:\\Users\\alper\\Desktop\\gfa_logs.txt", "Gfa Logger");

try
{

    decimal bigNumber = 0;
    int smallNumber = 100;

    bigNumber = smallNumber;

    smallNumber = (int)bigNumber;

    NPC npc = new NPC()
    {
        Id = Guid.NewGuid(),
        Name = "Alper Tunga",
        CreatedOn = DateTimeOffset.Now,
        Hp = 50,
    };

    Player player = new Player()
    {
        Id = Guid.NewGuid(),
        Name = "Alper Tunga",
        CreatedOn = DateTimeOffset.Now,
        Hp = 50,
    };


    //NPC alperTunga = (NPC)player;

    NPC alperTunga = (NPC)player;

    Thread.Sleep(2500);

    var gameAccount = new GameAccount();

    logger.Log("A new GameAccount instance was created.");

    gameAccount.Level = 100;

    logger.Log($"{gameAccount.Level} level was assigned to the GameAccount instance.");

    gameAccount.Level = 199;

    Object objectAccount = gameAccount;

    List<object> objects = new List<object>();

    objects.Add(objectAccount);
    objects.Add(gameAccount);
    objects.Add(logger);


    NPC myFavNpc = (NPC)player;






    foreach (var exObject in objects)
    {
        if (exObject != null && exObject is GameAccount)
        {
            var gameAccount2 = gameAccount as GameAccount;

            gameAccount2.Level = 100;
        }
        else if(exObject is FileLogger) { }
        {
            
        }
    }

    logger.Log($"A new value for the Level ({gameAccount.Level}) was assigned to the GameAccount instance.");

    gameAccount.GameName = "Cyberpunk 2077";

    logger.Log($"{gameAccount.GameName} as a name field's value was assigned to the GameAccount instance.");

    if (string.IsNullOrEmpty(gameAccount.UserName))
        throw new Exception("Username cannot be null or empty.");

    var yourNpc = (NPC)player;
}
catch (NullReferenceException exception)
{

}
catch (Exception ex)
{
    Console.WriteLine("Please enter your username and try again.");
    logger.Log(ex.ToString());
}

//var myLevel = "100FFFFFFF";

//// This comment is for Mr. Ozan The Russion Mob

//gameAccount.Level = myLevel.ConvertStringToLevel();

//Console.WriteLine(gameAccount.Level);

////int myAge = 28;

////var isMyAgeEven = myAge.IsEven();

////Console.WriteLine(isMyAgeEven);

Console.ReadLine();
