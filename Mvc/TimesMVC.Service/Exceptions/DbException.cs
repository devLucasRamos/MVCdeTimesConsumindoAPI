using System;

namespace TimesMVC.Service.Exceptions
{
    public class DbException : ApplicationException
    {
        public DbException(string message) : base(message)
        {
        }
    }
}
