
//instanciando a classe comment
using OOPCompositionStringBuilder.Entities;

Comment cOne = new Comment();//pode ser inciado vazio
Comment cTwo = new Comment("How that`s awesome!");//Construtor passando parametros

cOne.Text = "Have a Nice trip"; //Construtor vazio

Post pOne = new Post(
   DateTime.Parse("21/06/2018 13:05:44"),
   "Traveling to new Zeland",
   "I`m going to visit this wonderful country", 12);//Construtor passando parametros

//Adicionando comentarios ao post associação
pOne.AddComment(cOne);
pOne.AddComment(cTwo);


Comment cTree = new Comment("Good night");
Comment cFour = new Comment("May the force be with you");

Post pTwo = new Post();//pode ser inciado vazio
pTwo.Moment = DateTime.Parse("28/07/2018 23:14:19");
pTwo.Title = "Good night guys";
pTwo.Content = "See you tomorrow";
pTwo.Likes = 5;

//Adicionando comentarios ao post associação
pTwo.AddComment(cTree);
pTwo.AddComment(cFour);

Console.WriteLine(pOne);
Console.WriteLine(pTwo);    