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
#include <ctype.h>

#define CANT 3
#define LIBRE 0
#define OCUPADO 1


int pedirEntero(char mensaje[]);
char pedirCaracter(char mensaje[]);
int inicializarNumeros (int valorParaIniciar, int array[], int tam);
void confirmacion (int resultado, char mensajeConfirmacion[], char mensajeError[]);
int cargarNumerosSecuencial(int array[], int tam, char mensaje[]);
int validacionDosValores (int valorMinimoValidacion, int valorMaximoValidacion, char mensaje[], int valorAValidar);
void mostrarNumerosLista(int array[],int tam);
void mostrarNumeroIndividual(int array[], int i);
int calcularPromedio(int suma, int contador, float *resultado);
int acumularNumeros(int array[],int tam);
int ordenar (int array[],int tam);
//int cargarNumerosAleatoriosValidadosDosValores (int array[], char mensajePedirPosicion, char mensajePedirPosicion, char mensajePedirCaracter);

int main(void)
{

int opcion;
int resultado;
int valorParaIniciar=0;
int i;
char seguir;
//int validacion;
int valorMinimoValidacion=1;
int valorMaximoValidacion=120;
int opcionInterna;
int suma;
int edades[CANT];
float resultadoPromedio;

	do{
		setbuf (stdout, NULL);

		opcion=pedirEntero ("\n\nSeleccione una opcion:\n"
				"1: Inicializar\n"
				"2: Cargar\n"
				"3: Mostrar\n"
				"4: Calcular Promedio\n"
				"5: Ordenar\n"
				"\nOpcion: ");

			switch(opcion){
				case 1:
					printf ("\nUsted a seleccionado la opcion %d: inicializar.\n", opcion);
					resultado = inicializarNumeros (valorParaIniciar, edades, CANT);
					confirmacion (resultado, "Se inicializo todo correctamente.\n", "Hubo un error en la inicializacion.\n");
					break;
				case 2:
					printf ("\nUsted a seleccionado la opcion %d: cargar.\n", opcion);
					//resultado = cargarNumerosSecuencial (edades, CANT, "Ingrese un numero: ");
					do
						{
						i=pedirEntero("Ingregese la posicion donde quiere guardar: \n")-1;
						edades[i]=pedirEntero("Ingrese la edad: \n");//, entre los valores %d y %d:",valorMinimoValidacion,valorMaximoValidacion );
						//edades[i]=resultado;
/*
							int aux;
							aux = edades[i];
						while (aux<valorMinimoValidacion  || aux>valorMaximoValidacion)
							{
							aux=pedirEntero("Error, reingrese edad: ");
							}
*/
						if (validacionDosValores(valorMaximoValidacion,valorMinimoValidacion,"Valor ingresado no es correcto, reingrese:  ", edades[i])==1)
						{
						seguir=pedirCaracter("Desea seguir cargando edades? S/N: ");
						}
						}while(seguir=='s');

					confirmacion (resultado, "Se cargo todo correctamente.\n", "Hubo un error en la carga.\n");
					break;
				case 3:
					printf ("\nUsted a seleccionado la opcion %d: mostrar.\n", opcion);
					opcionInterna = pedirEntero("Que desea mostrar?\n"
												"1-Una posicion especifica\n"
												"2-Lista entera\n");
					switch (opcionInterna)
					{
					case 1:
						i= pedirEntero ("Que posicion desea mostrar?")-1;
						mostrarNumeroIndividual (edades, i);
						break;
					case 2:
						mostrarNumerosLista (edades, CANT);
						break;
					}


					break;
				case 4:
					printf ("\nUsted a seleccionado la opcion %d: calcular promedio.\n", opcion);

					suma = acumularNumeros(edades, CANT);
		//			resultado = calcularPromedio( suma, CANT, &resultadoPromedio);
					if (calcularPromedio( suma, CANT, &resultadoPromedio)==1)
					{
						printf ("El promedio es: %.2f", resultadoPromedio);
					}
					else
					{
						printf ("Hubo un error en el calculo del promedio");
					}

					break;
				case 5:
					printf ("\nUsted a seleccionado la opcion %d: ordenar.\n", opcion);
					if (ordenar (edades,CANT)==1)
					{
						printf ("Se ordeno correctamente");
					}
					else
					{
						printf ("Hubo un error en el ordenamiento");
					}

					break;
				default:
					printf("\nOpcion incorrecta, reingrese opcion.\n");


						}

		} while( opcion < 5 || opcion>1 );

	return EXIT_SUCCESS;
}

