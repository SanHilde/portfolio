/*
 ============================================================================
Hildebrandt Santiago
DIV K
Ejercicio 5-2
Pedir el ingreso de 10 números enteros entre -1000 y 1000. Determinar:
a) Cantidad de positivos y negativos.
b) Sumatoria de los pares.
c) El mayor de los impares.
d) Listado de los números ingresados.
e) Listado de los números pares.
f) Listado de los números de las posiciones impares.
Anexo 5-2
g) Los números que se repiten
h) Los positivos creciente y los negativos de manera decreciente
Se deberán utilizar funciones y vectores.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "OperacionesSimples.h"
#include "FuncionesNecesarias.h"
#define SIZE 10
/*
void validarEntreDosNumeros (int valorMinimo, int valorMaximo, int array[], int tam);
int contarNumerosPositivos(int array[],int tam);
int contarNumerosNegativos(int array[],int tam);
int acumularNumerosPares(int array[],int tam);
int busquedaMayorImpar(int array[],int tam);
void mostrarNumerosListaPares(int array[],int tam);
void mostrarUbicacionListaimpares(int array[],int tam);
void localizadorRepetidos(int array[],int tam);
void mostrarPositivosOrdenadosCreciente(int array[],int tam);
void mostrarNegativosOrdenadosDecreciente(int array[],int tam);
*/
int main(void)
{
	setbuf(stdout,NULL);

	int numeros[SIZE];
	int valorMinimoValidacion=-1000;
	int valorMaximoValidacion=1000;
	int contadorPositivos;
	int contadorNegativos;
	int sumaPares;
	int mayorImpar;

	//InicializarNumeros(numeros,SIZE);
	//MostrarNumeros(numeros,SIZE);


	if(cargarNumeros(numeros,SIZE) == 1)
	{
		printf("Se cargo el array.\n");
		validarEntreDosNumeros (valorMinimoValidacion,valorMaximoValidacion,numeros,SIZE);
		contadorPositivos= contarNumerosPositivos (numeros,SIZE);
		contadorNegativos= contarNumerosNegativos (numeros,SIZE);
		sumaPares = acumularNumerosPares(numeros,SIZE);
		mayorImpar = busquedaMayorImpar(numeros,SIZE);

		printf("La cantidad de positivos es: %d\n", contadorPositivos);
		printf("La cantidad de negativos es: %d\n", contadorNegativos);
		printf("La suma de los numeros pares es: %d\n", sumaPares);
		printf("El mayor numero impar es: %d", mayorImpar);
		mostrarNumerosLista(numeros,SIZE);
		mostrarNumerosListaPares(numeros,SIZE);
		mostrarUbicacionListaimpares (numeros,SIZE);
		localizadorRepetidos (numeros,SIZE);
		mostrarPositivosOrdenadosCreciente (numeros,SIZE);
		mostrarNegativosOrdenadosDecreciente (numeros,SIZE);



	}
	else
	{
		printf("Hubo un error al cargar el array.");
	}

	return 0;
}
/*
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
//return 1;
}

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


*/

