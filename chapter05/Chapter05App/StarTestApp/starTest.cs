﻿using System;

namespace StarTestApp
{
    class starTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("별모양 찍기!");

            #region 첫번째 별모양
            for (int i = 0; i < 5; i++)          //행
            {
                for (int j = 0; j < i + 1; j++)      //열
                {
                    Console.Write("*");
                }
                Console.WriteLine(""); 
            }
            
            #endregion


            #region 두번째 별모양
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" "); 
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine(""); 
            }
            #endregion


            #region 세번째 별모양


            #endregion

        }
    }
}
