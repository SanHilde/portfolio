/*
 * inputs.c
 *
 *  Created on: 17 sep. 2022
 *      Author: santy
 */

#include "inputs.h"

int utn_getNumero(int* pResultado, char* mensaje, char* mensajeError, int minimo, int maximo, int intentos)
{
	int ret=-1;
	int num;

	if (mensaje !=NULL && mensajeError!= NULL && minimo <= maximo && intentos >= 0)
	{
		while(intentos>0)
		{

			printf("%s",mensaje); //ingrese un numero
			if(scanf("%d",&num)==1)
			{
				if(num<=maximo && num>=minimo)
				break;
			}
				fflush(stdin);
				intentos--;
				printf("%s",mensajeError);
		}
			if(intentos!=0)
			{
				ret=1;
				*pResultado = num;
			}
	}
	return ret;
}

int utn_getNumeroPositivo(int* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos)
{
	int ret=-1;
	int num;

	if (mensaje !=NULL && mensajeError!= NULL && minimo >= 0 && intentos >= 0)
	{
		while(intentos>0)
		{
			printf("%s", mensaje);
			if(scanf("%d",&num)==1)
			{
				if(num>=minimo)
				{
					break;
				}
			}
				fflush(stdin);
				intentos--;
				printf("%s", mensajeError);
		}
			if(intentos!=0)
			{
				ret=1;
				*pResultado = num;
			}
	}

	return ret;
}

int utn_getNumeroPositivoConDecimales(float* pResultado, char* mensaje, char* mensajeError, int minimo, int intentos)
{
	int ret=-1;
	float num;

	if (mensaje !=NULL && mensajeError!= NULL && minimo >= 0 && intentos >= 0)
	{
		while(intentos>0)
		{
			printf("%s",mensaje);
			if(scanf("%f",&num)==1)
			{
				if(num>=minimo)
				{
					break;
				}
			}
			fflush(stdin);
			intentos--;
			printf("%s",mensajeError);
		}
			if(intentos!=0)
			{
				ret=1;
				*pResultado = num;
			}
	}

	return ret;
}

int pedirCaracter(char* pResultado, char* mensaje, char* mensajeError, int intentos)
{
	char caracter;
	int ret=-1;

	while(intentos>0)
	{
		printf("%s",mensaje);
		fflush(stdin);
		if (scanf("%c",&caracter)==1)
		{
			ret=1;
			break;
		}
		intentos--;
		printf("%s",mensajeError);
	}

	if(intentos!=0)
	{
		*pResultado = caracter;
	}
	return ret;
}

int pedirCadena(char* pResultado, int len, char* mensaje, char* mensajeError,int intentos)
{
	int retorno;
	char buffer[1024];
	int largoBuffer;

	retorno = -1;

	while (intentos > 0)
	{
		printf("%s", mensaje);
		fflush(stdin);
		scanf("%[^\n]", buffer);

		largoBuffer = (int) strlen(buffer);

		if (len > largoBuffer)
		{
			retorno = 1;
			break;
		}
		intentos--;
		printf("%s", mensajeError);
	}

	if (intentos != 0)
	{
		strcpy(pResultado, buffer);
	}
	return retorno;
}
