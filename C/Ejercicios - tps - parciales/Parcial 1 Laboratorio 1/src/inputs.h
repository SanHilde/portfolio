/*
 * inputs.h
 *
 *  Created on: 17 sep. 2022
 *      Author: santy
 */

#ifndef INPUTS_H_

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


/**
 * \fn int utn_getNumero(int* pResultado, char* mensaje, char* mensajeError, int minimo, int maximo, int intentos);
 * \brief esta funcion valida que solo se ingresen numeros y entre dos valores, en una cierta cantidad de intentos
 *
 * \param pResultado: a traves de puntero, devuelve el valor que se ingreso
 * \param mensaje: a traves de puntero, mensaje que explica que se necesita ingresar
 * \param mensajeError: a traves de puntero, mensaje que aparece en caso de haber ingresado algo mal
 * \param minimo: valor minimo que tiene que superar el valor ingresado
 * \param maximo: valor maximo que no puede superar el valor ingresado
 * \param intentos: la cantidad de intentos que se pueden ingresar valores
 * \return: si el numero es mayor 0, retorno 1, y si se pasa la cantidad de intentos fallidos maximos, el retorno es -1
 */
int utn_getNumero(int* pResultado, char* mensaje, char* mensajeError, int minimo, int maximo, int intentos);

/**
 * \fn int utn_getNumeroPositivo(int* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos);
 * \brief esta funcion valida que solo se ingresen numeros y mayores a 0 en una cierta cantidad de intentos
 *
 * \param pResultado: a traves de puntero, devuelve el valor que se ingreso
 * \param mensaje: a traves de puntero, mensaje que explica que se necesita ingresar
 * \param mensajeError: a traves de puntero, mensaje que aparece en caso de haber ingresado algo mal
 * \param minimo: valor minimo que tiene que superar el valor ingresado
 * \param intentos: la cantidad de intentos que se pueden ingresar valores
 * \return: si el numero es mayor a 0, retorno 1, y si se pasa la cantidad de intentos fallidos maximos, el retorno es -1
 */
int utn_getNumeroPositivo(int* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos);

/**
 * \fn int utn_getNumeroPositivoConDecimales(float* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos);
 * \brief esta funcion valida que solo se ingresen numeros y mayores a 0 en una cierta cantidad de intentos, permite que tenga decimales
 *
 * \param pResultado: a traves de puntero, devuelve el valor que se ingreso con decimales
 * \param mensaje: a traves de puntero, mensaje que explica que se necesita ingresar
 * \param mensajeError: a traves de puntero, mensaje que aparece en caso de haber ingresado algo mal
 * \param minimo: valor minimo que tiene que superar el valor ingresado
 * \param intentos: la cantidad de intentos que se pueden ingresar valores
 * \return: si el numero es mayor a 0, retorno 1, y si se pasa la cantidad de intentos fallidos maximos, el retorno es -1
 */
int utn_getNumeroPositivoConDecimales(float* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos);

/**
 * \fn int pedirCaracter(char*, char*, char*, int)
 * \brief pide un caracter y valida que este cumpla con las condiciones
 *
 * \param pResultado: a traves de puntero, devuelve el dato que se ingreso
 * \param mensaje: a traves de puntero, mensaje que explica que se necesita ingresar
 * \param mensajeError: a traves de puntero, mensaje que aparece en caso de haber ingresado algo mal
 * \param intentos: la cantidad de intentos que se pueden ingresar caracteres
 * \return si se paso el dato correctamente retorno 1, y si se pasa la cantidad de intentos fallidos maximos, el retorno es -1
 */
int pedirCaracter(char* pResultado, char* mensaje, char* mensajeError, int intentos);

/**
 * \fn int pedirCadena(char*, int, char*, char*, int)
 * \brief pide una cadena de caracteres y valida que esta este dentro del la cantidad de caracteres que se puso como validacion
 *
 * \param pResultado: a traves de puntero, devuelve la cadena que se ingreso
 * \param len: largo que debe cumplir la cadena a tener como maximo
 * \param mensaje: a traves de puntero, mensaje que explica que se necesita ingresar
 * \param mensajeError: a traves de puntero, mensaje que aparece en caso de haber ingresado algo mal
 * \param intentos: la cantidad de intentos que se pueden ingresar cadenas de caracteres
 * \return si se paso el dato correctamente retorno 1, y si se pasa la cantidad de intentos fallidos maximos, el retorno es -1
 */
int pedirCadena(char* pResultado, int len, char* mensaje, char* mensajeError,int intentos);

#define INPUTS_H_
#endif /* INPUTS_H_ */
