namespace FamilyCreated.Data.Entities
{
    public class Family
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Person> Members { get; set; }
        public List<Animal> Animals { get; set; }

    }
}
