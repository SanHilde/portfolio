#include "funcionesNecesarias.h"
#include "inputs.h"
#include "abm.h"



int altaDatos(eEstructura temaEstructura[], int cantidadTotal , int estadoLibre, int estadoOcupado,
				char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroConDecimales, char* mensajeErrorGetCadena,  int intentos)
{
	int retorno;
	int indiceIncremental;
//	int i;

	retorno = 0;

	buscarLibre(temaEstructura,cantidadTotal,estadoLibre,&indiceIncremental);

	if(indiceIncremental > -1)
	{
		temaEstructura[indiceIncremental].idProducto = indiceIncremental;
		pedirCadena(temaEstructura[indiceIncremental].descripcion,50,"\nIngrese descripcion del producto: ");
		utn_getNumero (&temaEstructura[indiceIncremental].nacionalidad,
						"\nIngrese origen del producto\n1-EEUU\n2-Chine\n3-Otro\nOpcion: ",
						mensajeErrorGetNumero, 1, 3, intentos);
		utn_getNumero(&temaEstructura[indiceIncremental].tipo,
						"\nIngrese tipo de producto\n1-IPHONE\n2-MAC\n3-IPAD\n3-ACCESORIOS\nOpcion: ",
						mensajeErrorGetNumero, 1, 4, intentos);
		utn_getNumeroPositivoConDecimales(&temaEstructura[indiceIncremental].precio, "Ingrese precio: ",
											mensajeErrorGetNumeroConDecimales,0, intentos);
	    temaEstructura[indiceIncremental].estado=estadoOcupado;
	    retorno = 1;
	}
	return retorno;
}

//Devuelve el indice del proximo empleado inactivo que encuentre
int buscarLibre(eEstructura temaEstructura[],int cantidadTotal, int estado, int *indice)
{

	*indice = -1;//Si no encuentra un usuario inactivo-> Si el array está lleno.

	for(int i=0; i<cantidadTotal; i++)
    {
	   if(temaEstructura[i].estado == estado)
	   {
		   *indice = i;
		   return 1;
		   break;
	   }
    }

	return -1;
}

//Devuelve el indice de un empleado en cuestion
int buscarDato(eEstructura temaEstructura[],int cantidadTotal,int datoABuscar, int* indice, int estado)
{

	int retorno = -1;
	*indice = -1;

	for(int i=0; i<cantidadTotal; i++)
    {
	   if(temaEstructura[i].estado == estado && temaEstructura[i].idProducto == datoABuscar)
	   {
		   *indice = i;
		   retorno = 1;
		   break;
	   }
    }

	return retorno;
}

int bajarDato(eEstructura temaEstructura[],int cantidadTotal, int estadoLibre, int estadoOcupado,
				char *mensaje, char *mensajeError, int minimo, int intentos)
{
	int legajoABorrar;
	int retorno;
	int i;
	char confirmacion;

	utn_getNumeroPositivo(&legajoABorrar, &mensaje, mensajeError, minimo, intentos);
	buscarDato(temaEstructura,cantidadTotal,legajoABorrar,&i,estadoOcupado );

	retorno = -1;//Si no encontro al empleado a borrar
	pedirCaracter(&confirmacion, "ID encontrado ¿Desea eliminarlo? S/N", "El caracter ingresado no es correcto", intentos);
		do{
			if(confirmacion == 's')
			   {
					if(i > -1)
					{
						temaEstructura[i].estado=estadoLibre;
						retorno = 1;//Encontro al empleado y lo borro
					}
			   } else
			   {
				   retorno = 0;
			   }
		}while (confirmacion!= 's' || confirmacion != 'n');

    return retorno;
}

void mostrarDatos(eEstructura temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError, int estado)
{
   if(verificarLleno(temaEstructura,cantidadTotal,estado) == 1)
   {
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   if(temaEstructura[i].estado == estado)
		   {
			   mostrarDato(temaEstructura, i, mensajeError);
		   }
	   }
   }
   else
   {
	   printf("%s", mensajeError);
   }
}

