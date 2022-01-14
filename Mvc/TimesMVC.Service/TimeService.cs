using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TimesMVC.Core.Entities;
using TimesMVC.Service.Exceptions;
using TImesMVC.Repository;

namespace TimesMVC.Service
{
    public class TimeService
    {
        private readonly ApplicationContext _context;

        public TimeService(ApplicationContext context)
        {
            _context = context;
        }
        public List<Time> FindAll()
        {
            List<Time> times = _context.Time.ToList();
            return times;
        }
        public Time FindById(int id)
        {
            return _context.Time.Find(id);
        }
        public void CreateTime(Time obj)
        {
            _context.Time.Add(obj);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            try
            {
                var obj = _context.Time.Find(id);
                _context.Time.Remove(obj);
                _context.SaveChanges();

            }
            catch (DbUpdateException)
            {
                throw new IntegrityException("Can't delete this time!");
            }
        }

        public void Update(Time obj)
        {
            bool hasAny = _context.Time.Any(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbException(e.Message);
            }
        }
    }
}
