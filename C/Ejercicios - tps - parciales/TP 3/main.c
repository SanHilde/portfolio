#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Controller.h"
#include "Jugador.h"
#include "outputs.h"

#define INTENTOS 3

int main()
{
	setbuf(stdout,NULL);

    int opcionMenuPrincipal = 0;
    int opcionSubMenu = 0;
    char confirmacion;
    int numeroMinimoValidacion=1;
    int contadorCambios=0;
    char mensajeErrorGetNumero[] = ("El dato ingresado esta fuera del rango solicitado.\n");
	char mensajeErrorBandera[] = ("\nNo hay datos cargados, no se puede ingresar.\n\n");
	char mensajeSalida[] = ("Usted selecciono salir, vuelve al menu anterior.\n\n");

    LinkedList* listaJugadores = ll_newLinkedList();
    LinkedList* listaSelecciones = ll_newLinkedList();

    do{
    	utn_getNumeroInt(&opcionMenuPrincipal,
						"\n\tMenu principal\n"
						"Seleccione que desea realizar:\n"
						"1-Cargar de archivo\n"
						"2-Alta jugador\n"
						"3-Modificacion de jugador\n"
						"4-Baja de jugador\n"
						"5-Listados\n"
						"6-Convocar jugadores\n"
						"7-Ordenar y listar\n"
						"8-Generar archivo binario\n"
						"9-Cargar archivo binario\n"
						"10-Guardar archivo .csv\n"
						"11-Salir\n"
						"Numero ingresado: ",
						mensajeErrorGetNumero,
						numeroMinimoValidacion,
						11,
						INTENTOS);

        switch(opcionMenuPrincipal)
        {
            case 1:
            	if (ll_isEmpty(listaJugadores)!=0 && ll_isEmpty(listaSelecciones)!=0)
            	{
					output_respuesta(controller_cargarSeleccionesDesdeTexto("selecciones.csv" , listaSelecciones));
					output_respuesta(controller_cargarJugadoresDesdeTexto("jugadores.csv",listaJugadores));
					if (controller_ordenarSelecciones(listaSelecciones) != 1)
					{
						printf("Hubo un error al ordenar las selecciones");
					}
            	} else
            	{
            		printf ("\nEsta queriendo cargar nuevamente los datos, si lo hace, se perdera lo que no esta guardado y se volvera al "
            				"ultimo guardado que tuvo. \n\n");
            		output_pedirConfirmacion (&confirmacion,INTENTOS);
					if (confirmacion=='S')
					{
						ll_clear (listaSelecciones);
						ll_clear (listaJugadores);
						output_respuesta(controller_cargarSeleccionesDesdeTexto("selecciones.csv" , listaSelecciones));
						output_respuesta(controller_cargarJugadoresDesdeTexto("jugadores.csv",listaJugadores));
						if (controller_ordenarSelecciones(listaSelecciones) != 1)
						{
							printf("Hubo un error al ordenar las selecciones");
						}
					} else
					{
						printf ("\nOperacion cancelada. Vuelve al menu principal\n");
						opcionMenuPrincipal=0;
					}
            	}
            		break;
            case 2:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
				{
					if (output_respuesta(controller_agregarJugador (listaJugadores))== 1)
					{
						contadorCambios++;
					}

				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
            	break;
            case 3:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0 )
				{
            		output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
            		if (output_respuesta (controller_editarJugador(listaJugadores))==1)
            		{
            			contadorCambios++;
            		}
				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
                break;
            case 4:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
				{
            		output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
					if (output_respuesta(controller_removerJugador (listaJugadores))== 1)
					{
						controller_calculadorJugadoresSeleccciones (listaJugadores, listaSelecciones);
						contadorCambios++;
					}
				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
            	break;
            case 5:
				if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
				{
					do{
						utn_getNumeroInt(&opcionSubMenu,
										"\n\n\tSubMenu listado\n"
										"Seleccione que desea listar:\n"
										"1-Todos los jugadores\n"
										"2-Todas las selecciones\n"
										"3-Jugadores convocados (unicamente)\n"
										"4-Salir\n"
										"Numero ingresado: ",
										mensajeErrorGetNumero,
										numeroMinimoValidacion,
										4,
										INTENTOS);
						switch (opcionSubMenu)
						{
						case 1:
							output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
							break;
						case 2:
							controller_calculadorJugadoresSeleccciones (listaJugadores, listaSelecciones);
							controller_listarSelecciones (listaSelecciones);
							break;
						case 3:
							output_listarJugadoresDecodificadoFiltro (listaJugadores,listaSelecciones);
							break;
						case 4:
							printf ("%s", mensajeSalida);
							break;
						}
					} while (opcionSubMenu != 4);
				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
				break;
            case 6:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
				{
					do{
						utn_getNumeroInt(&opcionSubMenu,
										"\n\n\tSubMenu convocar\n"
										"Seleccione que desea realizar:\n"
										"1-Convocar jugador\n"
										"2-Quitar de la seleccion\n"
										"3-Salir\n"
										"Numero ingresado: ",
										mensajeErrorGetNumero,
										numeroMinimoValidacion,
										3,
										INTENTOS);

							switch (opcionSubMenu)
							{
							case 1:
								if (output_respuesta(controller_cargarConvocado (listaJugadores, listaSelecciones))== 1)
								{
									contadorCambios++;
									controller_calculadorJugadoresSeleccciones (listaJugadores, listaSelecciones);
								}
								break;
							case 2:
								if (output_respuesta(controller_eliminarConvocado (listaJugadores,listaSelecciones))==1)
								{
									contadorCambios++;
									controller_calculadorJugadoresSeleccciones (listaJugadores, listaSelecciones);
								}
								break;
							case 3:
								printf ("%s", mensajeSalida);
								break;
							}
					} while (opcionSubMenu != 3);
				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
            	break;
            case 7:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
				{
					do{
						utn_getNumeroInt(&opcionSubMenu,
										"\n\n\tSubMenu ordenar y listar\n"
										"Seleccione que desea realizar:\n"
										"1-Jugadores por nacionalidad\n"
										"2-Selecciones por confederacion\n"
										"3-Jugadores por edad\n"
										"4-Jugadores por nombre\n"
										"5-Salir\n"
										"Numero ingresado: ",
										mensajeErrorGetNumero,
										numeroMinimoValidacion,
										5,
										INTENTOS);
						switch (opcionSubMenu)
						{
						case 1:
							if (ll_sort(listaJugadores,controller_ordenarJugadoresPorNacionalidad , 1)==0)
							{
								output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
							}
							break;
						case 2:
							if (ll_sort(listaSelecciones,controller_ordenarSeleccionPorConf , 1)==0)
							{
								controller_listarSelecciones (listaSelecciones);
							}
							break;
						case 3:
							if (ll_sort(listaJugadores,controller_ordenarJugadoresPorEdad , 1)==0)
							{
								output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
							}
							break;
						case 4:
							if (ll_sort(listaJugadores,controller_ordenarJugadoresPorNombre , 1)==0)
							{
								output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
							}
							break;
						case 5:
							printf ("%s", mensajeSalida);
							break;
						}
					} while (opcionSubMenu != 5);
					controller_ordenarJugadores (listaJugadores);
					controller_ordenarSelecciones(listaSelecciones);
				} else
				{
					printf ("%s",mensajeErrorBandera);
				}
            	break;
            case 8:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
            	{
            		output_respuesta(controller_guardarJugadoresModoBinario ("listaSeleccionesBinario.dat",listaJugadores));
            	} else
				{
					printf ("%s",mensajeErrorBandera);
				}
                break;
            case 9:
            	if (ll_isEmpty(listaJugadores)==1 && ll_isEmpty(listaSelecciones)==1)
            	{
            		output_respuesta(controller_cargarSeleccionesDesdeTexto("selecciones.csv" , listaSelecciones));
            	}
            	if (contadorCambios != 0)
				{
					printf ("\nPerdera todos los datos realizados hasta el momento.Puede guardar antes, si cancela."
							"¿Esta seguro de que desea continuar esta accion? \n");
					output_pedirConfirmacion (&confirmacion,INTENTOS);
					if (confirmacion=='S')
					{
						printf ("\nEligio confirmar. Se perdieron los ultimos cambios realizados.\n ");
					}  else
					{
						printf ("%s",mensajeSalida);
						opcionMenuPrincipal=0;
						break;
					}
				}
					ll_clear(listaJugadores);
					controller_cargarJugadoresDesdeBinario("listaSeleccionesBinario.dat" ,listaJugadores);
					if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
					{
						output_listarJugadoresDecodificado (listaJugadores,listaSelecciones);
					} else
					{
						printf ("\nNo habia jugadores cargados en el archivo binario.\n");
					}
					ll_clear(listaJugadores);
					controller_cargarJugadoresDesdeTexto("jugadores.csv",listaJugadores);
					printf ("\nSe restablecieron automaticamente todos los jugadores del archivo jugadores.csv.\n");
            	break;
            case 10:
            	if (ll_isEmpty(listaJugadores)==0 && ll_isEmpty(listaSelecciones)==0)
            	{
            		if (contadorCambios != 0)
            		{
            			controller_calculadorJugadoresSeleccciones (listaJugadores, listaSelecciones);
            			output_respuesta(controller_guardarJugadoresModoTexto ("jugadores.csv",listaJugadores));
            			if (output_respuesta(controller_guardarSeleccionesModoTexto("selecciones.csv" , listaSelecciones))== 1)
            			{
            				contadorCambios =0;
            			}
            		} else
            		{
            			printf ("\nNo hay cambios para guardar.\n");
            		}
            	} else
				{
					printf ("%s",mensajeErrorBandera);
				}
                break;
            case 11:
            	if (contadorCambios != 0)
            	{
            		printf ("\nEsta queriendo salir sin haber guardado los cambios.\n");
            	}
            	output_pedirConfirmacion (&confirmacion,INTENTOS);
				if (confirmacion=='S')
				{
					printf ("\nEligio salir. El programa finalizo. ");
				} else
				{
					opcionMenuPrincipal=0;
				}
            	break;
        }
    }while(opcionMenuPrincipal != 11);

    ll_deleteLinkedList(listaSelecciones);
    ll_deleteLinkedList(listaJugadores);

    return 0;
}

