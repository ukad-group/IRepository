namespace System.Data
{
    public interface IUser
    {
        int Id { get; set; }
        string Alias { get; set; }
        string PasswordHash { get; set; }
        string Email { get; set; }
        string NormalizedEmail { get; set; }
        string NormalizedAlias { get; set; }
        bool IsDeleted { get; set; }
    }
}
