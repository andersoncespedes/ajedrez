// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace MiPrograma{
    class Programa{
        public static string[] caballo(int[] posicion){
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
            Dictionary<int, string> dict = new Dictionary<int,string>()
            {
                {0, "A"},
                {1, "B"},
                {2, "C"},
                {3, "D"},
                {4, "E"},
                {5, "F"},
                {6, "G"},
                {7, "H"},
            };
            int posicionX = posicion[0];
            int posicionY = posicion[1];
            tablero[posicionX,posicionY] = 1;
            List<string> list = new List<string>();
            int[,] arr = {{2, 1}, {1, 2}, {-1,2}, {-2,1},{2,-1},{1,-2},{-1,-2}, {-2,-1}};
            for(int j = 0; j <  arr.Length; j++ ){
                try{
                    if(tablero[posicionX + arr[j,0],posicionY+arr[j,1]] != null){
                        tablero[posicionX + arr[j,0],posicionY+arr[j,1]] = 1;
                        list.Add(dict[posicionX + arr[j,0]] + (posicionX + arr[j,1]).ToString());
                    }
                }catch(IndexOutOfRangeException){
                    
                }
            }
            
            return list.ToArray();
        }
        public static void Main(string[] args){
            foreach(string i in caballo(new int[]{0,0})){
                Console.WriteLine(i);
            }
        }
        
        
    }
}
