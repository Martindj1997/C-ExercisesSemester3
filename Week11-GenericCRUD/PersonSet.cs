using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_GenericCRUD
{
    class PersonSet : IRepository<Person>
    {
        private List<Person> People { get; set; }

        public void Create(Person value)
        {
            People.Add(value);
        }

        public Person Read(int id)
        {
            int index = People.FindIndex(p => p.Id == id);
            if (index != -1)
                return People[index];
            return null;
        }

        public void Update(Person value)
        {
            int index = People.FindIndex(p => p.Id == value.Id);
            if (index != -1)
                People[index] = value;
        }

        public void Delete(int id)
        {
            int index = People.FindIndex(p => p.Id == id);
            if (index != -1)
                People.RemoveAt(index);
        }

    }
}
