using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozyt.MenuObiadowe
{
    public abstract class MenuSkładnik
    {
        public virtual void Dodaj(MenuSkładnik menuSkładnik)
        {
            throw new InvalidOperationException(); 
        }

        public virtual void Usuń(MenuSkładnik menuSkładnik)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuSkładnik PobierzPotomek(int i)
        {
            throw new InvalidOperationException();
        }



        public virtual string PobierzNazwa()
        {
            throw new InvalidOperationException();
        }

        public virtual string PobierzOpis()
        {
            throw new InvalidOperationException();
        }

        public virtual double PobierzCena()
        {
            throw new InvalidOperationException();
        }

        public virtual bool JestWegetariańska()
        {
            throw new InvalidOperationException();
        }



        public virtual void Drukuj()
        {
            throw new InvalidOperationException();
        }
    }
}
