/*
 ============================================================================
 Name        : Parcial.c
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

#define CANT_AUTORES 10
#define CANT_EDIT 5
#define CANT_PAISES 5
#define CANT_LIBROS 100
#define CANT_GENEROS 5

int main(void) {

	setbuf (stdout ,NULL);

	//eLibro libro[CANT_LIBROS];
	eFecha fecha[CANT_LIBROS];
	eEditorial editorial[CANT_EDIT];
	eAutor autor[CANT_AUTORES];
	ePais pais[CANT_PAISES];
	eGenero genero [CANT_GENEROS];
	int opcionMenuPrincipal;
	char mensajeErrorGetNumero[] = ("El dato ingresado esta fuera del rango solicitado.\n");
	char mensajeErrorGetNumeroPositivo[] = ("El dato ingresado debe ser mayor a 0.\n");
	char mensajeErrorGetCadena[] = ("El texto solicitado supero el limite de caracteres.\n");
	char mensajeErrorCarga[] = ("\n\nNo hay datos para mostrar.\n");
	char mensajeErrorBandera[] = ("\nNo hay datos cargados, no se puede ingresar.");
	char mensajeBusquedaId[] = ("\nIngrese el ID del libro a realizar operacion: ");
	int indiceIncremental=6;//actualizar
	int contadorLibrosActivos=5;
	float acumuladorPrecios;
	float promedioPrecios;
	int contadorArribaPromedio;
	int fechaLibrosViejos=2000;
	int contadorLibrosViejos;

	eLibro libro[CANT_LIBROS] = {
							{1, "Harry Potter 1", {17, 11, 1995}, 200.5, 6, 5,4, OCUPADO},
							{2, "Harry Potter 2", {1, 1, 1990}, 200.5, 8, 4,2, OCUPADO},
							{3, "Martin Fierro", {25, 12, 2020}, 1200, 1, 3,1, OCUPADO},
							{4, "Harry Potter 3", {4, 8, 2002}, 200.5, 10, 2,5, OCUPADO},
							{5, "JASDJADH", {1, 1, 1990}, 300.5, 8, 4,2, INACTIVO},
							{6, "El quijote", {25, 12, 1800}, 1200, 5, 1,3, OCUPADO} };




	if (inicializador (libro, CANT_LIBROS, LIBRE, indiceIncremental)==OK &&
		hardCodeoEditoriales (editorial, CANT_EDIT)==OK &&
		hardCodeoAutores (autor, CANT_AUTORES)==OK &&
		hardCodeoPaises (pais, CANT_PAISES)==OK &&
		hardCodeoGenero (genero, CANT_GENEROS)==OK)
	{
		do{
			menuPrincipal (&opcionMenuPrincipal, mensajeErrorGetNumero, 1, 14, INTENTOS);

			switch (opcionMenuPrincipal){
			case 1:
				if(altaDatos(libro, autor, pais, editorial, fecha,genero, CANT_LIBROS, CANT_AUTORES, CANT_PAISES,CANT_EDIT, CANT_GENEROS,
						LIBRE, OCUPADO, mensajeErrorGetNumero,mensajeErrorGetNumeroPositivo, mensajeErrorGetCadena,INTENTOS) == OK)
				   {
					   printf("\nSe dio de alta correctamente.\n");
					   indiceIncremental++;
					   contadorLibrosActivos++;
				   }

				break;
			case 2:
				if (contadorLibrosActivos> 0 )
				{
					mostrarDatos(libro, autor, pais, editorial,fecha,CANT_LIBROS, "\nID \t Autor \t\t\t Nacionalidad \t Editorial "
								"\t Precio  Publicacion \t Libro \n", mensajeErrorCarga, OCUPADO);
					respuesta(bajarDato(libro,CANT_LIBROS,LIBRE,OCUPADO,INACTIVO, mensajeBusquedaId,mensajeErrorGetNumeroPositivo,
										0, INTENTOS));
					contadorLibrosActivos--;
				}
				 else
				{
					 printf ("%s", mensajeErrorBandera);
				}
				break;
			case 3:
				if (contadorLibrosActivos>0)
				{
					subMenuModificar(libro, autor, pais, editorial, fecha,genero, CANT_LIBROS, CANT_AUTORES, CANT_PAISES,CANT_EDIT, CANT_GENEROS,
									LIBRE, OCUPADO,mensajeBusquedaId,mensajeErrorCarga,mensajeErrorGetNumero,mensajeErrorGetNumeroPositivo,
									mensajeErrorGetCadena,INTENTOS);
				}
				else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 4:
				if (contadorLibrosActivos>0)
				{
					calcularAcumulador (libro, &acumuladorPrecios,CANT_LIBROS, OCUPADO);
					calcularPromedio( &promedioPrecios, acumuladorPrecios , contadorLibrosActivos);
					contadorSuperiorAPromedio (libro, promedioPrecios, &contadorArribaPromedio, CANT_LIBROS, OCUPADO);
					printf("Total: $%.2f\nPromedio: $%.2f\nLibros superiores al promedio: %d",acumuladorPrecios, promedioPrecios,
							contadorArribaPromedio);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 5:
				if (contadorLibrosActivos>0)
				{
					contadorDeLibrosViejos (libro, CANT_LIBROS, OCUPADO, fechaLibrosViejos, &contadorLibrosViejos);
					printf ("La cantidad de libros anteriores al anio %d: %d", fechaLibrosViejos,contadorLibrosViejos);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 6:
				if (contadorLibrosActivos>0)
				{
					mostrarEditoriales(editorial,CANT_EDIT,"\nID\t Editorial\n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 7:
				if (contadorLibrosActivos>0)
				{
					mostrarPaises(pais,CANT_PAISES, "\nID\t Pais\n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 8:
				if (contadorLibrosActivos>0)
				{
					mostrarAutores(autor,pais, CANT_AUTORES,CANT_PAISES,"\nID\t AUTOR\t\t\t NACIONALIDAD\n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 9:
				if (contadorLibrosActivos > 0 )
				{
					mostrarLibros(libro, autor, pais, editorial, fecha, CANT_LIBROS,OCUPADO, mensajeErrorCarga);
				} else
				{
					printf("%s", mensajeErrorBandera);
				}
				break;
			case 10:
				if (contadorLibrosActivos>0)
				{

					mostrarLibrosOrdenados(libro, autor, pais, editorial, fecha, CANT_LIBROS,OCUPADO, mensajeErrorCarga);

				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 11:
				if (contadorLibrosActivos>0)
				{
					mostrarGeneros(genero,CANT_EDIT,"\nID\t Genero\n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;
			case 12:
				if (contadorLibrosActivos>0)
				{
					mostrarLibrosConFiltro (libro,autor, pais,editorial,fecha,genero,CANT_LIBROS, OCUPADO,"\nID \t Autor \t\t\t Nacionalidad"
							"\t Editorial \t Genero \t Precio  Publicacion \t Libro \n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;

			case 13:
				if (contadorLibrosActivos>0)
				{
					mostrarArgentinosConEditorialElegida (libro,autor, pais,editorial,fecha,genero,CANT_LIBROS,CANT_EDIT, OCUPADO,"\nID \t Autor \t\t\t Nacionalidad"
							"\t Editorial \t Genero \t Precio  Publicacion \t Libro \n",mensajeErrorCarga);
				} else
				{
					printf ("%s", mensajeErrorBandera);
				}
				break;

			case 14:
				printf ("Eligio salir. El programa finalizo. ");
				break;
			}

		} while (opcionMenuPrincipal!=14);
	}
	else
	{
		printf ("Hubo un error al inicializar.");
	}
	return EXIT_SUCCESS;
}
