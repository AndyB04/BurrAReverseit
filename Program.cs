// Andrea Burr
// 10-20-2022
// Reverse it 
using System;

Console.Clear();
bool playagain = true;
while (playagain){
Console.WriteLine("Hello Player lets play reverse it ");


int[] intarray = { 1, 2 ,3, 4, 5};

Console.WriteLine(intarray [4] );
for(int  i = intarray.Length -1 ; i > 0; i-- ){
    Console.WriteLine(i);
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){
     playagain = false; 
  }else{
    playagain = true;
  }
}
    }