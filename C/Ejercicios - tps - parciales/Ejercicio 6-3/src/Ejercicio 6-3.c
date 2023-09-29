/*
 ============================================================================
 Name        : Ejercicio.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define SIZE 30

int main(void) {

	setbuf (stdout,NULL);
    char nombre [SIZE];
    char apellido [SIZE];
    char auxiliar [SIZE*2];


    printf ("Ingrese nombre/s: ");
    fflush(stdin);
	scanf("%[^\n]",nombre);
	strlwr (nombre);
	nombre[0]= toupper (nombre[0]);

	for (int i=0; i<SIZE; i++)
	{//printf ("%d", nombre [i]);
		if (nombre[i]== ' ')
		//	printf ("%d", nombre [i]);
					{
					nombre[i+1]= toupper (nombre[i+1]);
					}
	}

	printf("Ingrese apellido/s: ");
	fflush(stdin);
	scanf("%[^\n]",apellido);
	strlwr (apellido);
	apellido[0]= toupper (apellido[0]);


	strcpy(auxiliar,apellido);
	strcat(auxiliar, ", ");
	strcat(auxiliar,nombre);
	printf ("Persona ingresada: %s", auxiliar);

}
/*
int busquedaEspacio(int array[],int tam)
{
	int numero;
	int bandera=0;

	for(int i = 0; i<tam; i++)
	{
		if (array[i]== ' ')
			{
			nombre[i+1]= toupper (nombre[0]);
			}
	}

	return numero;
}
*/
