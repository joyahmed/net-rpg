namespace net_rpg.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PassworSalt { get; set; } = new byte[0];
        public List<Character>? Characters { get; set; }
    }
}