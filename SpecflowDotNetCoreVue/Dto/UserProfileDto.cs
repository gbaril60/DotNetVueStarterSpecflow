
namespace SpecflowDotNetCoreVue.Dto
{
    public class UserProfileDto 
    {
        public int Id { get; set; }
        public int SalesId { get; set; }
        public string Username{ get; set; }
        public string Firstname { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}