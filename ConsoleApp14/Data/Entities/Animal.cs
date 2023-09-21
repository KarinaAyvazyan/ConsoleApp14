using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyCreated.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Family")]
        public int FamilyId { get; set; }
        public Family Family { get; set; }
    }
}
