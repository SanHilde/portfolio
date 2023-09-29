/*
 ============================================================================
Hildebrandt Santiago
DIV K
Ejercicio 5-2
Pedir el ingreso de 10 números enteros entre -1000 y 1000. Determinar:
a) Cantidad de positivos y negativos.
b) Sumatoria de los pares.
c) El mayor de los impares.
d) Listado de los números ingresados.
e) Listado de los números pares.
f) Listado de los números de las posiciones impares.
Anexo 5-2
g) Los números que se repiten
h) Los positivos creciente y los negativos de manera decreciente
Se deberán utilizar funciones y vectores.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "OperacionesSimples.h"
#include "FuncionesNecesarias.h"
#define SIZE 5


int main(void)
{
	setbuf(stdout,NULL);

	int numeros[SIZE];
	int valorUnico=0;
	int valorValidado=0;
	int acumuladorPositivos;
	int contadorPositivos;
	float promedioPositivos;
	int menorNegativo;
	int sumaAntesesores;
	int valorHastaAntesesores=0;
	//int sumaPares;
	//int mayorImpar;

	cargarArrayValorUnico(valorUnico,numeros,SIZE);
	//mostrarNumerosLista(numeros,SIZE);


	if(cargarNumeros(numeros,SIZE) == 1)
	//if (cargarNumerosValidadosPorUnDato(numeros, SIZE, "Ingrese un numero: ","Error, el numero no esta dentro del valor de validacions", valorValidado)==1)
	{
		printf("Se cargo el array.\n");
		validarDistintoDeUnNumero (valorValidado,numeros,SIZE);
		acumuladorPositivos=acumularNumerosPositivos(numeros,SIZE);
		contadorPositivos=contarNumerosPositivos(numeros,SIZE);
		promedioPositivos=calcularPromedio(acumuladorPositivos,contadorPositivos);
		menorNegativo= busquedaMenorNegativo (numeros,SIZE);
		sumaAntesesores= sumaAntesesoresHastaValor (valorHastaAntesesores, menorNegativo);

		printf("El promedio de positivos es: %f\n", promedioPositivos);
		printf("La suma de antesesores del menor numero es: %d\n", sumaAntesesores);




	}
	else
	{
		printf("Hubo un error al cargar el array.");
	}

	return 0;
}
