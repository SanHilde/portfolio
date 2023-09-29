/*
 * OperacionesSimples.c
 *
 *  Created on: 31 ago. 2022
 *      Author: santy
 */
#include "OperacionesSimples.h"

//funcion 1
int calcularFactorial (int numeroIngresado)
{
int resultado=1;

if (numeroIngresado== 1 || numeroIngresado==0)
{
	return resultado;
} else
{
	for (  ;numeroIngresado>1 ;numeroIngresado--)
	{
	resultado = resultado * numeroIngresado;
	}
}
return resultado;
}

//funcion 2
int acumularNumeros(int array[],int tam)
{
	int suma;
	suma = 0;

	for(int i = 0; i<tam; i++)
	{
		suma = suma + array[i];
	}

	return suma;
}

//funcion 3 (muestra numeros acumulados)


//funcion 4
int contarNumeros(int array[],int tam)
{
	int contador;
	contador = 0;

	for(int i = 0; i<tam; i++)
	{
		contador++;
	}

	return contador;
}

//funcion 5
float calcularPromedio(int suma, int contador)
{
	float promedio;

	promedio = (float)suma / contador;

	return promedio;
}