void mostrarDato(eEstructura temaEstructura[],int indice, char* mensajeError)
{
	//printf("%s", mensaje);
	if(indice > -1)
	{
		 printf("%d \t\t\t %d \t\t\t %d \t\t %.2f\t\t%s\n", temaEstructura[indice].idProducto,temaEstructura[indice].nacionalidad,
				 temaEstructura[indice].tipo,temaEstructura[indice].precio,temaEstructura[indice].descripcion);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

int verificarLleno(eEstructura temaEstructura[],int cantidadTotal, int estado)
{
	int retorno;
	retorno = 0;

	for(int i=0; i<cantidadTotal; i++)
    {
	   if(temaEstructura[i].estado == estado)
	   {
		   retorno = 1;
		   break;
	   }
    }

	return retorno;
}

int modificarNombre(eEstructura temaEstructura[],int cantidadTotal, int estado, char* mensaje, char* mensajeError, int minimo, int intentos)
{
	int legajoAModificar;
	char nombreModificado[31];
	int i;
	char confirmacion;
	int retorno;
	retorno = -1;//Si no encontro al empleado

	utn_getNumeroPositivo(&legajoAModificar, mensaje, mensajeError, minimo, intentos );
	buscarDato(temaEstructura,cantidadTotal,legajoAModificar, &i, estado);

	if(i > -1)
	{
	   pedirCadena(nombreModificado,31,"Ingrese su nombre: ");
	   retorno = 0;//Si cancelo la operación
	   pedirCaracter(&confirmacion, "Usuario encontrado ¿Desea modificar al usuario? S/N", mensajeError, intentos);
	   if(confirmacion == 's')
	   {
		 //  strcpy(temaEstructura[i].nombre,nombreModificado);
		   retorno = 1;//Salió todo bien
	   }
	}

	return retorno;

}

int pedirConfirmacion (char *caracterConfirmacion, int intentos)
{
	int retorno;
	do
	{
		if (pedirCaracter(caracterConfirmacion, "ID encontrado ¿Desea eliminarlo? S/N", "El caracter ingresado no es correcto", intentos)==1)
		{
			retorno =1;
		}
		else
		{
			retorno=-1;
		}
	} while (*caracterConfirmacion != 's' || *caracterConfirmacion !='n');

	return retorno;
}

int respuesta (int valor)
{
	switch(valor)
	{
		case -1:
			printf("Hubo un error en la carga del dato, no se guardo nada.\n");//no manda aca en caso de ingresar 3 veces mal
			break;
		case 0:
			printf("Operacion cancelada.\n");
			break;
		case 1:
			printf("Se modifico con exito.\n");
			break;
	}
	return valor;
}

void subMenuModificar (eEstructura producto[], eTipo tipo[],
		int cantidadProductos, int cantidadPaises, int cantidadTipos, int estadoLibre,
		int estadoOcupado, char* mensajeBusquedaId,char* mensajeErrorCarga, char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo,
		char* mensajeErrorGetCadena,  int intentos)
{
	int opcionInterna;
	do
	{
		mostrarDatos(producto,cantidadProductos,"ID del producto\t\tNacionalidad\t\tTipo\t\tPrecio\t\tDescripcion\n",
								"\n\nNo hay datos para mostrar.\n", estadoOcupado);

		utn_getNumero(&opcionInterna,
					"\n¿Que desea modificar?\n"
					"1-Precio\n"
					"2-Tipo\n"
					"3-Salir\n"
					"Numero ingresado: ",
					mensajeErrorGetNumero,
					1,
					7,
					intentos);

			switch (opcionInterna)
			{
			case 1:
				respuesta (modificarPrecio (producto,cantidadProductos, estadoOcupado,mensajeBusquedaId, mensajeErrorGetNumero,
											mensajeErrorGetNumeroPositivo,0,intentos));
				break;
			case 2:
				respuesta(modificarTipo(producto,tipo,cantidadProductos, estadoOcupado, mensajeBusquedaId, mensajeErrorGetNumero,
															mensajeErrorCarga, 1, intentos, cantidadTipos));
				break;
			case 3:
				printf ("Usted a seleccionado salir, vuelta al menu principal.");
				break;
			}
	} while (opcionInterna != 3);
}

int modificarPrecio (eEstructura producto[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,char* mensajeErrorUTNGetPositivo,
					int minimo, int intentos)
{
	int idAModificiar;
	int i;
	float numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(producto,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
		   if (utn_getNumeroPositivoConDecimales(&numeroModificado,"Ingrese el precio nuevo: ",mensajeErrorUTNGetPositivo,minimo, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					producto[i].precio=numeroModificado;
				   retorno = 1;//Salió todo bien
			   }
			   else
			   {
				   retorno =0;
			   }
		   }else
		   {
		   retorno =-1;
		   }
		}
	}
	return retorno;
}

int modificarTipo (eEstructura producto[], eTipo tipo[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadTipos)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(producto,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
			mostrarTipo(tipo, 5,"\nID\t Editorial\n",mensajeErrorCarga);
		   if (utn_getNumero(&numeroModificado,"Ingrese el ID de nueva: ",mensajeErrorUTNGet,minimo, cantidadTotal, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					producto[i].idProducto=numeroModificado;
				   retorno = 1;//Salió todo bien
			   }
			   else
			   {
				   retorno =0;
			   }
		   }else
		   {
		   retorno =-1;
		   }
		}
	}
	return retorno;
}

int hardCodeoTipo (eTipo tipo[], int cantidadTipo)
{
	eTipo aux[]={ 		{1, "IPHONE"},
						{2, "MAC 2"},
						{3, "IPAD 3"},
						{4, "ACCESORIOS 4"}};
	int retorno =-1;

	if (cantidadTipo>0)
	{
		for (int i=0; i<cantidadTipo; i++)
		{
			tipo[i] = aux[i];
		}
		retorno =1;
	}
	return retorno;
}

int hardCodeoPaises (ePais pais[], int cantidadPaises)
{
	ePais aux[]={ 	{1, "EEUU"},
					{2, "CHINA"},
					{3, "OTROS"} };
	int retorno =-1;

	if (cantidadPaises>0)
	{
		for (int i=0; i<cantidadPaises; i++)
		{
			pais[i] = aux[i];
		}
		retorno =1;
	}
	return retorno;
}

void mostrarTipo (eTipo temaEstructura[],int cantidadTotal,int indice, char* mensajeError)
{
	if(indice > -1)
	{
		printf("%d \t %s\n", temaEstructura[indice].codigo, temaEstructura[indice].descripcion);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarTipos (eTipo temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError)
{
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   mostrarTipo(temaEstructura, cantidadTotal, i, mensajeError);
	   }
}
