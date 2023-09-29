/*
 ============================================================================

Realizar un programa que permita la carga de temperaturas en celsius y fahrenheit , validando que
las temperaturas ingresadas estén entre el punto de congelación y ebullición del agua para cada
tipo de escala.
Las validaciones se hacen en una biblioteca.
Las funciones de transformación de fahrenheit a celsius y de celsius a fahrenheit se hacen en otra
biblioteca.
Extra:
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
//#include <stdio_ext.h>
#include "validacionTemperaturas.h"
#include "convercionTemperaturas.h"

//float pasajeFarenheitCelcius(float);
//float pasajeCelciusFarenheit(float);
//float validacionCelcius (float);
//float validacionFarenheit (float);

int main(void) {
	setbuf (stdout,NULL);

float temperaturaIngresada;
char tipoTemperatura;
float resultado;

printf("Ingrese el tipo de temperatura a ingresar ('c' para Celcius, 'f' para Farenheit): ");
fflush(stdin);
scanf("%c", &tipoTemperatura);
    while (tipoTemperatura!='f' && tipoTemperatura!='c')
    {
    printf("Incorrecto, ingrese 'c' para Celcius, 'f' para Farenheit): ");
    fflush(stdin);
    scanf("%c", &tipoTemperatura);
    }

printf ("Ingrese una temperatura, entre punto de ebullicion y punto de congelamiento: ");
scanf ("%f", &temperaturaIngresada);

switch (tipoTemperatura)
{
case 'c':
validacionCelcius(temperaturaIngresada);
resultado=pasajeCelciusFarenheit (temperaturaIngresada);
printf ("%.2f °F",resultado);
break;

default:
validacionFarenheit(temperaturaIngresada);
resultado=pasajeFarenheitCelcius (temperaturaIngresada);
printf ("%.2f °C",resultado);
//break;
}

}




