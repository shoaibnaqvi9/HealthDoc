using System;

namespace BusinessLogicLayer
{
    public interface ICommand
    {
        void Execute();
    }

    public class LoginCommand : ICommand
    {
        private BLL _bll;
        private string _userType;
        private object _credentials;
        private bool _result;

        public LoginCommand(BLL bll, string userType, object credentials)
        {
            _bll = bll;
            _userType = userType;
            _credentials = credentials;
        }

        public void Execute()
        {
            switch (_userType.ToLower())
            {
                case "patient":
                    _result = _bll.Login_patient((int)_credentials);
                    break;
                case "doctor":
                    _result = _bll.Login_doctor((string)_credentials);
                    break;
                case "admin":
                    var adminCreds = (Tuple<string, string>)_credentials;
                    _result = _bll.Login_admin(adminCreds.Item1, adminCreds.Item2);
                    break;
            }
        }
        public bool GetResult() => _result;
    }

    public class CreatedLoginCommand : ICommand
    {
        private Registration _registration;

        public CreatedLoginCommand(Registration registration)
        {
            _registration = registration;
        }

        public void Execute()
        {
            _registration.Register();
        }
    }
}