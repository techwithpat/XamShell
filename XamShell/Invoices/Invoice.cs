using System;
using XamShell.Clients;

namespace XamShell.Invoices
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public Client Client { get; set; }
        public DateTime Created { get; set; }
        public DateTime DueTime { get; set; }
        public decimal Amount => new Random().Next(400, 1000);
    }
}
