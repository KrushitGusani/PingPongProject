using PingPongProject.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PingPongProject.Models
{
    public class PlayerDBContextSeeder : DropCreateDatabaseIfModelChanges<PlayerDBContext>
    {
        /*This method will seed the database when the application starts from Application_Start()
          by creating Player objects and inserting values into it.        
        */

        protected override void Seed(PlayerDBContext context)
        {
            Player playerOne = new Player()
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 26,
                SkillLevel = "Beginner",
                EmailAddress = "john.smith@smithco.com",
            };
            Player playerTwo = new Player()
            {
                FirstName = "David",
                LastName = "Brown",
                Age = 35,
                SkillLevel = "Intermediate",
                EmailAddress = "david.brown11@dbrown.com",
            };
            Player playerThree = new Player()
            {
                FirstName = "Shawn",
                LastName = "Williams",
                Age = 27,
                SkillLevel = "Advance",
                EmailAddress = "swilliams@random.com",
            };
            Player playerFour = new Player()
            {
                FirstName = "Martha",
                LastName = "Johnson",
                Age = 34,
                SkillLevel = "Expert",
                EmailAddress = "johnsonmartha@uniquepvt.ca",
            };
            Player playerFive = new Player()
            {
                FirstName = "Sally",
                LastName = "Jones",
                Age = 19,
                SkillLevel = "Intermediate",
                EmailAddress = "sally@owners.ca",
            };

            //contaxt is database context in which all the player details are added
            context.Players.Add(playerOne);
            context.Players.Add(playerTwo);
            context.Players.Add(playerThree);
            context.Players.Add(playerFour);
            context.Players.Add(playerFive);

            base.Seed(context);
        }
    }
}