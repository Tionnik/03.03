int [,] arrey(int m,int n) {
    int [,] mass = new int [m,n];
    for (int i =0; i<m; i++){
        for (int j=0; j<n;j++){
            mass[i,j]=new Random().Next(-10,11);
        }
    }
//print(mass);
return mass;
}
void math(int [,] mass){
//Console.WriteLine();
    for (int j =0; j<mass.GetLength(0); j++){
        int sum =0;
        for (int i=0; i<mass.GetLength(1);i++){
            sum= sum+mass[i,j];
        }
    Console.Write(Math.Round((double) sum/mass.GetLength(0), 1)+"; ");
    }
}
/*
void print (int [,] mass){
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            Console.Write(mass[i,j]+" ");
        }
    Console.WriteLine();
    }
}*/

Console.Clear();									
Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine());						
Console.WriteLine("Введите колличество элементов");
int n = int.Parse(Console.ReadLine());
math(arrey(m,n));