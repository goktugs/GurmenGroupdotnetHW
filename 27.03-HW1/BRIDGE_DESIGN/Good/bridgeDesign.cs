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
            Console.WriteLine("Menemen Soðansýz Olur.");
        }
    }

    public class YesOnion : IInclOnion
    {
        public void InclOnion()
        {
            Console.WriteLine("Menemen Soðanlý Olur.");
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


    public abstract class Ýnsan
    {
        public void NefesAl()
        {
            Console.WriteLine("nefes alýndý");
        }

        protected readonly IInclOnion _ýnclOnion;
        protected readonly IInclCheese _ýnclCheese;

        protected Ýnsan(IInclOnion ýnclOnion, IInclCheese ýnclCheese)
        {
            _ýnclOnion = ýnclOnion;
            _ýnclCheese = ýnclCheese;
        }

        public void InclCheese()
        {
            _ýnclCheese.ArabaDurumu();
        }
        public void InclOnion()
        {
            _ýnclOnion.EvDurumu();
        }
    }

    public class Goko : Ýnsan
    {
        public Goko(IInclOnion ýnclOnion, IInclCheese ýnclCheese) : base(ýnclOnion, ýnclCheese)
        {
        }
    }

    public class Murat : Ýnsan
    {
        public Hasan(IInclOnion ýnclOnion, IInclCheese ýnclCheese) : base(ýnclOnion, ýnclCheese)
        {
        }
    }
}