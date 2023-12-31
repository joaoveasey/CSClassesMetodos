﻿//--------passagem de argumentos por valor----------

////valor de x permanecerá 20, pois as alterações feitas na cópia não afetam o valor original do chamador
////y receberá o valor de 20 e com isso fará (20 *= 2), recebendo o novo valor de 40.

//int x = 20;
//Console.WriteLine("O valor de x ANTES de passar por valor: " + x);

//Calculo calc = new Calculo();
//calc.Dobrar(x);

//Console.WriteLine("O valor de x DEPOIS de passar por valor: " + x); 


//Console.ReadKey();


//public class Calculo
//{
//    public void Dobrar(int y)
//    {
//        y *= 2;
//        Console.WriteLine("\nValor do parâmetro y no método Dobrar"+ y);
//    }
//}


//--------passagem de argumentos por referência (ref)----------

//valor de x será 40, assim como o de y, pois eles irão se referenciar ao mesmo espaço da memória (obtendo o mesmo valor)

//int x = 20;
//Console.WriteLine("O valor de x ANTES de passar por valor: " + x);

//Calculo calc = new Calculo();
//calc.Dobrar(ref x);

//Console.WriteLine("O valor de x DEPOIS de passar por valor: " + x);

//Console.ReadKey();


//public class Calculo
//{
//    public void Dobrar(ref int y)
//    {
//        y *= 2;
//        Console.WriteLine("\nValor do parâmetro y no método Dobrar" + y);
//    }
//}

//--------passagem de argumentos por referência (out)----------

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new(); 

double circunferencia = circulo.CalcularPerimetroArea(raio, out double area);


Console.WriteLine($"Área: {area}"); 
Console.WriteLine($"Perímetro da circunferência: {circunferencia}");


public class Circulo
{
    public double CalcularPerimetroArea(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio,2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}