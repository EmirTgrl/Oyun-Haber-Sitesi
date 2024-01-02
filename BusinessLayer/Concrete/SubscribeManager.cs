using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;
        private readonly Context _context;

        public SubscribeManager(ISubscribeDal subscribeDal, Context context)
        {
            _subscribeDal = subscribeDal;
            _context = context;
        }

        public bool SubscribeToNewsletter(string email)
        {
            if (_context.Subscribes.Any(s => s.Mail == email))
            {
                return false; // E-posta zaten kayıtlıysa başarısız.
            }

            var subscriber = new Subscribe { Mail = email };
            _context.Subscribes.Add(subscriber);
            _context.SaveChanges();
            return true;
        }

        public void TAdd(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void TDelete(Subscribe t)
        {
            throw new NotImplementedException();
        }

        public Subscribe TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public void TUpdate(Subscribe t)
        {
            throw new NotImplementedException();
        }
    }
}
