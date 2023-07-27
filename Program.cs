// See https://aka.ms/new-console-template for more information
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
        public static string?[,] caballo(int[] posicion){
            string?[,] tablero = { 
                { "A1","B1","C1","D1","E1","F1","G1","H1"},
                { "A2","B2","C2","D2","E2","F2","G2","H2"},
                { "A3","B3","C3","D3","E3","F3","G3","H3"},
                { "A4","B4","C4","D4","E4","F4","G4","H4"},
                { "A5","B5","C5","D5","E5","F5","G5","H5"},
                { "A6","B6","C6","D6","E6","F6","G6","H6"},
                { "A7","B7","C7","D7","E7","F7","G7","H7"},
                { "A8","B8","C8","D8","E8","F8","G8","H8"},

            }; 
            int posicionX = posicion[0];
            int posicionY = posicion[1];
            
            List<string> list = new List<string>();
            int[,] arr = {{2, 1}, {1, 2}, {-1,2}, {-2,1},{2,-1},{1,-2},{-1,-2}, {-2,-1}};
            for(int j = 0; j <  arr.Length; j++ ){
                try{
                  int posXAct = posicionX + arr[j,0];
                  int posYAct = posicionY+arr[j,1];
                        tablero[posYAct,posXAct] = "X";
                    
                }catch(IndexOutOfRangeException){
                    
                }
            }
            tablero[posicionY,posicionX] = "X";
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
            string?[,] arr = caballo(new int[]{posX,posY - 1});
            int index1 = arr.GetLength(0);
            int index2 = arr.GetLength(1);

            for(int i = 0; i < index1 ;i++ ){
                for(int j = 0; j < index2; j++){
                    if(arr[i,j] == "X"){
                        Console.Write("  X ");
                    }
                    else if(arr[i,j] == "X"){
                        Console.Write("  X ");
                    }else{
                        Console.Write($" {arr[i,j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        
    }
}
