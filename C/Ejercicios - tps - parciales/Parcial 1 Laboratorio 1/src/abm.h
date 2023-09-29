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
#include <ctype.h>

/**
 * \struct
 * \brief estructura que permite guardar una fecha
 *
 *
 */
typedef struct {
	int dia;
	int mes;
	int anio;
} eFecha;

/**
 * \struct
 * \brief estructura que permite guardar datos de editoriales
 *
 */
typedef struct {
	int codigoEditorial;
	char descripcionEditorial[51];
} eEditorial;


typedef struct {
	int codigoGenero;
	char descripcionGenero[51];
} eGenero;

/**
 * \struct
 * \brief estructura que permite guardar datos de paises
 *
 */
typedef struct {
	int codigoPais;
	char descripcionPais[51];
} ePais;

/**
 * \struct
 * \brief estrucutura que permite guardar datos de autores
 *
 */
typedef struct {
	int codigoAutor;
	char nombreAutor[51];
	int idNacionalidad;
} eAutor;

/**
 * \struct
 * \brief estrucutura que permite guardar datos de libros
 *
 */
typedef struct {
	int codigoLibro;
	char tituloLibro[51];
	eFecha fechaPublicacion;
	float precio;
	int idAutor;
	int idEditorial;
	int idGenero; //agregar en doxygen
	int estado;
} eLibro;

/**
 * \fn int hardCodeoAutores(eAutor[], int)
 * \brief hardcodea los datos de los autores
 *
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param cantidadAutores: dato que viene desde el main, la cantidad total de autores que posee el programa
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si hubo un error, el retorno es -1
 */
int hardCodeoAutores(eAutor autor[], int cantidadAutores);

/**
 * \fn int hardCodeoEditoriales(eEditorial[], int)
 * \brief hardcodea los datos de las editoriales
 *
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param cantidadEditorial: dato que viene desde el main, la cantidad total de editoriales que posee el programa
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si hubo un error, el retorno es -1
 */
int hardCodeoEditoriales(eEditorial editorial[], int cantidadEditorial);

/**
 * \fn int hardCodeoPaises(ePais[], int)
 * \brief hardcodea los datos de los paises
 *
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param cantidadPaises: dato que viene desde el main, la cantidad total de paises que posee el programa
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si hubo un error, el retorno es -1
 */
int hardCodeoPaises(ePais pais[], int cantidadPaises);

/**
 * \fn int inicializador(eLibro, int, int, int)
 * \brief deja todos los valores de estado a libre, para que se puedan usar
 *
 * \param estructura: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estadoLibre: parametro que indica que valor que posee el dato cuando esta en estado libre y permite ser modificado
 * \param indiceAEmpezar: valor con el cual se iniciara un bucle for para realizar determinada accion
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si hubo un error, el retorno es -1
 */
int inicializador (eLibro estructura[], int cantidadTotal, int estadoLibre, int indiceAEmpezar);

/**
 * \fn int altaDatos(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, int, int, int, int, int, char*, char*, char*, int)
 * \brief pide todos los datos que se necesitan cargar en la estrucutra de libro, los valida con cada funcion pertinente
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param cantidadTotalLibros: dato que viene desde el main, la cantidad total de libros que posee el programa
 * \param cantidadAutores: dato que viene desde el main, la cantidad total de autores que posee el programa
 * \param cantidadPaises: dato que viene desde el main, la cantidad total de paises que posee el programa
 * \param cantidadEditoriales: dato que viene desde el main, la cantidad total de editoriales que posee el programa
 * \param estadoLibre: parametro que indica que valor que posee el dato cuando esta en estado libre y permite ser modificado
 * \param estadoOcupado: parametro que indica que valor que posee el dato cuando esta en estado ocupado y no permite ser modificado
 * \param mensajeErrorGetNumero: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorGetNumeroPositivo: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorGetCadena: mensaje que aparece cuando se supera el limite de caracteres
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int altaDatos(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero [],int cantidadTotalLibros ,
		int cantidadAutores, int cantidadPaises, int cantidadEditoriales, int cantidadGeneros, int estadoLibre,int estadoOcupado,
		char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo, char* mensajeErrorGetCadena,  int intentos);

/**
 * \fn int buscarLibre(eLibro[], int, int, int*)
 * \brief busca un indice libre de forma automatica, y te devuelve le indice para que lo puedas usar
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param indice: valor devuelto del bucle, que posee estado libre
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si no habia un espacio libre, el return es -1
 */
int buscarLibre(eLibro temaEstructura[], int cantidadTotal, int estado,
		int *indice);

