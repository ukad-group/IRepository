namespace System.Data
{
    public interface IUser
    {
        int Id { get; set; }
        string Alias { get; set; }
        string PasswordHash { get; set; }
        string Email { get; set; }
    }
}
