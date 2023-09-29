/*
 * OperacionesSimples.h
 *
 *  Created on: 31 ago. 2022
 *      Author: santy
 */

#ifndef OPERACIONESSIMPLES_H_
#define OPERACIONESSIMPLES_H_
#include <stdio.h>
#include <stdlib.h>

/**
 * \fn int calcularFactorial(int)
 * \brief esta funcion validad que el caracter ingresado sea s o n
 *
 * \param
 * \return si el caracter es s, retorno 1, y si el caracter es n, retorno 0
 */
int calcularFactorial (int);
/**
 * \fn int acumularNumeros(int[], int)
 * \brief
 *
 * \param array la variable que acumulara los numeros
 * \param tam la cantidad a acumular
 * \return
 */
int acumularNumeros(int array[],int tam);
int contarNumeros(int array[],int tam);
float calcularPromedio(int suma, int contador);
int contarNumerosPositivos(int array[],int tam);
int acumularNumerosPositivos(int array[],int tam);
int sumaAntesesoresHastaValor(int valorHastaAntesesores,int numeroATrabajar);
int contarNumerosNegativos(int array[],int tam);
int acumularNumerosPares(int array[],int tam);



#endif /* OPERACIONESSIMPLES_H_ */
