using System;
using System.Collections.Generic;
using System.Text;

namespace Country.Model
{
    class Towns
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Town { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
