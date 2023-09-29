/*
 ============================================================================
 Hildebrandt Santiago
 DIV K
 Ejercicio 6-2
 Realizar un programa que permita el ingreso de 10 números enteros (positivos y negativos).
Necesito generar un listado de los números positivos de manera creciente y negativos de manera
decreciente. (Como máximo 5 estructuras repetitivas)
Ejemplo:
Listado 1 : 4, 5, 6, 10, 18, 29
Listado 2 : -1,-5,-9,-12
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define SIZE 10


int main(void) {

	setbuf (stdout,NULL);
    int listadoPositivos [SIZE];
	int listadoNegativos [SIZE];
    int listadoAuxiliar [SIZE];
    //int contadorPositivos=0;
   // int contadorNegativos=0;
    int j=0;
	int k=0;
	int aux;

    for (int i=0; i<SIZE; i++)
    {
        printf ("Ingrese numero %d: ", i+1);
        scanf("%d",&listadoAuxiliar[i]);


        if (listadoAuxiliar[i]<0)
                {
        		listadoNegativos [j] = listadoAuxiliar[i];
				j++;
                } else
                {
                listadoPositivos [k]=listadoAuxiliar[i];
                k++;
                }
    }
    for(int i=0;i<SIZE-1;i++)
            {
            	for(int l=i+1;l<k;l++)
            	{
            		if(listadoPositivos[i]>listadoPositivos[l])
            		{
            			aux=listadoPositivos[i];
            			listadoPositivos[i]=listadoPositivos[l];
            			listadoPositivos[l]=aux;
            		}

            		if(listadoNegativos[i]<listadoNegativos[l])
            		    		{
            		    			aux=listadoNegativos[i];
            		    			listadoNegativos[i]=listadoNegativos[l];
            		    			listadoNegativos[l]=aux;
            		    		}
            	}
            }


printf ("Listado de negativos: ");
    for (int i=0; i<j; i++)
       {
    printf ("%d, ", listadoNegativos[i]);

       }
printf ("Listado de positivos: ");
    for (int i=0; i<k; i++)
           {
    printf ("%d, ", listadoPositivos[i]);

           }

}
