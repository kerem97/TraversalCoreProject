using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> TGetListReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListReservationByWaitApproval(id);
        }

        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);

        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }



        public void TInsert(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }

        public List<Reservation> TGetListReservationByConfirmed(int id)
        {
            return _reservationDal.GetListReservationByConfirmed(id);
        }

        public List<Reservation> TGetListReservationByPrevious(int id)
        {
            return _reservationDal.GetListReservationByPrevious(id);
        }
    }
}
