/*
 ============================================================================
 Name        : Ejercicio.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style

Realizar el ordenamiento de un vector de enteros. Para ello deberán crear una función que se
encargue de realizar el intercambio de los dos valores que se van a ordenar (función swap), que
solo puede recibir dos parámetros.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int intercambio (int *valorUno, int *valorDos);
int main(void) {
	setbuf (stdout,NULL);

	int valores[2]= {5,9};
//	int *valorUno=valores[0];
	//int *valorDos=valores[1];

	printf ("valor 1: %d, valor 2: %d", valores[0], valores[1]);
	if(intercambio (&valores[0],&valores[1])==1)
	{
		printf ("\nvalor 1: %d, valor 2: %d", valores[0], valores[1]);
	}


	return EXIT_SUCCESS;
}

int intercambio (int *valorUno, int *valorDos)
{
	int retorno = 1;
	int aux;

	aux = *valorDos;
	*valorDos = *valorUno;
	*valorUno = aux;


return retorno;
}
