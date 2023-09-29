/*
 * funcionesNecesarias.c
 *
 *  Created on: 17 sep. 2022
 *      Author: santy
 */

#include "funcionesNecesarias.h"



int calcularPromedio(float* pResultado, float total, int cantidad)
{
	int ret=-1;
	if (cantidad!=0)
	{
		*pResultado = total / cantidad;
		ret=1;
	} else
	{
		*pResultado = 0;
	}
	return ret;
}

int calcularPorcentaje (float* pResultado, float numeroAAumentar, int porcentaje)
{
	int ret=-1;

	if(numeroAAumentar>=0 && porcentaje >=0)
	{
	*pResultado= numeroAAumentar * porcentaje / 100;
	ret= 1;
	}

	return ret;
}

int calcularAcumulador(eLibro libro[], float* acumulador, int cantidadTotal, int estadoOcupado)
{
	float suma=0;
	int retorno=-1;

	for(int i = 0; i<cantidadTotal; i++)
	{
		if(libro[i].estado == estadoOcupado)
		{
			suma = suma + libro[i].precio;
		}
	}

	if (suma>=0)
	{
		*acumulador=suma;
		retorno = 1;
	}
	return retorno;
}

void contadorSuperiorAPromedio(eLibro libro[], float promedio, int *contador, int cantidadTotal, int estadoOcupado)
{
	int contadorInterno=0;

	for(int i = 0; i<cantidadTotal; i++)
	{
		if(libro[i].estado == estadoOcupado && promedio<libro[i].precio)
		{
			contadorInterno++;
		}
	}

		*contador=contadorInterno;
}

void contadorDeLibrosViejos (eLibro libro[], int cantidadTotal, int estadoOcupado, int fechaLimite, int *contador)
{
	int contadorInterno=0;

	for(int i = 0; i<cantidadTotal; i++)
	{
		if(libro[i].estado == estadoOcupado && fechaLimite>libro[i].fechaPublicacion.anio)
		{
			contadorInterno++;
		}
	}

		*contador=contadorInterno;
}

