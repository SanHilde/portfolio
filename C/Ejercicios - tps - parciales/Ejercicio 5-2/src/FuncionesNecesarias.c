/*
 * funcionesNecesarias.c
 *
 *  Created on: 11 sep. 2022
 *      Author: santy
 */
#include "FuncionesNecesarias.h"
//funcion 1
int cargarArrayValorUnico(int valorUnico, int array[], int tam)
{
	int retorno = 0;//Si el array está vació

	if(tam > 0)
	{
		//Carga de Números
		for(int i = 0; i<tam; i++)
		{
			array[i]=valorUnico;
		}

		retorno = 1;//Si salio bien
	}

	return retorno;
}

//funcion 2
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

//funcion 3
void validarDistintoDeUnNumero (int valorValidado, int array[], int tam)
{
	for(int i = 0; i<tam; i++)
		{
		while (array[i]==valorValidado)
		{
		printf ("Reingrese el numero %d, fuera del valor pautado: ", i+1);
		scanf ("%d", &array[i]);
		}
		}
}

//funcion 4
void validarEntreDosNumeros (int valorMinimo, int valorMaximo, int array[], int tam)
{
	for(int i = 0; i<tam; i++)
		{
		while (array[i]<valorMinimo || array[i]>valorMaximo)
		{
		printf ("Reingrese el numero %d, entre los valores pautados: ", i+1);
		scanf ("%d", &array[i]);
		}
		}
}

//funcion 5, muestra los numeros en lista
void mostrarNumerosLista(int array[],int tam)
{
	printf("\nLos numeros son: ");

	for(int i = 0; i<tam; i++)
	{
		printf("\n%d",array[i]);
	}
}

//funcion 6
void mostrarNumerosListaPares(int array[],int tam)
{
	printf("\nLos numeros pares son: ");

	for(int i = 0; i<tam; i++)
	{
			if (array[i]%2==0)
			{
				printf("\n%d",array[i]);
			}
	}
}

//funcion 7
void mostrarUbicacionListaimpares(int array[],int tam)
{
	printf("\nLa ubicacion de los impares son: ");

	for(int i = 0; i<tam; i++)
	{
			if (array[i]%2!=0)
			{
				printf("\n%d",i+1);
			}
	}
}

//funcion 8
int busquedaMenorNegativo(int array[],int tam)
{
	int numero;
	int bandera=0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]<0)
			{
				if (bandera==0 || numero>array[i])
				{
				numero=array[i];
				bandera=1;
				}
			}
	}
	return numero;
}

//funcion 9
int busquedaMayorImpar(int array[],int tam)
{
	int numero;
	int bandera=0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]%2!=0)
			{
				if (bandera==0 || numero<array[i])
				{
				numero=array[i];
				bandera=1;
				}
			}
	}
	return numero;
}

//funcion 10
void localizadorRepetidos(int array[],int tam)
{
	int i;
		int j;
		int aux;
		int contador=0;

		for(i=0;i<tam-1;i++)
		{
			for(j=i+1;j<tam;j++)
			{
					if(array[i]>array[j])
					{
						aux=array[i];
						array[i]=array[j];
						array[j]=aux;
					}
			}
		}

		for(i=0;i<tam-1;i++)
		{
		if (array[i]==array[i+1])
		{
		contador++;
		} else {
		printf ("\nEl numero %d se repitio %d vez/ veces", array[i], contador);
		contador=0;
		}
		}
		if (contador>0)
				{
					printf ("\nEl numero %d se repitio %d vez/ veces", array[i], contador);
				}
}

//funcion 11
void mostrarPositivosOrdenadosCreciente(int array[],int tam)
{

	int i;
	int j;
	int aux;

	for(i=0;i<tam-1;i++)
	{
		for(j=i+1;j<tam;j++)
		{
				if(array[i]>array[j])
				{
					aux=array[i];
					array[i]=array[j];
					array[j]=aux;

				}
		}
	}



	printf( "\nLos numeros positivos ordenados de forma creciente: ");
	for(i=0 ; i<tam;i++)
	{
		if (array[i]>0)
			{
			printf( "%d, ", array[i]);
			}
	}


}

//funcion 12
void mostrarNegativosOrdenadosDecreciente(int array[],int tam)
{

	int i;
	int j;
	int aux;

	for(i=0;i<tam-1;i++)
	{
		for(j=i+1;j<tam;j++)
		{
				if(array[i]<array[j])
				{
					aux=array[i];
					array[i]=array[j];
					array[j]=aux;

				}
		}
	}



	printf( "\nLos numeros negativos ordenados de forma decreciente: ");
	for(i=0 ; i<tam;i++)
	{
		if (array[i]<0)
			{
			printf( "%d, ", array[i]);
			}
	}


}


