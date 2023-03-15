int[,] encuesta = new int[5, 10]; // matriz de 5 productos y 10 encuestados

// asignar valores a la matriz
encuesta[0, 0] = 5;
encuesta[0, 1] = 7;
encuesta[0, 2] = 8;
// ...
encuesta[4, 8] = 9;
encuesta[4, 9] = 10;

// calcular el promedio de las calificaciones para cada producto
for (int i = 0; i < 5; i++)
{
    double suma = 0;
    for (int j = 0; j < 10; j++)
    {
        suma += encuesta[i, j];
    }
    double promedio = suma / 10;
    Console.WriteLine("El promedio de calificaciones para el producto {0} es {1}.", i + 1, promedio);
}
