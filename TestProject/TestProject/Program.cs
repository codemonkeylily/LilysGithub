using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static bool quit = false;
        static void Function()//一个程序的主入口 也就是第一个执行的内容
        {
            Console.WriteLine("Hi！");//
            while(!quit)
            {
                string data = Console.ReadLine();
                Console.WriteLine(GetData(data)); 
            } 
             
        }

        static string GetData(string data)
        {
            string returndata = "";
            switch(data)
            {
                case "你好":
                    returndata = "你也好啊";
                    break;
                case "你叫什么名字":
                    returndata = "我叫庄晓晓";
                    break;
                case "退出":
                    quit = true;
                    break;
                default:
                    returndata = "你在说什么啊？";
                    break;
            }
            return returndata;
        }
        static void Main(string[] args)
        {
             Function();
        }
    }
}
