using PingPongProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PingPongProject.DAL
{
    public class PlayerDBContext : DbContext
    {
        //This is collection of Player entities from the Databse context
        public  DbSet<Player> Players { get; set; }
    }
}