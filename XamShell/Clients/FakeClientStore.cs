using System;
using System.Collections.Generic;

namespace XamShell.Clients
{
    public class FakeClientStore
    {
        public static List<Client> Clients => new List<Client>()
            {
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Angus Barton",                   
                    Email = "angus@email.com"
                },
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Alexandros Boyer",                  
                    Email = "alexandros@email.com",
                },
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Maddy Bassett",                    
                    Email = "maddyb@email.com",
                },
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Lily-May Espinoza",
                    Email = "espinoza@email.com"
                },
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Brendon Flynn",
                    Email = "flyn123@email.com",
                },
                new Client
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Nela Velazquez",
                    Email = "vela@email.com",
                }
            };
    }
}
