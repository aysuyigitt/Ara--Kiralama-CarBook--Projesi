using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.RegisterDtos
{
	public class CreateRegisterDto
	{
        public string Username { get; set; }
		public string Password { get; set; }
        public string Namee { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
