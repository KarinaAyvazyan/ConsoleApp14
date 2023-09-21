using FamilyCreated.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyCreated.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        [ForeignKey("Family")]
        public int FamilyId { get; set; }
        public Family Family { get; set; }
        public PersonType? Role { get; set; }

    }
}
