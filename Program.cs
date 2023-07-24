﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace MiPrograma{
    class Programa{
        public static Dictionary<char, int> dict = new Dictionary<char,int>()
            {
                {'A', 0},
                {'B', 1},
                {'C', 2},
                {'D', 3},
                {'E', 4},
                {'F', 5},
                {'G', 6},
                {'H', 7},
            };
        public static int?[,] caballo(int[] posicion){
            int?[,] tablero = { 
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0},
            }; 
            int posicionX = posicion[0];
            int posicionY = posicion[1];
            
            List<string> list = new List<string>();
            int[,] arr = {{2, 1}, {1, 2}, {-1,2}, {-2,1},{2,-1},{1,-2},{-1,-2}, {-2,-1}};
            for(int j = 0; j <  arr.Length; j++ ){
                try{
                  int posXAct = posicionX + arr[j,0];
                  int posYAct = posicionY+arr[j,1];
                        tablero[posYAct,posXAct] = 1;
                    
                }catch(IndexOutOfRangeException){
                    
                }
            }
            tablero[posicionY,posicionX] = 2;
            return tablero;
        }
        public static void Main(string[] args){
            Console.WriteLine("escriba la posicion");
            string? input = Console.ReadLine();
            char X = input[0];
            char? Y = input[1];
            int posX = dict[X];
            int posY = int.Parse(Y.ToString());
            Console.WriteLine(posX + " " + posY);
            int?[,] arr = caballo(new int[]{posX,posY - 1});
            int index1 = arr.GetLength(0);
            int index2 = arr.GetLength(1);

            for(int i = 0; i < index1 ;i++ ){
                for(int j = 0; j < index2; j++){
                    if(arr[i,j] == 0){
                        Console.Write("[ ]");
                    }
                    else if(arr[i,j] == 1){
                        Console.Write("[1]");
                    }
                    else if(arr[i,j] == 2){
                        Console.Write("[C]");
                    }
                }
                Console.WriteLine();
            }
        }
        
        
    }
}
