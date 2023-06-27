namespace WorkWithAnyDataStorage.Data
{
    public class Organization: Entity
    {
        public string Name { get; set; }

        public Organization(string name)
        {
            Name = name;
        }

        public override string ToString() => $"Index {ID}, Name of the organization: {Name}";

    }


}
