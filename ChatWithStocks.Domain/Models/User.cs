using System;

namespace ChatWithStocks.Domain.Models
{
    public class User
    {
        //todo - implement MS Identity
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
