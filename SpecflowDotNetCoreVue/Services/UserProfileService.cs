namespace SpecflowDotNetCoreVue.Services
{
    using SpecflowDotNetCoreVue.Dto;
    using SpecflowDotNetCoreVue.Data;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System;

    public class UserProfileService
    {
        private readonly IRepository<UserProfileDto> _repository;

        public UserProfileService(IRepository<UserProfileDto> repository)
        {
            _repository = repository;
        }

        public object GetUserProfile(int salesId)
        {
            return _repository.GetAll().FirstOrDefault(u => u.SalesId == salesId);
        }
        public bool IsUserPasswordValid(UserProfileDto profileDto, string password)
        {
            var hash = SHA512.Create().ComputeHash(Encoding.ASCII.GetBytes(password));

            return profileDto.PasswordHash.SequenceEqual(hash);
        }
    }
}