/**
 * \fn int buscarDato(eLibro[], int, int, int*, int)
 * \brief busca un dato	pedido y te devuelve el indice donde esta guardado, si este cumple con el estado solicitado
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param datoABuscar: valor el cual se buscara en un bucle for
 * \param indice: lugar donde esta guardado el dato solicitado
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si no cumplio con la condicionante, el retorno es -1
 */
int buscarDato(eLibro temaEstructura[], int cantidadTotal, int datoABuscar,
		int *indice, int estado);

/**
 * \fn int bajarDato(eLibro[], int, int, int, int, char*, char*, int, int)
 * \brief da de baja un dato y lo deja inactivo
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estadoLibre: parametro que indica que valor que posee el dato cuando esta en estado libre y permite ser modificado
 * \param estadoOcupado: parametro que indica que valor que posee el dato cuando esta en estado ocupado y no permite ser modificado
 * \param estadoBajado: parametro que indica que valor que posee el dato cuando esta en estado dado de baja y no puede ser modificado ni usado
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int bajarDato(eLibro temaEstructura[], int cantidadTotal, int estadoLibre,
		int estadoOcupado, int estadoBajado, char *mensaje, char *mensajeError,
		int minimo, int intentos);

/**
 * \fn void mostrarDato(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, char*)
 * \brief muestra 1 dato, el que esta guardado en el indice ingresado
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param indice: lugar donde esta guardado el dato que se quiere mostrar
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarDato(eLibro libro[], eAutor autor[], ePais pais[],
		eEditorial editorial[], eFecha fecha[], int indice, char *mensajeError);

/**
 * \fn void mostrarDatos(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, char*, char*, int)
 * \brief muestra todos los datos que se recorren en el bucle for
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 */
void mostrarDatos(eLibro libro[], eAutor autor[], ePais pais[],
		eEditorial editorial[], eFecha fecha[], int cantidadTotal,
		char *mensaje, char *mensajeError, int estado);

/**
 * \fn int verificarLleno(eLibro[], int, int)
 * \brief verifica que hay al menos 1 dato cargado
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si no hay nada cargado, el retorno es
 */
int verificarLleno(eLibro temaEstructura[], int cantidadTotal, int estado);

/**
 * \fn int modificarLibro(eLibro[], int, int, char*, char*, char*, int, int, int)
 * \brief modifica el nombre de un libro, aquel que se solicito
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 * \param mensajeErrorCadena: mensaje que aparece cuando se supero la cantidad de caracteres
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \param len: largo de una cadena
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarLibro(eLibro temaEstructura[], int cantidadTotal, int estado,
		char *mensaje, char *mensajeError, char *mensajeErrorCadena, int minimo,
		int intentos, int len);

/**
 * \fn int pedirConfirmacion(char*, int)
 * \brief pregunta si realmente quiere realizar la accion anterior
 *
 * \param caracterConfirmacion: caracter que confirmara si se quiere realizar la accion o no, S para si y N para no
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si hubo un error, el retorno es -1
 */
int pedirConfirmacion(char *caracterConfirmacion, int intentos);

/**
 * \fn void mostrarAutor(eAutor[], ePais[], int, int, char*)
 * \brief muestra un autor, el ingresado a traves del indice
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param temaEstructuraDos: : nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param indice: lugar donde esta guardado el dato que se quiere mostra
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarAutor(eAutor temaEstructura[], ePais temaEstructuraDos[],
		int cantidadTotal, int indice, char *mensajeError);

/**
 * \fn void mostrarAutores(eAutor[], ePais[], int, int, char*, char*)
 * \brief muestra todos los autores que estan en la estructura, a traves de un bucle for
 *
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param cantidadAutores: dato que viene desde el main, la cantidad total de autores que posee el programa
 * \param cantidadPaises: dato que viene desde el main, la cantidad total de paises que posee el programa
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarAutores(eAutor autor[], ePais pais[], int cantidadAutores,
		int cantidadPaises, char *mensaje, char *mensajeError);

/**
 * \fn void mostrarEditorial(eEditorial[], int, int, char*)
 * \brief muestra la editorial que esta ubicada en el indice pasado
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param indice:  lugar donde esta guardado el dato que se quiere mostra
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarEditorial(eEditorial temaEstructura[], int cantidadTotal,
		int indice, char *mensajeError);

/**
 * \fn void mostrarEditoriales(eEditorial[], int, char*, char*)
 * \brief muestra todas las editoriales guardadas en la	estructura, a traves de un bucle for
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarEditoriales(eEditorial temaEstructura[], int cantidadTotal,
		char *mensaje, char *mensajeError);

/**
 * \fn void mostrarPais(ePais[], int, int, char*)
 * \brief muestra el pais que esta ubicado en el indice pasado
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param indice: lugar donde esta guardado el dato que se quiere mostra
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarPais(ePais temaEstructura[], int cantidadTotal, int indice,
		char *mensajeError);

/**
 * \fn void mostrarPaises(ePais[], int, char*, char*)
 * \brief muestra todos los paises que estan guardados en la estrucutra, a traves de un bucle for
 *
 * \param temaEstructura: nombre de la estructura generica donde se guardan los datos de dicha estructura
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeError: mensaje que aparece cuando hay algo que salio mal en la funcion
 */
