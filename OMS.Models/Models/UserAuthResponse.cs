using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Models.Models
{
    public class UserAuthResponse
    {
        public UserAuthResponse(UserViewModel user, string token)
        {
            Id = user.UserId;
            FirstName = user.firstName;
            LastName = user.lastName;
            Username = user.UserName;
            OutletId = user.OutletId;
            Token = token;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public long OutletId { get; set; }



    }
}
