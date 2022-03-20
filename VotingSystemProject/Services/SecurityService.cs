using VotingSystemProject.Models;

namespace VotingSystemProject.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { Id = 0, Name = "Emin", Password = "123emin" });
            knownUsers.Add(new UserModel { Id = 1, Name = "Saif", Password = "123saif" });
            knownUsers.Add(new UserModel { Id = 2, Name = "Alec", Password = "123alec" });
        }
        public bool IsValid(UserModel user)
        {
            return knownUsers.Any(x => x.Name == user.Name && x.Password == user.Password);
        }
    }
}
