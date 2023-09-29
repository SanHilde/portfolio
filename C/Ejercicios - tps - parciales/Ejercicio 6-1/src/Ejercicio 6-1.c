/*
 ============================================================================
Hildebrandt Santiago
DIV K
Ejercicio 6-1:
Disponemos de dos variables numéricas (a y b). Realizar un algoritmo que permita el intercambio
de valores de dichas variables.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(void) {
	setbuf (stdout,NULL);
	int a;
	int b;
	int aux;

	printf ("Ingrese valor de variable A: ");
	scanf("%d",&a);

	printf ("Ingrese valor de variable B: ");
	scanf("%d",&b);

	printf ("La variable A = %d y la variable B = %d \n", a, b);

	aux = b;
	b = a;
	a = aux;

	printf ("Ahora, la variable A = %d y la variable B = %d ", a, b);
}
