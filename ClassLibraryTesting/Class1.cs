namespace ClassLibraryTesting
{
    public class Class1
    {
        public string Login(string username, string password)
        {
            string result = "";
            if (username == "nehash" && password == "nehash")
            {
                result = "Login Successful";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}