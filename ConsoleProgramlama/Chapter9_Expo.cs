using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramlama;

public class Chapter9_Expo
{
  public int Expo(int sayi, int üs)
    { 
        if(üs<2)
            return sayi;
        return Expo(sayi,üs-1)*sayi;
    
    
    }

}

public static class Extension
{
    public static bool CheckSpace(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(' ');
        return string.Join("-", dizi);
    }
}
