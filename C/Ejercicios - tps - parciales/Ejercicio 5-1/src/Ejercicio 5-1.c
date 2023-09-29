/*
 ============================================================================
Hildebrandt Santiago
DIV K
Ejercicio 5-1:
Pedir el ingreso de 5 números. Mostrarlos y calcular la sumatoria de los mismos.
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
	int contador;
	int suma;
	float promedio;

	//InicializarNumeros(numeros,SIZE);
	//MostrarNumeros(numeros,SIZE);


	if(cargarNumeros(numeros,SIZE) == 1)
	{
		printf("Se cargo el array.\n");
		suma = acumularNumeros(numeros,SIZE);
		contador = contarNumeros(numeros,SIZE);
		promedio = calcularPromedio(suma,contador);

		printf("La suma es: %d\n", suma);
		printf("El promedio es: %.2f\n", promedio);

		mostrarNumerosLista(numeros,SIZE);
	}
	else
	{
		printf("Hubo un error al cargar el array.");
	}

	return 0;
}
/*
#include <stdio.h>
#include <stdlib.h>
#define TAM 5

int main(void) {

	setbuf (stdout,NULL);

int numero [TAM];
int sumatoria=0;
float promedio;
int i;

for (i=0; i<TAM; i++)
{
	printf ("Ingrese un numero %d: ", i+1)	;
	scanf ("%d", &numero[i]);
	sumatoria= sumatoria + numero[i];
}
promedio = (float) sumatoria / i;

for (i=0; i<TAM-1; i++)
{
	printf ("%d + ", numero [i]);
}
printf ("%d= %d",numero[TAM-1], sumatoria);
printf ("\nSu promedio es: %.2f", promedio );
}
*/
