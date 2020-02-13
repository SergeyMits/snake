using System;

namespace snake
{
    public class Sym
    {
        public char sym1;
        public char sym2;

        public Sym()
        {
        }

        public Sym (char _sym1, char _sym2)
        {
            sym1 = _sym1;
            sym2 = _sym2;
        }

        public void DrawSym()
        {
            Console.Write(sym2);
            Console.Write(sym1);
        }
    }
}
