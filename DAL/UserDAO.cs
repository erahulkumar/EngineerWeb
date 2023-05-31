using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class UserDAO:PostContext
    {
        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            //var list = Db.E_User;
            //List<E_User> list = Db.E_User.Where(x => x.Username == model.Username && x.Password == model.Password).ToList();
            E_User user = Db.E_User.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if(user!=null && user.ID!=0)
            {
                dto.ID = user.ID;
                dto.Username = user.Username;
                dto.Name = user.NameSurName;
                dto.ImagePath = user.ImagePath;
                dto.isAdmin = user.isAdmin;
            }
            return model;
        }
    }
}
