using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama;

public class Metot1
{
    public void EkranaYazdır(string veri)
    {
        Console.WriteLine("Dans " + veri);
    }
    public int ArttırVeTopla(int x, int y)
    {
        x += 1;
        y += 1;
        return x + y;
    }
    public int ArttırVeToplaRef(ref int x,ref int y)
    {
        x += 1;
        y += 1;
        return x + y;
    }

}
