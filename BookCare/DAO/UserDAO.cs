using BookCare.Data;

namespace BookCare.DAO
{
    public class UserDAO
    {
        private BookingCareContext _context;
        public bool Authenticate(string email, string password)
        {
            _context = new();
            Account account = _context.Accounts.FirstOrDefault(account => account.Email == email);
            if (account != null)
            {
                if (account.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
