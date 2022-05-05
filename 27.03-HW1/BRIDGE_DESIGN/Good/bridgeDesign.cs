using System;

namespace BRIDGE_DESIGN.bridgeDesign
{

    public interface IInclOnion
    {
        public void InclOnion();
    }
    public interface IInclCheese
    {
        public void InclCheese();
    }


    public class NoOnion : IInclOnion
    {
        public void InclOnion()
        {
            Console.WriteLine("Menemen So�ans�z Olur.");
        }
    }

    public class YesOnion : IInclOnion
    {
        public void InclOnion()
        {
            Console.WriteLine("Menemen So�anl� Olur.");
        }
    }

    public class YesCheese : IInclCheese
    {
        public void InclCheese()
        {
            Console.WriteLine("Menemen Peynirli Olur.");
        }
    }

    public class NoCheese : IInclCheese
    {
        public void InclCheese()
        {
            Console.WriteLine("Menemen Peynirsiz Olur. ");
        }
    }


    public abstract class �nsan
    {
        public void NefesAl()
        {
            Console.WriteLine("nefes al�nd�");
        }

        protected readonly IInclOnion _�nclOnion;
        protected readonly IInclCheese _�nclCheese;

        protected �nsan(IInclOnion �nclOnion, IInclCheese �nclCheese)
        {
            _�nclOnion = �nclOnion;
            _�nclCheese = �nclCheese;
        }

        public void InclCheese()
        {
            _�nclCheese.ArabaDurumu();
        }
        public void InclOnion()
        {
            _�nclOnion.EvDurumu();
        }
    }

    public class Goko : �nsan
    {
        public Goko(IInclOnion �nclOnion, IInclCheese �nclCheese) : base(�nclOnion, �nclCheese)
        {
        }
    }

    public class Murat : �nsan
    {
        public Hasan(IInclOnion �nclOnion, IInclCheese �nclCheese) : base(�nclOnion, �nclCheese)
        {
        }
    }
}