//input
int pedirEntero(char mensaje[])
{
	int numero;

	printf("%s",mensaje);
	scanf("%d", &numero);

	return numero;
}

char pedirCaracter(char mensaje[])
{
	char caracter;
	fflush (stdin);
	printf("%s",mensaje);
	scanf("%c", &caracter);

	return caracter;
}

//input
int inicializarNumeros (int valorParaIniciar, int array[], int tam)
{
	int retorno = 0;

	if(tam > 0)
	{
		for(int i = 0; i<tam; i++)
		{
			array[i]=valorParaIniciar;
		}

		retorno = 1;
	}

	return retorno;
}

//input
void confirmacion (int resultado, char mensajeConfirmacion[], char mensajeError[])
{

	if (resultado == 1)
	{
	printf ("%s", mensajeConfirmacion);
	} else {
	printf ("%s", mensajeError);
	}

}

//input
int cargarNumerosSecuencial(int array[], int tam, char mensaje[])
{
	int retorno = 0;

	if(tam > 0)
	{
		for(int i = 0; i<tam; i++)
		{
			printf ("%d- ", i+1);
			array[i]=pedirEntero(mensaje);
			//printf("Ingrese el numero %d: ",i+1);
			//scanf("%d",&array[i]);
		}

		retorno = 1;
	}

	return retorno;
}


int validacionDosValores (int valorMaximoValidacion, int valorMinimoValidacion, char mensaje[], int valorAValidar)
{
	//printf ("%d", valorAValidar);
	while (valorAValidar<valorMinimoValidacion  || valorAValidar>valorMaximoValidacion)
	{
		valorAValidar=pedirEntero(mensaje);
		//printf ("%d", valorAValidar);
	}
	return 1;
}

void mostrarNumerosLista(int array[],int tam)
{
	printf("\nLas edades ingresadas son: ");

	for(int i = 0; i<tam; i++)
	{
		//printf("\nPosicion %d, edad: %d",i+1, array[i]);
		mostrarNumeroIndividual (array, i);
	}

}

void mostrarNumeroIndividual(int array[], int i)
{
	printf("\nPosicion %d, edad: %d",i+1, array[i]);

}

int calcularPromedio(int suma, int contador, float* resultado)
{
	if (contador!= 0)
	{
	*resultado = (float) suma / contador;
	return 1;
	}
	else
	{
	return -1;
	}
}

//funcion 6
int acumularNumeros(int array[],int tam)
{
	int suma;
	suma = 0;

	for(int i = 0; i<tam; i++)
	{
		suma = suma + array[i];
	}

	return suma;
}

int ordenar (int array[],int tam)
{

	int i;
	int j;
	int aux;

	for(i=0;i<tam-1;i++)
	{
		for(j=i+1;j<tam;j++)
		{
				if(array[i]>array[j])
				{
					aux=array[i];
					array[i]=array[j];
					array[j]=aux;

				}
		}
	}
	return 1;
}







/*
int cargarNumerosAleatoriosValidadosDosValores (int array[], char mensajePedirPosicion, char mensajePedirPosicion, char mensajePedirCaracter, int valorMaximo, int valorMinimo, int mensajeError, int array[])
{
	char seguir;
	int i;
	do
	{
	i=pedirEntero(mensajePedirPosicion);
	array[i]=pedirEntero(valorMaximo,valorMinimo,mensajeError, array[], i);
	seguir=pedirCaracter(mensajePedirCaracter);
	}while(seguir=='s');
	return 1;
}

*/
