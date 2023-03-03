double [,] arrey(int m,int n) {
    double [,] mass = new double [m,n];
    for (int i =0; i<m; i++){
        for (int j=0; j<n;j++){
            double d = Math.Round(new Random().NextDouble(), 1);
            mass[i,j]=new Random().Next(-10,11)+d;
        }
    }
return mass;
}
void print (double [,] mass){
    for (int i =0; i<mass.GetLength(0); i++){
        for (int j=0; j<mass.GetLength(1); j++){
            Console.Write(mass[i,j]+" ");
        }
    Console.WriteLine();
    }
}

Console.Clear();									
Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine());						
Console.WriteLine("Введите колличество элементов");
int n = int.Parse(Console.ReadLine());
print(arrey(m,n));
