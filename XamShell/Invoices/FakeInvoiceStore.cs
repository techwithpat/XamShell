using System;
using System.Collections.Generic;
using XamShell.Clients;

namespace XamShell.Invoices
{
    public class FakeInvoiceStore
    {
        public static List<Invoice> Invoices => new List<Invoice>()
            {
                new Invoice
                {
                    Name = "Consulting for ACME",
                    Client = new Client
                    {
                        Name = "ACME",
                        Id = Guid.NewGuid().ToString()                        
                    },
                    Id = Guid.NewGuid(),
                    Created = new DateTime(2020, 9, 10),
                    DueTime = new DateTime(2020, 12, 10),
                     Number = "2020082"
                },
                new Invoice
                {
                    Name = "Mobile app for FOO",
                    Client = new Client
                    {
                        Name = "Foo",
                        Id = Guid.NewGuid().ToString()                        
                    },
                    Id = Guid.NewGuid(),
                    Created = new DateTime(2020, 8, 20),
                    DueTime = new DateTime(2020, 10, 5),
                    Number = "2020092"                 
                },
                new Invoice
                {
                    Name = "Consulting for LHMO corp",
                    Client = new Client
                    {
                        Name = "Foo",
                        Id = Guid.NewGuid().ToString()
                    },
                    Id = Guid.NewGuid(),
                    Created = new DateTime(2020, 8, 20),
                    DueTime = new DateTime(2020, 10, 5),
                    Number = "2020092"
                },
            };


    }
}
