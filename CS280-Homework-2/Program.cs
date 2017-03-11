using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入一隻Pokemon:\n");
            Pokemon[] pokemons = new Pokemon[6];
            pokemons[0] = new Pokemon();
            Console.Write("Name:");
            try
            {
                pokemons[0].Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("==輸入錯誤,請重新輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }
            pokemons[1] = new Pokemon();

            Console.Write("NationalNO:");
            try
            {
                pokemons[1].Num = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("==輸入錯誤,請重新輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }

            pokemons[2] = new Pokemon();

            Console.Write("Abilities:");
            try
            {
                pokemons[2].Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("==輸入錯誤,請重新輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }
            pokemons[3] = new Pokemon();

            Console.Write("Height:");
            try
            {
                pokemons[3].Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("==請重新輸入,不能輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }
            pokemons[4] = new Pokemon();

            Console.Write("Weight:");
            try
            {
                pokemons[4].Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("==請重新輸入,不能輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }
            pokemons[5] = new Pokemon();

            Console.Write("Gender:");
            try
            {
                pokemons[5].Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("==輸入錯誤,請重新輸入字串==");
                Console.WriteLine("********錯誤訊息******** \n" + (e.ToString()));
                return;
            }
            Console.WriteLine("名字:" + pokemons[0].Name);
            Console.WriteLine("編號:" + pokemons[1].Num);
            Console.WriteLine("技能:" + pokemons[2].Abilities);
            Console.WriteLine("高度:" + pokemons[3].Height);
            Console.WriteLine("重量:" + pokemons[4].Weight);
            Console.WriteLine("性別:" + pokemons[5].Gender);
        }
    }
}