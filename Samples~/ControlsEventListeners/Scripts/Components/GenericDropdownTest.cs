
using Rossoforge.Controls.GenericDropDowns;

namespace Rossoforge.Controls.Samples.EventHandlerDemo
{
    public class GenericDropdownTest : GenericDropdownEventsHandler<GenericDropdownTest, Person>
    {
        private void Start()
        {
            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };

            //dropdown.TextMember = "Name";
            Dropdown.AddItems(people);
        }
    }
    public class Person
    {
        public string Name;// { get; set; }
        public int Age;// { get; set; }
    }
}
