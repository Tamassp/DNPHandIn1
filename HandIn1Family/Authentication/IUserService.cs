namespace HandIn1Family.Authentication
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}