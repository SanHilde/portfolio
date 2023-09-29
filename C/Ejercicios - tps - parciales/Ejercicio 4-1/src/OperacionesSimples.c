/*
 * OperacionesSimples.c
 *
 *  Created on: 31 ago. 2022
 *      Author: santy
 */
#include "OperacionesSimples.h"

int calcularFactorial (int numeroIngresado)
{
int resultado=1;

if (numeroIngresado== 1 || numeroIngresado==0)
{
	return resultado;
} else
{
	for (  ;numeroIngresado>1 ;numeroIngresado--)
	{
	resultado = resultado * numeroIngresado;
	}
}
return resultado;
}


