/*
 ============================================================================
Hildebrandt Santiago
Div K
Ejercicio 1-3: ingresar 3 números y mostrar el número del medio, sólo si existe. En caso de que no
exista también informarlo.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
//#include "../../misBibliotecas/OperacionesAritmeticas.h"

int main(void)
{
	 	int numero1;
	    int numero2;
	    int numero3;
	    int resultado;
	    int bandera=0;


	    setbuf (stdout,NULL);

	    printf ("Ingrese un numero: ");
	    scanf ("%d",&numero1);

	    printf ("Ingrese un numero: ");
	    scanf ("%d",&numero2);

	    printf ("Ingrese un numero: ");
	    scanf ("%d",&numero3);

	   if (numero1>numero2 && numero1>numero3)
	    {
	        if (numero2>numero3)
	        {
	        resultado=numero2;
	        }
	        else if (numero3>numero2)
	        {
	        resultado=numero3;
	        }
	        else
	        {
	        bandera=1;
	        }
	    }
	    else if (numero2>numero1 && numero2>numero3)
	    {
	        if (numero1>numero3)
	        {
	        resultado=numero1;
	        }
	        else if (numero3>numero1)
	        {
	        resultado=numero3;
	        }
	        else
	        {
	        bandera=1;
	        }
	    }
	    else if (numero3>numero1 && numero3>numero2)
	    {
	        if (numero1>numero2)
	        {
	        resultado=numero1;
	        }
	        else if (numero2>numero1)
	        {
	        resultado=numero2;
	        }
	        else
	        {
	        bandera=1;
	        }
	    }
	    else
	    {
	    bandera=1;
	    }

	if (bandera==1)
	{
	   printf ("No existe numero intermedio" );
	}
	else
	{
	    printf ("El numero intermedio es: %d", resultado );
	}
}
