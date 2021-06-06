using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessListing.Model.Configuration
{
    class AuthModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public string ResponseCode { get; set; }

        public bool Success { get; set; }
        public List<String> Errors { get; set; }
    }
}
