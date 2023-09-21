using FamilyCreated.Data.Entities;
using FamilyCreated.Data;

namespace FamilyCreated.Services
{
    public class FamilyService
    {

        private FamilyDataContext _context;

        public FamilyService()
        {
            _context = new FamilyDataContext();
        }
        public void Add(Family family, bool isSaveChanges = true)
        {
            _context.Families.Add(family);
            if (isSaveChanges)
            {
                _context.SaveChanges();
            }

        }
  

        public void Delete(int Id)
        {
            var entity = _context.Families
                .FirstOrDefault(p => p.Id == Id);
            _context.Families.Remove(entity);
            _context.SaveChanges();
        }

        public Family GetById(int Id)
        {
            return _context.Families.FirstOrDefault(p => p.Id == Id);
        }
    }
}
