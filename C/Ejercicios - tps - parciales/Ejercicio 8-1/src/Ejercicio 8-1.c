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
//#include "inputs.h"
//#include "funcionesNecesarias.h"
//#include "abm.h"
#define CANT 5


typedef struct{
		int golesMetidos;
		int partidosJugados;
		float promedioGoles;
		char nombre[31];

	}eJugador;

int utn_getNumeroPositivo(int* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos);
int cargarJugador(eJugador jugador[],int tam,int indice, int minimo, int intentos);
int calcularPromedio(float* pResultado, int total, int cantidad);
int pedirCadena(char cadena[],int len,char mensaje[]);
void mostrarJugador(eJugador jugadores[],int indiceDelEmpleado, char* mensaje, char* mensajeError);

int main(void) {

	setbuf (stdout, NULL);

	int i=1;
	eJugador jugador[CANT];


	cargarJugador(jugador,CANT,i, 0, 3);

	mostrarJugador(jugador,i,"Nombre \t\t Partidos Jugados \t\t Goles metidos \t\t Promedio goles \n", "Ha habido un error");



	return EXIT_SUCCESS;
}

int utn_getNumeroPositivo(int* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos)
{
	int ret=-1;
	int num;

	if (mensaje !=NULL && mensajeError!= NULL && minimo >= 0 && intentos >= 0)
	{
		while(intentos>0)
		{
			printf("%s", mensaje);
			if(scanf("%d",&num)==1)
			{
				if(num>=minimo)
				{
					break;
				}
			}
				fflush(stdin);
				intentos--;
				printf("%s", mensajeError);
		}
			if(intentos!=0)
			{
				ret=1;
				*pResultado = num;
			}
	}

	return ret;
}

int cargarJugador(eJugador jugador[],int tam,int indice, int minimo, int intentos)
{
	int retorno;
	char mensajeError[] = ("El dato ingresado es incorrecto. Debe ser un numero mayor o igual a 0");
	//int aux;
	float auxFloat;
	retorno = 0;//Si la lista está llena

	//BuscarLibre(empleados,tam,&indiceDelEmpleado);

	if(indice > -1)
	{
		pedirCadena(jugador[indice].nombre,31,"Ingrese su nombre: ");
		utn_getNumeroPositivo(&jugador[indice].golesMetidos,"Ingrese la cantidad de goles metidos: ",mensajeError, minimo,intentos);
	//	jugador[indice].golesMetidos = aux;
		utn_getNumeroPositivo(&jugador[indice].partidosJugados,"Ingrese la cantidad de partidos jugados: ",mensajeError, minimo,intentos);
		//jugador[indice].partidosJugados = aux;
	    calcularPromedio(&auxFloat, jugador[indice].golesMetidos, jugador[indice].partidosJugados);
	    jugador[indice].promedioGoles = auxFloat;
	    retorno = 1;//TODO SALIO BIEN
	}
	return retorno;
}

int calcularPromedio(float* pResultado, int total, int cantidad)
{
	int ret=-1;
	if (cantidad!=0)
	{
		*pResultado = (float) total / cantidad;
		ret=1;
	}
	return ret;
}

int pedirCadena(char cadena[],int len,char mensaje[])
{
	int retorno;
	char buffer[1024];
	int largoBuffer;

	retorno = -1;

	printf("%s",mensaje);
	fflush(stdin);
	scanf("%[^\n]",buffer);

	largoBuffer = (int)strlen(buffer);

	if(len > largoBuffer)
	{
		strcpy(cadena,buffer);
		retorno = 1;
	}


	return retorno;
}

void mostrarJugador(eJugador jugadores[],int indiceDelEmpleado, char* mensaje, char* mensajeError)
{
	printf("%s", mensaje);
	if(indiceDelEmpleado > -1)
	{
		 printf("%s \t %d \t\t\t\t %d \t\t\t %.2f\n", jugadores[indiceDelEmpleado].nombre,jugadores[indiceDelEmpleado].partidosJugados,
				 jugadores[indiceDelEmpleado].golesMetidos,jugadores[indiceDelEmpleado].promedioGoles);
	}
	else
	{
		printf("%s", mensajeError);
	}
}
