/*
 ============================================================================
 Name        : Ejercicio.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#define CANTIDAD 5
//ABM
//ALTAS
//BAJAS
//MODIFICACIONES

typedef struct{
	int legajo;
	float salario;
	char sexo;
	char nombre[31];
	int estado;

}eEmpleado;

int main(void)
{
	setbuf(stdout,NULL);

	eEmpleado empleados[CANTIDAD];
	int opcion;
	int i;
	int aux;
	char respuesta;

	for( i=0; i<CANTIDAD; i++)
	{
		empleados[i].estado = 0;
	}


	do{
		printf("1-ALTA\n2-BAJA\n3-MODIFICION\n4-Mostrar\n5-Salir\n");
		scanf("%d",&opcion);

		switch(opcion)
		{

		   case 1:
			   for( i=0; i<CANTIDAD; i++)
			   {
				   if(empleados[i].estado == 0)
				   {

					   printf("ingresa tu legajo: \n");
					   scanf("%d",&empleados[i].legajo);

					   printf("ingresa su salario: \n");
					   scanf("%f",&empleados[i].salario);

					   printf("ingresa su sexo: \n");
					   fflush(stdin);
					   scanf("%c",&empleados[i].sexo);

					   printf("ingresa su nombre: \n");
					   fflush(stdin);
					   scanf("%[^\n]",empleados[i].nombre);

					   empleados[i].estado=1;

					   break;
				   }

			   }

			   break;

		   case 2:
			   printf("Ingresa el legajo que quiera dar de baja: \n");
			   scanf("%d",&aux);
			   for( i=0; i<CANTIDAD; i++)
			 	{
				   if(empleados[i].legajo == aux)
				   {
					   if(empleados[i].estado == 1)
					   {
						   do
						   {
							printf("\nEsta seguro que quiere dar de baja al legajo: %d, empleado: %s? Igrese S/N", empleados[i].legajo,empleados[i].nombre);
							fflush(stdin);
							scanf("%c",&respuesta);
						   } while (respuesta!='S' && respuesta!='N');
						   if (respuesta == 'S')
						   {
							   printf("El empleado se dio de baja. \n");
						   empleados[i].estado=0;
						   break;
						   }
						   else
						   {
							   printf("El empleado no se dio de baja. \n");
							   break;
						   }
					   }
					   else
					   {
						   printf("Ese legajo no esta dado de alta: \n");
					   }
				   } else
				   {
					   printf("Ese legajo no existe: \n");
				   }
			 	}
			  // printf("BAJA\n");
			   break;

		   case 3:
			  printf("MODIFICION\n");
			  break;

		   case 4:
			   printf("legajo\t\t nombre \t\tsexo \t\tsalario\n");
			   for( i=0; i<CANTIDAD; i++)
			   {
				   if(empleados[i].estado == 1 )
				   {
					   printf("%d \t\t %s \t\t %c \t\t %.2f\n", empleados[i].legajo,empleados[i].nombre,empleados[i].sexo,empleados[i].salario);
				   }
			   }
			   break;
		   case 5:
			   printf("SALIR\n");
			   break;

		}

	}while(opcion !=5);





	return EXIT_SUCCESS;
}
