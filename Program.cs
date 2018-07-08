using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i=0,fw=0,bw=0;//一个运算符连的2个数分别为fw bw
            int operator1=0;//运算符
            int fb=0;//当前是qian还是hou的标记 0为fw 1为bw
            int total=0;//算式结果
            int[] operations= new int[8];//8个可能的运算符插入位，0表没有，1表加法，2表减法
           for(operations[0]=0; operations[0]<3; operations[0]++)//1 2间的运算符
              for(operations[1]=0; operations[1]<3; operations[1]++)//2 3间的运算符
                 for(operations[2]=0; operations[2]<3; operations[2]++)//3 4间的运算符
                    for(operations[3]=0; operations[3]<3; operations[3]++)//4 5间的运算符
                       for(operations[4]=0; operations[4]<3; operations[4]++)//5 6间的运算符
                           for(operations[5]=0; operations[5]<3; operations[5]++)//6 7间的运算符
                              for(operations[6]=0; operations[6]<3; operations[6]++)//7 8间的运算符
                                 for(operations[7]=0; operations[7]<3; operations[7]++)//8 9间的运算符
                                 {
                                     //重置
                                     fw=1;//第一个数
                                     operator1=0;
                                     fb = 0;
                                     total = 0;

                                     //开始运算
                                     for (i = 0; i < 8; i++)
                                         {
                                               //无运算符
                                             if (operations[i] == 0)
                                                {
                                                  if (fb == 0) fw = fw * 10 + (i + 2);
                                                  else bw = bw * 10 + (i + 2);
                                                }
                                             //遇到了新运算符
                                           else
                                              {
                                                   //完成前一运算符的计算，结果为qian，依然取hou
                                                 if (fb == 1)
                                                    {
                                                       total = fw + operator1 * bw;
                                                       fw = total;
                                                       bw = i + 2;
                                                    }
                                                   //开始取hou数
                                                 else
                                                    {
                                                      fb = 1;
                                                      bw = i + 2;
                                                    }
                                                   //更新运算符
                                                if (operations[i] == 1) operator1 = 1;
                                                else operator1 = -1;
                                              }
                                            }
                                       //完成最后一个运算
                                    total = fw + operator1 * bw;
                                   //输出
                                 if (total == 100)
                                 {
                                     for (i = 0; i < 9; i++)
                                     {
                                         Console.Write(i + 1);
                                         if (i < 8 && operations[i] == 1)
                                         {
                                             Console.Write("+");
                                         }
                                         else if (i < 8 && operations[i] == 2)
                                         {
                                             Console.Write("-");
                                         }

                                     }
             
                                   Console.WriteLine("={0}", total);
                             }
             }
           Console.ReadKey();
        }
 }
             
       
    

}
