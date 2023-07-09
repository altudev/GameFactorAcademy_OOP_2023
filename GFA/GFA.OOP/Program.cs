
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

using GFA.OOP.Extensions;
using GFA.OOP.Models;

var gameAccount = new GameAccount();

//gameAccount.Level = 100;

//Console.WriteLine(gameAccount.Level.IsEven());

//gameAccount.Level = 199;

//Console.WriteLine(gameAccount.Level.IsEven());

var myLevel = "100FFFFFFF";

gameAccount.Level = myLevel.ConvertStringToLevel();

Console.WriteLine(gameAccount.Level);

//int myAge = 28;

//var isMyAgeEven = myAge.IsEven();

//Console.WriteLine(isMyAgeEven);

Console.ReadLine();
