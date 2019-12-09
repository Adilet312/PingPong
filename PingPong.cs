// using System;

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("Hello World");
//   }
// }
using System;
class Program{
    static void Main(){
        Console.WriteLine("Please enter number: ");
        int number = int.Parse(Console.ReadLine());
        for(int input=1; input<=number; input++){
            if( input%3==0 && input%5==0){
                Console.WriteLine("ping-pong");
            }
            else if(input%3==0){
                Console.WriteLine("ping");
            }
            else if(input%5==0){
                Console.WriteLine("pong");
            }
            else{
                Console.WriteLine(input);
            }
        }

    }
}