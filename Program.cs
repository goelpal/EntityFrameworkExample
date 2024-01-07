
using EntityFrameworkExample;

Console.WriteLine("Hello, World!");

MyDBContext Context = new MyDBContext();

//Create Data (INSERT DATA IN TABLE)

User user1 = new User();

/*
user1.Name = "Maria";
user1.LastName = "Johansson";
user1.Email = "maria.doe@gmail.com";

//Save data to DB forit we are going to use Context Object
//Context that is attached which represents the tables
Context.Users.Add(user1);
Context.SaveChanges(); //This line saves the data to database. Dont forget to save the changes.

Console.WriteLine("The data is successfully added to database");

*/
/*

//GET DATA FROM DATABASE
List<User> Result = Context.Users.ToList();
foreach(User item in Result)
{
    Console.WriteLine($"{ item.Name} {item.LastName} {item.Email}");
}

Result = Context.Users.Where(x => x.Id > 1).ToList();
foreach(var item in Result)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine("------------------------------------");
//User user2 = Context.Users.FirstOrDefault(x => x.Id == 2);
//User user2 = Context.Users.SingleOrDefault(x => x.Id == 1);
User user2 = Context.Users.SingleOrDefault(x => x.Id.Equals(1));
Console.WriteLine($"{user2.Name} {user2.Email}");
*/

//UPDATE DATA IN DATABASE
/*
User user3 = Context.Users.FirstOrDefault(x => x.Id == 3);
user3.Name = "Marikom";
Context.Users.Update(user3);
Context.SaveChanges();
*/

//DELETE ROW FROM DATABASE
var user4 = Context.Users.FirstOrDefault(x => x.Id == 3);
Context.Users.Remove(user4);
Context.SaveChanges();


