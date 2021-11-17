using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator
{
    class CompositeIterator : IEnumerator
    {
        public Stack<IEnumerator> stack = new Stack<IEnumerator>();
        public object Current => throw new NotImplementedException();

        public CompositeIterator(IEnumerator iterator)
        {
            stack.Push(iterator);
        }

        public bool MoveNext()
        {
            IEnumerator iterator = stack.Peek();
            iterator.MoveNext();
            Person person = (Person)iterator.Current;
            if(person.GetType() == typeof(Mother))
            {
                stack.Push(person.createIterator());
                return true;
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
