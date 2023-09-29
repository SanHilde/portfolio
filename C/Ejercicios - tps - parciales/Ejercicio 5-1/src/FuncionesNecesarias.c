/*
 * funcionesNecesarias.c
 *
 *  Created on: 11 sep. 2022
 *      Author: santy
 */
#include "FuncionesNecesarias.h"
//funcion 1
int cargarNumeros(int array[], int tam)
{
	int retorno = 0;//Si el array está vació

	if(tam > 0)
	{
		//Carga de Números
		for(int i = 0; i<tam; i++)
		{
			printf("Ingrese el numero %d: ",i+1);
			scanf("%d",&array[i]);
		}

		retorno = 1;//Si salio bien
	}

	return retorno;
}

//funcion 2
int inicializarNumeros(int array[],int tam)
{
	int retorno = 0;//Si el array está vació

	if(tam > 0)
	{
		//Carga de Números
		for(int i = 0; i<tam; i++)
		{
			array[i] = 0;
		}
	}
	retorno = 1;//Si salio bien

	return retorno;
}

//funcion 3, muestra los numeros en lista
void mostrarNumerosLista(int array[],int tam)
{
	printf("Los numeros son: ");

	for(int i = 0; i<tam; i++)
	{
		printf("\n%d",array[i]);
	}
}
