using kayit.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kayit.BLL.Repository.Entity
{
   public class UserRepository : Base.BaseRepository<User>
    {
        public bool CheckEmail(string gelen)
        {

            var li = GetAll().Where(x => x.Email == gelen).SingleOrDefault();
            
            if (li == null )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }


}