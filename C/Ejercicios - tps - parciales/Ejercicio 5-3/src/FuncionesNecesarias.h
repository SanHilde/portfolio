/*
 * FuncionesNecesarias.h
 *
 *  Created on: 11 sep. 2022
 *      Author: santy
 */

#ifndef FUNCIONESNECESARIAS_H_
#define FUNCIONESNECESARIAS_H_
#include <stdio.h>
#include <stdlib.h>

int cargarArrayValorUnico(int valorUnico, int array[], int tam);
int cargarNumeros(int array[], int tam);
void validarDistintoDeUnNumero (int valorValidado, int array[], int tam);
void validarEntreDosNumeros (int valorMinimo, int valorMaximo, int array[], int tam);
void mostrarNumerosLista(int array[],int tam);
void mostrarNumerosListaPares(int array[],int tam);
void mostrarUbicacionListaimpares(int array[],int tam);
int busquedaMenorNegativo(int array[],int tam);
int busquedaMayorImpar(int array[],int tam);
void localizadorRepetidos(int array[],int tam);
void mostrarPositivosOrdenadosCreciente(int array[],int tam);
void mostrarNegativosOrdenadosDecreciente(int array[],int tam);

#endif /* FUNCIONESNECESARIAS_H_ */
