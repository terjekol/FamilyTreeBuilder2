using System.Collections.Generic;
using FamilyTreeBuilder2.ModelsGenerated;

namespace FamilyTreeBuilder2.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<Person> Children { get; set; }

    }
}
