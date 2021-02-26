namespace ABModels
{
    public class Login
    {
        private string userName;
        private string password;
        public Login(string userName, string pass)
        {
            this.userName = userName;
            this.password = pass;
        }
        public string UserName { 
            get { return userName; } 
            set { userName = value; }
        }
        public string Password{
            get { return password; }
            set { password = value; }
        }
    }
}