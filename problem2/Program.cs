// See https://aka.ms/new-console-template for more information
 int i = int.Parse(Console.ReadLine());
 int j = int.Parse(Console.ReadLine());
 int k = int.Parse(Console.ReadLine());
 
 int max = i;

 if (j > max){
      max = j;
    } 
if (k > max){
    max = k;
 }

 Console.WriteLine(max);
