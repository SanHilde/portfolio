/*
 * abm.h
 *
 *  Created on: 26 sep. 2022
 *      Author: santy
 */

#ifndef ABM_H_

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
	int codigo;
	char descripcion[51];
} eTipo;

typedef struct {
	int codigo;
	char descripcion[51];
} ePais;

typedef struct
{
	int idProducto;
	char descripcion[50];
	int nacionalidad;
	int tipo;
	float precio;
	int estado;
}eEstructura;



int altaDatos(eEstructura temaEstructura[], int cantidadTotal , int estadoLibre, int estadoOcupado,
				char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroConDecimales, char* mensajeErrorGetCadena,  int intentos);

int buscarLibre(eEstructura temaEstructura[],int cantidadTotal, int estado, int* indice);

int buscarDato(eEstructura temaEstructura[],int cantidadTotal,int datoABuscar, int* indice, int estado);

int bajarDato(eEstructura temaEstructura[],int cantidadTotal, int estadoLibre, int estadoOcupado,
				char* mensaje, char *mensajeError, int minimo, int intentos);

void mostrarDatos(eEstructura temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError, int estado);

void mostrarDato(eEstructura temaEstructura[],int indice, char* mensajeError);

int verificarLleno(eEstructura temaEstructura[],int cantidadTotal, int estado);

int modificarNombre(eEstructura temaEstructura[],int cantidadTotal, int estado, char* mensaje, char* mensajeError, int minimo, int intentos);

int pedirConfirmacion (char *caracterConfirmacion, int intentos);

int respuesta (int valor);

void subMenuModificar (eEstructura producto[], eTipo tipo[],
		int cantidadProductos, int cantidadPaises, int cantidadTipos, int estadoLibre,
		int estadoOcupado, char* mensajeBusquedaId,char* mensajeErrorCarga, char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo,
		char* mensajeErrorGetCadena,  int intentos);

int modificarPrecio (eEstructura producto[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,char* mensajeErrorUTNGetPositivo,
					int minimo, int intentos);

int modificarTipo (eEstructura producto[], eTipo tipo[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadEditoriales);

int hardCodeoTipo (eTipo tipo[], int cantidadTipo);

int hardCodeoPaises (ePais pais[], int cantidadPaises);

void mostrarTipo (eTipo temaEstructura[],int cantidadTotal,int indice, char* mensajeError);

void mostrarTipos (eTipo temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError);

#define ABM_H_
#endif /* ABM_H_ */
