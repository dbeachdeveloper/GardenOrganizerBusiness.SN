using System;

namespace Business.DatabaseModels
{
    public class DbUserLogin : DbModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime Created { get; set; }
        public bool IsConfirmed { get; set; } = true;
        public bool IsLocked { get; set; } = false;
    }
}
