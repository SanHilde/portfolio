/*
 ============================================================================
Pedir cinco números y mostrarlos desde el último que pedi hasta el primero

Por ejemplo:

Pedí
3-5-2-4-7

Tengo que devolver
7-4-2-5-3

Haganlo con todo lo que saben hasta ahora.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#define TAM 5

int main(void) {

	setbuf (stdout,NULL);


int numero [TAM];

for (int i=0; i<TAM; i++)
{
	printf ("Ingrese un numero: ")	;
	scanf ("%d", &numero[i]);
}

printf ("Los numeros ingresados fueron: ");
for (int i=TAM-1; i>-1; i--)
{
	printf ("%d ", numero [i]);
}

}

