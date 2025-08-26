using System;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CreateLoginCommand
    {
        private readonly string _username;
        private readonly string _password;
        private readonly DAL _dal;

        public CreateLoginCommand(string username, string password, DAL dal)
        {
            _username = username;
            _password = password;
            _dal = dal;
        }

        public bool Execute()
        {
            return _dal.ValidateUser(_username, _password);
        }
    }
}
