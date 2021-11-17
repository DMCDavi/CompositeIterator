using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator
{
    public abstract class Person
    {
        public string name;
        public bool artist;
        public abstract int attribute();
        public abstract void print();
        public virtual void add(Person person)
        {
            throw new NotImplementedException();
        }
        public virtual void remove(Person person)
        {
            throw new NotImplementedException();
        }
        public virtual bool isArtist()
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerator createIterator()
        {
            throw new NotImplementedException();
        }
    }
}
