/*
 ============================================================================


Hildebrandt Santiago, DIK K
 Ejercicio 4-1:
Realizar un programa EN EL MAINque permita calcular y mostrar el factorial de un
número. Utilizar la función PedirNumero de la ejercitación 3-4.
Por ejemplo:
5! = 5*4*3*2*1 = 120
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
//#include "../../../misBibliotecas/OperacionesAritmeticas.h"
#include "OperacionesSimples.h"

int main(void) {
	int numeroIngresado;
	int resultado;
	setbuf (stdout,NULL);

	 printf ("Ingrese un numero para averiguar su factorial: ");
	 scanf ("%d", &numeroIngresado);
	 resultado = calcularFactorial (numeroIngresado);
	 printf ("El factorial es: %d", resultado);
return 0;
}

