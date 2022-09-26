using System.Runtime;
using System.Runtime.CompilerServices;



//class VGA
class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}
class Nvidia : Vga
{
    public Nvidia(string merk) : base(merk)
    {
        merk = "Nvidia";
    }
}
class Amd : Vga
{
    public Amd(string merk) : base(merk)
    {
        merk = "Amd";
    }
}


//Processor
class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk)
    {
        this.merk = merk;
    }
}
class Intel : Processor
{
    public Intel(string merk) : base(merk)
    {
        merk = "Intel";
    }
}
class CoreI3 : Intel
{
    public CoreI3(string merk) : base(merk)
    {

        base.tipe = "Core I3";
    }
}
class CoreI5 : Intel
{
    public CoreI5(string merk) : base(merk)
    {
        base.tipe = "Core I5";
    }
}
class CoreI7 : Intel
{
    public CoreI7(string merk) : base(merk)
    {
        base.tipe = "Core I7";
    }
}

class PAMD : Processor
{
    public PAMD(string merk): base(merk)
    {
        merk = "AMD";
    }
}
class Ryzen : PAMD
{
    public Ryzen(string merk) : base(merk)
    {
        base.tipe = "RYZEN";
    }
}
class Athlon : PAMD
{
    public Athlon(string merk) : base(merk)
    {
        base.tipe = "ATHLON";
    }
}


class Laptop
{
    public string Merk;
    public string Tipe;
    public Processor processor;
    public Vga vga;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe} menyala ");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe}  mati ");
    }
}



class ASUS : Laptop
{
    public ASUS(string merk, string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
    {
    }

}
class ROG : ASUS
{
    public ROG(string merk, string tipe, Vga vga, Processor processor) : base(merk, "ROG", vga, processor)
    {
    }

}
class Vivobook : ASUS
{
    public Vivobook(string merk, string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor )
    {
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string merk, string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
    {
    }

}
class Swift : ACER
{
    public Swift(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Swift", vga, processor)
    {
    }

}
class Predator : ACER
{
    public Predator(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Predator", vga, processor)
    {
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.Merk} {this.Tipe} sedang bermain game");
    }

}

class Lenovo : Laptop
{
    public Lenovo(string merk, string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
    {
    }

}
class IdeaPad : Lenovo
{
    public IdeaPad(string merk, string tipe, Vga vga, Processor processor) : base(merk, "IdeaPad", vga, processor)
    {
    }

}
class Legion : Lenovo
{
    public Legion(string merk, string tipe, Vga vga, Processor processor) : base(merk, "Legion", vga, processor)
    {
    }

}


namespace TugasPBOPR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vga vga1 = new Vga("Vga Nvidia");
            Vga vga2 = new Vga("Vga AMD");
            Processor processor1 = new Processor("Ryzen");
            Processor processor2 = new Processor("Core I5");
            Processor processor3 = new Processor("Core I7");


            Laptop Laptop1 = new Vivobook("ASUS", "Vivobook", vga1, processor2);
            //Laptop1.Ngoding() 
            ((Vivobook)Laptop1).Ngoding(); //SOAL 2 alternatif

            Laptop Laptop2 = new IdeaPad("Lenovo", "Ideapad", vga2, processor1);
            Laptop2.LaptopDinyalakan(); //SOAL 1
            Laptop2.LaptopDimatikan();

            //SOAL 3
            Console.WriteLine(Laptop1.vga.merk + Laptop1.processor.merk + Laptop1.processor.tipe);
            Console.WriteLine();

            Predator predator = new Predator("ACER", "Predator", vga2, processor3);
            //SOAL 4 
            predator.BermainGame();
            Console.WriteLine();

            //SOAL 5
            ACER acer = predator;
            ((Predator)acer).BermainGame();

        }
    }
}

