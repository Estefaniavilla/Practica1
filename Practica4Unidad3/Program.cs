int[] materias = new int[5];
Console.WriteLine("Agrega tu calificacion de las siguientes materias");
Console.WriteLine("Español:");
materias[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Matematicas");
materias[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Quimica");
materias[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Ciencias");
materias[3] = int.Parse(Console.ReadLine());
Console.WriteLine("Historia");
materias[4] = int.Parse(Console.ReadLine());

int suma = 0;
for (int i = 0; i < materias.Length; i++)
{
    suma += materias[i];
}
int resultado = suma * 2;
Console.WriteLine("La suma de las calificaciones es: " + resultado);

if (resultado > 70)
{
    Console.WriteLine("Aprobado!!");
}
else
{
    Console.WriteLine("Reprobado :(");
}
Console.ReadKey();