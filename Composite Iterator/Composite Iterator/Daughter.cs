using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Iterator
{
    class Daughter : Person
    {
        public Daughter(bool artist, string name)
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
            if(artist) Console.WriteLine($"{name} é uma filha artista");
            else Console.WriteLine($"{name} é uma filha não artista");
        }
        public override bool isArtist()
        {
            return artist;
        }
    }
}
