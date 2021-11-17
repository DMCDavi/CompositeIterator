using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator
{
    class Mother : Person
    {
        public List<Person> people = new List<Person>();
        public IEnumerator iterator;
        public Mother(bool artist, string name)
        {
            this.artist = artist;
            this.name = name;
        }
        public override int attribute()
        {
            return 69;
        }
        public override void print()
        {
            if (artist) Console.WriteLine($"{name} é uma mãe artista");
            else Console.WriteLine($"{name} é uma mãe não artista");
        }
        public override void add(Person person)
        {
            people.Add(person);
        }
        public override void remove(Person person)
        {
            people.Remove(person);
        }
        public override IEnumerator createIterator()
        {
            if (iterator == null) iterator = new CompositeIterator();
            return iterator;
        }
    }
}
