namespace Sniffsters.Models
{
    public class UserViewModel
    {
        public UserViewModel(string nickname)
        {
            NickName = nickname;

        }

        public string NickName { get; set; }
    }
}