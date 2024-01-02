using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GameTypeManager : IGameTypeService
    {
        IGameTypeDal _gameTypeDal;

        public GameTypeManager(IGameTypeDal gameTypeDal)
        {
            _gameTypeDal = gameTypeDal;
        }

        public void TAdd(GameType t)
        {
            _gameTypeDal.Insert(t);
        }

        public void TDelete(GameType t)
        {
            _gameTypeDal.Delete(t);
        }

        public GameType TGetByID(int id)
        {
            return _gameTypeDal.GetById(id);
        }

        public List<GameType> TGetList()
        {
            return _gameTypeDal.GetList();
        }

        public void TUpdate(GameType t)
        {
            _gameTypeDal.Update(t);
        }
    }
}