void mostrarPaises(ePais temaEstructura[], int cantidadTotal, char *mensaje,
		char *mensajeError);

/**
 * \fn void respuesta(int)
 * \brief imprime una respuesta segun el valor ingresado
 *
 * \param valor: valor a ingresar, el cual permite realizar determinada accion
 */
int respuesta(int valor);

/**
 * \fn int modificarAutor(eLibro[], ePais[], eAutor[], int, int, char*, char*, char*, int, int, int, int)
 * \brief modifica el autor guardado en el libro, te permite intercambiarlo por otro ingresado en la estructura de autores
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorCarga: mensaje que aparece cuando hubo problemas en la carga de un dato
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \param cantidadAutores: dato que viene desde el main, la cantidad total de autores que posee el programa
 * \param cantidadPaises: dato que viene desde el main, la cantidad total de paises que posee el programa
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarAutor(eLibro libro[], ePais pais[], eAutor autor[],
		int cantidadTotal, int estado, char *mensaje, char *mensajeErrorUTNGet,
		char *mensajeErrorCarga, int minimo, int intentos, int cantidadAutores,
		int cantidadPaises);

/**
 * \fn int modificarEditorial(eLibro[], eEditorial[], int, int, char*, char*, char*, int, int, int)
 * \brief modifica la editorial guardado en el libro, te permite intercambiarla por otro ingresada en la estructura de editoriales
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorCarga: mensaje que aparece cuando hubo problemas en la carga de un dato
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \param cantidadEditoriales: dato que viene desde el main, la cantidad total de editoriales que posee el programa
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarEditorial(eLibro libro[], eEditorial editorial[],
		int cantidadTotal, int estado, char *mensaje, char *mensajeErrorUTNGet,
		char *mensajeErrorCarga, int minimo, int intentos,
		int cantidadEditoriales);

/**
 * \fn int modificarPrecio(eLibro[], int, int, char*, char*, char*, int, int)
 * \brief modifica el precio guardado en el libro, te permite ingresar uno nuevo
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorUTNGetPositivo: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarPrecio(eLibro libro[], int cantidadTotal, int estado,
		char *mensaje, char *mensajeErrorUTNGet,
		char *mensajeErrorUTNGetPositivo, int minimo, int intentos);

/**
 * \fn int modificarDia(eLibro[], int, int, char*, char*, int, int)
 * \brief modifica el dia que se publico el libro, guardado en la estructura libro, te permite ingresar uno nuevo
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarDia(eLibro libro[], int cantidadTotal, int estado, char *mensaje,
		char *mensajeErrorUTNGet, int minimo, int intentos);

/**
 * \fn int modificarMes(eLibro[], int, int, char*, char*, int, int)
 * \brief modifica el mes que se publico el libro, guardado en la estructura libro, te permite ingresar uno nuevo
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarMes(eLibro libro[], int cantidadTotal, int estado, char *mensaje,
		char *mensajeErrorUTNGet, int minimo, int intentos);

/**
 * \fn int modificarAnio(eLibro[], int, int, char*, char*, char*, int, int)
 * \brief modifica el dia que se publico el anio, guardado en la estructura libro, te permite ingresar uno nuevo
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorUTNGetPositivo
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 * \return: si el pasaje de datos es correcto y la funcion trabajo correctamente, el retono es 1, si se cancelo la ejecucion de la funcion a proposito 0, si hubo un error, el retorno es -1
 */
int modificarAnio(eLibro libro[], int cantidadTotal, int estado, char *mensaje,
		char *mensajeErrorUTNGet, char *mensajeErrorUTNGetPositivo, int minimo,
		int intentos);

/**
 * \fn void mostrarLibrosOrdenados(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, int, char*)
 * \brief ordena los libros por precio (descendentemente) y luego, por nombre (ascendentemente)	y te los muestra
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estadoOcupado: parametro que indica que valor que posee el dato cuando esta en estado ocupado y no permite ser modificado
 * \param mensajeErrorCarga: mensaje que aparece cuando hubo problemas en la carga de un dato
 */
void mostrarLibrosOrdenados(eLibro libro[], eAutor autor[], ePais pais[],
		eEditorial editorial[], eFecha fecha[], int cantidadTotal,
		int estadoOcupado, char *mensajeErrorCarga);

