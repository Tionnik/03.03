int arrey(int m,int n) {
    int [,] mass = new int [10,10];
    for (int i =0; i<10; i++){
        for (int j=0; j<10;j++){
            mass[i,j]=new Random().Next(-10,11);
        }
    }
int A = mass[m-1,n-1];
//print(mass);
return A;
}
/*
void print (int [,] mass){
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            Console.Write(mass[i,j]+" ");
        }
    Console.WriteLine();
    }
}
*/
Console.Clear();									
Console.WriteLine("Введите номер строки");
int m = int.Parse(Console.ReadLine());						
Console.WriteLine("Введите номер элемента");
int n = int.Parse(Console.ReadLine());
if (m>10 || n>10){                                                          //Если позиция != индекс
    Console.WriteLine("такого числа в массиве нет");}
    else Console.WriteLine(arrey(m,n));

