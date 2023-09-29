/*
 * funcionesNecesarias.h
 *
 *  Created on: 17 sep. 2022
 *      Author: santy
 */

#ifndef FUNCIONESNECESARIAS_H_


#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "abm.h"
#include "inputs.h"


/**
 * \fn int calcularPromedio(float* resultado, int total, int contador);
 * \brief esta funcion valida que, dentro de la misma se realice un promedio de forma correcta, donde se divide una numero resultado de una
 * acumulacion de numeros por otro resultado de la cantidad de numeros sumados. Como no se puede dividir por 0, si se llega a ingresar como
 * cantidad a dividir 0, este devolvera en la funcion un return distinto a si se hizo bien.
 *
 * \param pResultado: resultado de la operacion realizada, se devuelve a traves de puntero, como flotante (debido a que puede llegar a
 * tener decimales)
 * \param total: numero al cual se realizara el promedio, aquel resultado de la suma de numeros acumulados
 * \param contador: numero con el cual se realiza el promedio, aquel resultado de la suma de la cantidad de numeros ingresados
 * \return si el pasaje de datos es correcto y el calculo del promedio tambien, el retono es 1, si hubo un error, el retorno es -1
 */
int calcularPromedio(float* pResultado, float total, int cantidad);

/**
 * \fn int calcularPorcentaje (float* pResultado, float numeroAAumentar, int porcentaje);
 * \brief esta funcion valida que, dentro de la misma, se calcule correctamente el porcentaje (valor ingresado a traves de la funcion)
 * de un numero (tambien ingresado en la funcion)
 *
* \param pResultado: resultado de la operacion realizada, se devuelve a traves de puntero, como flotante (debido a que puede llegar a
 * tener decimales)
 * \param numeroAAumentar: numero al cual se realizara el aumento
 * \param porcentaje: valor de porcentaje con el cual se trabajara
 * \return si el pasaje de datos es correcto y el calculo del porcentaje tambien, el retono es 1, si hubo un error, el retorno es -1
 */
int calcularPorcentaje (float* pResultado, float numeroAAumentar, int porcentaje);

/**
 * \fn int calcularAcumulador(eLibro[], float*, int, int)
 * \brief acumula todos los precios para dar un total
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param acumulador: variable donde se van acumulando los precios
 * \param cantidadTotal: cantidad de veces que se recorre en el bucle for para ver si el estado esta ocupado
 * \param estadoOcupado: ingresa que valor tiene que tener el estado para que cumpla con la comparacion
 * \return si el pasaje de datos es correcto y el calculo del porcentaje tambien, el retono es 1, si hubo un error, el retorno es -1
 */
int calcularAcumulador(eLibro libro[], float* acumulador, int cantidadTotal, int estadoOcupado);

/**
 * \fn void contadorSuperiorAPromedio(eLibro[], float, int*, int, int)
 * \brief
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param promedio: valor el cual se utilizar para la comparacion
 * \param contador: variable que fue acumulando la cantidad de datos que cumplieron con el requisito
 * \param cantidadTotal: cantidad de veces que se recorre en el bucle for para ver si el estado esta ocupado
 * \param estadoOcupado: ingresa que valor tiene que tener el estado para que cumpla con la comparacion
 */
void contadorSuperiorAPromedio(eLibro libro[], float promedio, int *contador, int cantidadTotal, int estadoOcupado);

/**
 * \fn void contadorDeLibrosViejos(eLibro[], int, int, int, int*)
 * \brief cuenta la cantidad de libros que poseen un dato anterior a determinado valor
 *
 * \param libro: nombre de la estructura eLibro donde se guardan los datos del libro
 * \param cantidadTotal: cantidad de veces que se recorre en el bucle for para ver si el estado esta ocupado
 * \param estadoOcupado: ingresa que valor tiene que tener el estado para que cumpla con la comparacion
 * \param fechaLimite: valor el cual se usa como parametro de comparacion
 * \param contador: variable que fue acumulando la cantidad de datos que cumplieron con el requisito
 */
void contadorDeLibrosViejos (eLibro libro[], int cantidadTotal, int estadoOcupado, int fechaLimite, int *contador);

#define FUNCIONESNECESARIAS_H_
#endif /* FUNCIONESNECESARIAS_H_ */