/**
 * \fn void mostrarLibros(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, int, char*)
 * \brief ordenas los libros por ID y te los muestra
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estadoOcupado: parametro que indica que valor que posee el dato cuando esta en estado ocupado y no permite ser modificado
 * \param mensajeErrorCarga: mensaje que aparece cuando hubo problemas en la carga de un dato
 */
void mostrarLibros(eLibro libro[], eAutor autor[], ePais pais[],
		eEditorial editorial[], eFecha fecha[], int cantidadTotal,
		int estadoOcupado, char *mensajeErrorCarga);

/**
 * \fn void menuPrincipal(int*, char*, int, int, int)
 * \brief imprime el menu principal y guarda la opcion a elegir
 *
 * \param opcionMenuPrincipal: opcion a elegir en el menu
 * \param mensajeErrorGetNumero: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param maximo: valor maximo que puede tener un dato en el ingreso sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 */
void menuPrincipal(int *opcionMenuPrincipal, char *mensajeErrorGetNumero,
		int minimo, int maximo, int intentos);

/**
 * \fn void subMenuModificar(eLibro[], eAutor[], ePais[], eEditorial[], eFecha[], int, int, int, int, int, int, char*, char*, char*, char*, char*, int)
 * \brief imprime el submenu de modificar y guarda la opcion elegida, luego realiza la funcion que esta dentro de la opcion elegida
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param autor: nombre de la estructura eAutor donde se guardan los datos del autor
 * \param pais: nombre de la estructura ePais donde se guardan los datos de un pais
 * \param editorial: nombre de la estructura eEditorial donde se guardan los datos de la editorial
 * \param fecha: nombre de la estructura eFecha donde se guardan los datos de una fecha
 * \param cantidadTotalLibros: dato que viene desde el main, la cantidad total de libros que posee el programa
 * \param cantidadAutores: dato que viene desde el main, la cantidad total de autores que posee el programa
 * \param cantidadPaises: dato que viene desde el main, la cantidad total de paises que posee el programa
 * \param cantidadEditoriales: dato que viene desde el main, la cantidad total de editoriales que posee el programa
 * \param estadoLibre: parametro que indica que valor que posee el dato cuando esta en estado libre y permite ser modificado
 * \param estadoOcupado: parametro que indica que valor que posee el dato cuando esta en estado ocupado y no permite ser modificado
 * \param mensajeBusquedaId: mensaje que aparece cuando se busca un id
 * \param mensajeErrorCarga: mensaje que aparece cuando hubo problemas en la carga de un dato
 * \param mensajeErrorGetNumero: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorGetNumeroPositivo: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorGetCadena: mensaje que aparece cuando se supera el limite de caracteres
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 */
void subMenuModificar (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],
		int cantidadTotalLibros ,int cantidadAutores, int cantidadPaises, int cantidadEditoriales, int cantidadGeneros, int estadoLibre,
		int estadoOcupado, char* mensajeBusquedaId,char* mensajeErrorCarga, char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo,
		char* mensajeErrorGetCadena,  int intentos);

/**
 * \fn void subMenuFecha(eLibro[], int, int, char*, char*, char*, int, int)
 * \brief imprime un submenu para elegir si editar fecha, mes o anio
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: dato que viene desde el main, la cantidad total de algo que posee el programa
 * \param estado: parametro que indica que valor que posee el dato cuando esta en determinado estado y en funcion de este, permite ser modificado o no
 * \param mensaje: mensaje que aparecera en el ingreso del dato, indica que se va a pedir
 * \param mensajeErrorUTNGet: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param mensajeErrorGetNumeroPositivo: mensaje que aparece cuando se ingreso un parametro fuera de lo requerido
 * \param minimo: valor minimo que debe tener el dato ingresado, sirve para validar
 * \param intentos: valor el representara la cantidad de veces que se puede ingresar un dato
 */
void subMenuFecha(eLibro libro[], int cantidadTotal, int estado, char *mensaje,
		char *mensajeErrorUTNGet, char *mensajeErrorUTNGetPositivo, int minimo,
		int intentos);


void mostrarGeneros(eGenero temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError);

void mostrarGenero(eGenero temaEstructura[],int cantidadTotal,int indice, char* mensajeError);

int hardCodeoGenero (eGenero genero[], int cantidadGenero);

int modificarGenero (eLibro libro[], eGenero genero[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadGeneros);

void mostrarDatoConGenero(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],int indice,
						char* mensajeError);

void mostrarLibrosConFiltro (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],
		int cantidadTotal, int estadoOcupado, char* mensaje, char* mensajeErrorCarga);

void mostrarArgentinosConEditorialElegida (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],
		eGenero genero[], int cantidadTotal, int cantidadEditoriales, int estadoOcupado, char* mensaje, char* mensajeErrorCarga);
#define ABM_H_
#endif /* ABM_H_ */

