using kayit.BLL.Repository.Entity;

namespace kayit.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _companyService = new CompanyRepository();
            _marketService = new MarketRepository();
            _userService = new UserRepository();

        }
        private CompanyRepository _companyService;

        public CompanyRepository CompanyService
        {
            get { return _companyService; }
            set { _companyService = value; }
        }

        private MarketRepository _marketService;
        public MarketRepository MarketService
        {
            get { return _marketService; }
            set { _marketService = value; }
        }
        private UserRepository _userService;
        public UserRepository UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }


    }
}
