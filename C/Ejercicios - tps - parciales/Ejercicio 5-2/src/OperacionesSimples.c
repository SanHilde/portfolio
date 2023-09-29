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
	return resultado;
}
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

//funcion 3
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

//funcion 4
float calcularPromedio(int suma, int contador)
{
	float promedio;

	promedio = (float)suma / contador;

	return promedio;
}

//funcion 5
int contarNumerosPositivos(int array[],int tam)
{
	int contador;
	contador = 0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]>0)
			{
			contador++;
			}
	}

	return contador;
}

//funcion 6
int acumularNumerosPositivos(int array[],int tam)
{
	int suma;
	suma = 0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]>0)
		{
		suma = suma + array[i];
		}
	}

	return suma;
}

//funcion 7
int sumaAntesesoresHastaValor(int valorHastaAntesesores,int numeroATrabajar)
{
	int suma=0;
	for(int i=numeroATrabajar; i<valorHastaAntesesores; i++)
		{
		suma=suma+i;
		}
	return suma;
}

//funcion 8
int contarNumerosNegativos(int array[],int tam)
{
	int contador;
	contador = 0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]<0)
			{
			contador++;
			}
	}

	return contador;
}
//funcion 9
int acumularNumerosPares(int array[],int tam)
{
	int suma;
	suma = 0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]%2==0)
		{
		suma = suma + array[i];
		}
	}

	return suma;
}
//funcion 10

//funcion 11

//funcion 12

//funcion 13
