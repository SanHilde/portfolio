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
#include "funcionesNecesarias.h"
#include "inputs.h"
#include "abm.h"

#define INTENTOS 3
#define LIBRE 1
#define OCUPADO 0
#define INACTIVO -1
#define OK 1
#define CANT_PAISES 3
#define CANT_TIPOS 4
#define CANT_PRODUCTOS 5


int main(void) {

	setbuf (stdout ,NULL);

	eEstructura productoApple[CANT_PRODUCTOS];
	eTipo tipo[CANT_TIPOS];
	//ePais pais[CANT_PAISES];
	int opcionMenuPrincipal;
	//int devolucion;
	int indiceIncremental=0;
	int contadorProductosActivos=0;
	char mensajeErrorGetNumero[] = ("El dato ingresado esta fuera del rango solicitado.\n");
	char mensajeErrorGetNumeroPositivo[] = ("El dato ingresado debe ser mayor a 0.\n");
	char mensajeErrorGetCadena[] = ("El texto solicitado supero el limite de caracteres.\n");
	char mensajeErrorCarga[] = ("\n\nNo hay datos para mostrar.\n");
	char mensajeErrorBandera[] = ("\nNo hay datos cargados, no se puede ingresar.\n\n");
	char mensajeBusquedaId[] = ("\nIngrese el ID del libro a realizar operacion: ");




	for(int i=0; i<CANT_PRODUCTOS; i++)
	{
		productoApple[i].estado = LIBRE;
	}

	do{
		utn_getNumero(&opcionMenuPrincipal,
					"\t\tMenu principal\n"
					"Seleccione que desea realizar:\n"
					"1-Alta de producto\n"
					"2-Baja de producto\n"
					"3-Modificacion de producto\n"
					"4-Listado de productos por id\n"
					"5-Listado de producto por precio\n"
					"6-Listado de producto por descripcion\n"
					"7-Salir\n"
					"Numero ingresado: ",
					mensajeErrorGetNumero,
					1,
					7,
					INTENTOS);

		switch (opcionMenuPrincipal){
		/*
		case 1:
			if(altaDatos(productoApple, CANTIDAD, LIBRE, OCUPADO, mensajeErrorGetNumero,
					mensajeErrorGetNumeroPositivo, mensajeErrorGetCadena,INTENTOS) == OK)
			   {
				   printf("Se dio de alta correctamente.\n");
				   indiceIncremental++;
			   }
			   else
			   {
				   printf("Lo siento, la lista está llena.\n");
			   }
			break;
		case 2:
			mostrarDatos(productoApple,CANTIDAD,"ID del producto\t\tNacionalidad\t\tTipo\t\tPrecio\t\tDescripcion\n",
								"\n\nNo hay datos para mostrar.\n", OCUPADO);
			devolucion=bajarDato(productoApple,CANTIDAD,LIBRE,OCUPADO, "Ingrese el ID que quiere eliminar: ", mensajeErrorGetNumeroPositivo, 0, INTENTOS);
			if (devolucion==OK)
			{
				printf ("La baja se hizo correctamente\n");
			}
			else if (devolucion==0)
			{
				printf ("Se cancelo la baja.\n");
			} else
			{
				printf ("No se encontro el usuario.\n");
			}
			break;
		case 3:
			break;
			*/
		case 1:
			if(altaDatos(productoApple, CANT_PRODUCTOS, LIBRE, OCUPADO, mensajeErrorGetNumero,
					mensajeErrorGetNumeroPositivo, mensajeErrorGetCadena,INTENTOS) == OK)
			   {
				   printf("\nSe dio de alta correctamente.\n");
				   indiceIncremental++;
				   contadorProductosActivos++;
			   } else
			   {
				   printf("Lo siento, la lista está llena.\n");
			   }

			break;
		case 2:
			if (contadorProductosActivos> 0 )
			{
				mostrarDatos(productoApple,CANT_PRODUCTOS,"ID del producto\t\tNacionalidad\t\tTipo\t\tPrecio\t\tDescripcion\n",
						"\n\nNo hay datos para mostrar.\n", OCUPADO);
				if (respuesta(bajarDato(productoApple,CANT_PRODUCTOS,LIBRE, OCUPADO,
						"ID del producto\t\tNacionalidad\t\tTipo\t\tPrecio\t\tDescripcion\n",
						"\n\nNo hay datos para mostrar.\n", 1, INTENTOS))==OK)
				{
				contadorProductosActivos--;
				}
			}
			 else
			{
				 printf ("%s", mensajeErrorBandera);
			}
			break;
		case 3:
			if (contadorProductosActivos>0)
			{
				subMenuModificar(productoApple, tipo, CANT_PRODUCTOS, CANT_PAISES, CANT_TIPOS,
								LIBRE, OCUPADO,mensajeBusquedaId,mensajeErrorCarga,mensajeErrorGetNumero,mensajeErrorGetNumeroPositivo,
								mensajeErrorGetCadena,INTENTOS);
			}
			else
			{
				printf ("%s", mensajeErrorBandera);
			}
			break;
		case 4:
			mostrarDatos(productoApple,CANT_PRODUCTOS,"ID del producto\t\tNacionalidad\t\tTipo\t\tPrecio\t\tDescripcion\n",
					"\n\nNo hay datos para mostrar.\n", OCUPADO);
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		}

	} while (opcionMenuPrincipal!=7);

	return EXIT_SUCCESS;
}
