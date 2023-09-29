//#include "funcionesNecesarias.h"
#include "inputs.h"
#include "abm.h"

int hardCodeoAutores (eAutor autor[], int cantidadAutores)
{
	eAutor aux[]={ 	{1, "JORGE LUIS BORGES", 1},
					{2, "JULIO CORTAZAR  ", 1},
					{3, "HERNAN CASCIARI  ", 1},
					{4, "EDUARDO SACHERI  ", 1},
					{5, "FEDERICO GARCIA LORCA", 2},
					{6, "JOANNE ROWLING  ", 3},
					{7, "GEORGE ORWELL  ", 3},
					{8, "JOHN RONALD TOLKIEN", 3},
					{9, "STEPHEN KING  ", 4},
					{10, "EDUARDO GALEANO  ", 5}  };
	int retorno =-1;

	if (cantidadAutores>0)
	{
		for (int i=0; i<cantidadAutores; i++)
		{
			autor[i] = aux[i];
		}
		retorno =1;
	}
	return retorno;
}

int hardCodeoEditoriales (eEditorial editorial[], int cantidadEditorial)
{
	eEditorial aux[]={ 	{1, "EDITORIAL 1"},
						{2, "EDITORIAL 2"},
						{3, "EDITORIAL 3"},
						{4, "EDITORIAL 4"},
						{5, "EDITORIAL 5"}	};
	int retorno =-1;

	if (cantidadEditorial>0)
	{
		for (int i=0; i<cantidadEditorial; i++)
		{
			editorial[i] = aux[i];
		}
		retorno =1;
	}
	return retorno;
}

int hardCodeoGenero (eGenero genero[], int cantidadGenero)
{
	eGenero aux[]={ 	{1, "Narrativo"},
						{2, "Lirico\t"},
						{3, "Dramatico"},
						{4, "Didactico"},
						{5, "Novela\t"}	};
	int retorno =-1;

	if (cantidadGenero>0)
	{
		for (int i=0; i<cantidadGenero; i++)
		{
			genero[i] = aux[i];
		}
		retorno =1;
	}
	return retorno;
}

int hardCodeoPaises (ePais pais[], int cantidadPaises)
{
	ePais aux[]={ 	{1, "ARGENTINA"},
					{2, "ESPANIA"},
					{3, "INGLATERRA"},
					{4, "EEUU"},
					{5, "URUGUAY"} };
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

int inicializador (eLibro estructura[], int cantidadTotal, int estadoLibre, int indiceAEmpezar)
{
	int retorno=-1;

	if(cantidadTotal > 0)
	{
		for(int i=indiceAEmpezar; i<cantidadTotal; i++)
		{
			estructura[i].estado = estadoLibre;
		}
		retorno =1;
	}

	return retorno;
}

int altaDatos(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero [],int cantidadTotalLibros ,
		int cantidadAutores, int cantidadPaises, int cantidadEditoriales, int cantidadGeneros, int estadoLibre,int estadoOcupado,
		char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo, char* mensajeErrorGetCadena,  int intentos)
{
	int retorno;
	int indiceIncremental;
	char mensajeErrorCarga[] = ("Hubo un error en la carga de datos. Se volvera al menu principal.\n");

	retorno = 0;

	buscarLibre(libro,cantidadTotalLibros,estadoLibre,&indiceIncremental);

	if(indiceIncremental > -1)
	{
		libro[indiceIncremental].codigoLibro = indiceIncremental+1;
		if (pedirCadena(libro[indiceIncremental].tituloLibro,51,"\nIngrese el titulo del libro: ", mensajeErrorGetCadena, intentos )==1 &&

		utn_getNumero (&libro[indiceIncremental].fechaPublicacion.dia,"\nIngrese el dia (del 1 al 31) de la fecha de publicacion: ",
						mensajeErrorGetNumero, 1, 31, intentos) ==1 &&
		utn_getNumero (&libro[indiceIncremental].fechaPublicacion.mes,"\nIngrese el mes (del 1 al 12) de la fecha de publicacion: ",
						mensajeErrorGetNumero, 1, 12, intentos)== 1 &&
		utn_getNumeroPositivo (&libro[indiceIncremental].fechaPublicacion.anio,"\nIngrese el anio de la fecha de publicacion: ",
								"Ingrese un anio superior al 1700", 1700, intentos)== 1 &&

		utn_getNumeroPositivoConDecimales(&libro[indiceIncremental].precio, "\nIngrese precio: ",mensajeErrorGetNumeroPositivo,0, intentos)==1)
		{
			mostrarAutores(autor,pais, cantidadAutores, cantidadPaises,"\nID\t AUTOR\t\t\t NACIONALIDAD\n","\n\nNo hay datos para mostrar.\n");
			if (utn_getNumero (&libro[indiceIncremental].idAutor,"\nIngrese el ID del autor: ",mensajeErrorGetNumero, 1, cantidadAutores, intentos)==1)
			{
				mostrarEditoriales(editorial, cantidadEditoriales,"\nID\t Editorial\n","\n\nNo hay datos para mostrar.\n");
				if (utn_getNumero(&libro[indiceIncremental].idEditorial,"\nIngrese el ID de la editorial:  ",
						mensajeErrorGetNumero, 1, cantidadEditoriales, intentos)==1)
				{
					mostrarGeneros (genero, cantidadGeneros, "\nID\t Genero\n", "\n\nNo hay datos para mostrar.\n");
					if (utn_getNumero(&libro[indiceIncremental].idGenero,"\nIngrese el ID del genero:  ",
							mensajeErrorGetNumero, 1, cantidadGeneros, intentos)==1)
					{
						libro[indiceIncremental].estado=estadoOcupado;
						retorno = 1;
						} else
						{
							printf ("%s", mensajeErrorCarga);
						}
					} else
					{
						printf ("%s", mensajeErrorCarga);
					}
			} else
			{
				printf ("%s", mensajeErrorCarga);
			}
		} else
		{
			printf ("%s", mensajeErrorCarga);
		}
	} else
	  {
		   printf("Lo siento, la lista esta llena.\n");
	  }
	return retorno;
}

//Devuelve el indice del proximo empleado inactivo que encuentre
int buscarLibre(eLibro temaEstructura[],int cantidadTotalLibros, int estado, int *indice)
{

	*indice = -1;//Si no encuentra un usuario inactivo-> Si el array está lleno.

	for(int i=0; i<cantidadTotalLibros; i++)
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
int buscarDato(eLibro temaEstructura[],int cantidadTotalLibros,int datoABuscar, int* indice, int estado)
{

	int retorno = -1;
	*indice = -1;

	for(int i=0; i<cantidadTotalLibros; i++)
    {
	   if(temaEstructura[i].estado == estado && temaEstructura[i].codigoLibro == datoABuscar)
	   {
		   *indice = i;
		   retorno = 1;
		   break;
	   }
    }

	return retorno;
}

int bajarDato(eLibro temaEstructura[],int cantidadTotalLibros, int estadoLibre, int estadoOcupado,int estadoBajado,char *mensaje,
				char *mensajeError, int minimo, int intentos )
{
	int idABajar;
	int retorno=-1;
	int i;
	char confirmacion;

	if (utn_getNumeroPositivo(&idABajar, mensaje, mensajeError, minimo, intentos)==1)
	{
		buscarDato(temaEstructura,cantidadTotalLibros,idABajar,&i,estadoOcupado );
		if (i>-1)
		{
			pedirConfirmacion ( &confirmacion,intentos);
			if(confirmacion == 'S')
		   {
				temaEstructura[i].estado=estadoBajado;
				retorno = 1;//Encontro al empleado y lo borro
		   }
		   else
		   {
			   retorno = 0;
		   }
		} else
		{
			printf ("El ID no existe.\n");
			retorno =0;
		}
	}
    return retorno;
}

void mostrarDatos(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],int cantidadTotal,
		char* mensaje, char* mensajeError, int estado)
{
   if(verificarLleno(libro,cantidadTotal,estado) == 1)
   {
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   if(libro[i].estado == estado)
		   {
			  mostrarDato(libro, autor, pais, editorial, fecha, i, mensajeError);
		   }
	   }
   }
   else
   {
	   printf("%s", mensajeError);
   }
}

void mostrarDato(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],int indice, char* mensajeError)
{
	//printf("%s", mensaje);
	int j;
	int l;
	int k;
	int auxPais=0;
	int auxEditorial=0;
	int auxAutor=0;

	if(indice > -1)
	{

		for( j=0; j<5; j++ )
		{
			if( libro[indice].idEditorial == editorial[j].codigoEditorial )
			{
				auxEditorial = j;
			}

		}


		for( l=0; l<10; l++ )
		{
			if( libro[indice].idAutor == autor[l].codigoAutor )
			{
				auxAutor = l;
				for( k=0; k<5; k++ )
				{
					if( autor[l].idNacionalidad == pais[k].codigoPais )
					{
						auxPais = k;
					}
				}
			}

		}
	printf("\n%d\t %s\t %s\t %s\t %.2f  %d-%d-%d\t %s", libro[indice].codigoLibro,autor[auxAutor].nombreAutor,pais[auxPais].descripcionPais,
			editorial[auxEditorial].descripcionEditorial,libro[indice].precio,libro[indice].fechaPublicacion.dia,
			libro[indice].fechaPublicacion.mes,libro[indice].fechaPublicacion.anio,libro[indice].tituloLibro);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

int verificarLleno(eLibro temaEstructura[],int cantidadTotal, int estadoOcupado)
{
	int retorno;
	retorno = 0;

	for(int i=0; i<cantidadTotal; i++)
    {
	   if(temaEstructura[i].estado == estadoOcupado)
	   {
		   retorno = 1;
		   break;
	   }
    }

	return retorno;
}

int modificarLibro(eLibro temaEstructura[],int cantidadTotal, int estado, char* mensaje, char* mensajeError, char* mensajeErrorCadena,
		int minimo, int intentos, int len)
{
	int idAModificiar;
	char nombreModificado[len];
	int i;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumeroPositivo(&idAModificiar, mensaje, mensajeError, minimo, intentos )==1)
	{
		buscarDato(temaEstructura,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{

		   if (pedirCadena(nombreModificado,len,"Ingrese el nuevo nombre del libro: ",mensajeErrorCadena, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
				   strcpy(temaEstructura[i].tituloLibro,nombreModificado);
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

int pedirConfirmacion (char *caracterConfirmacion, int intentos)
{
	int retorno=-1;
	do
	{
		if (pedirCaracter(caracterConfirmacion, "ID encontrado ¿Desea realizar la operacion? S/N: ",
				"Lo que se ingreso no es un caracter.\n", intentos)==1)
		{
			retorno =1;
		}

		*caracterConfirmacion = toupper (*caracterConfirmacion);
	} while (*caracterConfirmacion != 'S' && *caracterConfirmacion !='N');

	return retorno;
}

void mostrarAutor(eAutor autor[],ePais pais[],int cantidadTotal,int indice, char* mensajeError)
{
	int j;
	if(indice > -1)
	{
		for( j=0; j<cantidadTotal; j++ )
		{
			if( autor[indice].idNacionalidad == pais[j].codigoPais )
			{
				printf("%d \t %s \t %s \n", autor[indice].codigoAutor, autor[indice].nombreAutor, pais[j].descripcionPais);
				break;
			}
		}
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarAutores(eAutor autor[],ePais pais[],int cantidadAutores, int cantidadPaises, char* mensaje, char* mensajeError)
{
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadAutores; i++)
	   {
		   mostrarAutor(autor, pais, cantidadPaises, i, mensajeError);
	   }
}

void mostrarEditorial(eEditorial temaEstructura[],int cantidadTotal,int indice, char* mensajeError)
{
	if(indice > -1)
	{
		printf("%d \t %s\n", temaEstructura[indice].codigoEditorial, temaEstructura[indice].descripcionEditorial);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarEditoriales(eEditorial temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError)
{
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   mostrarEditorial(temaEstructura, cantidadTotal, i, mensajeError);
	   }
}

void mostrarPais(ePais temaEstructura[],int cantidadTotal,int indice, char* mensajeError)
{
	if(indice > -1)
	{
		printf("%d \t %s\n", temaEstructura[indice].codigoPais, temaEstructura[indice].descripcionPais);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarPaises(ePais temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError)
{
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   mostrarPais(temaEstructura, cantidadTotal, i, mensajeError);
	   }
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

int modificarAutor(eLibro libro[], ePais pais[], eAutor autor[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadAutores, int cantidadPaises)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
			mostrarAutores(autor,pais, cantidadAutores,cantidadPaises,"\nID\t AUTOR\t\t\t NACIONALIDAD\n", mensajeErrorCarga);
		   if (utn_getNumero(&numeroModificado,"Ingrese el ID del autor nuevo: ",mensajeErrorUTNGet,minimo, cantidadAutores, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].idAutor=numeroModificado;
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

int modificarEditorial (eLibro libro[], eEditorial editorial[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadEditoriales)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
			mostrarEditoriales(editorial, 5,"\nID\t Editorial\n",mensajeErrorCarga);
		   if (utn_getNumero(&numeroModificado,"Ingrese el ID de la editorial nueva: ",mensajeErrorUTNGet,minimo, cantidadEditoriales, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].idEditorial=numeroModificado;
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

int modificarPrecio (eLibro libro[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,char* mensajeErrorUTNGetPositivo,
					int minimo, int intentos)
{
	int idAModificiar;
	int i;
	float numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
		   if (utn_getNumeroPositivoConDecimales(&numeroModificado,"Ingrese el precio nuevo: ",mensajeErrorUTNGetPositivo,minimo, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].precio=numeroModificado;
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

int modificarDia (eLibro libro[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet, int minimo, int intentos)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
		   if (utn_getNumero (&numeroModificado,"\nIngrese el dia (del 1 al 31) nuevo: ", mensajeErrorUTNGet, minimo, 31, intentos) ==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].fechaPublicacion.dia=numeroModificado;
					retorno = 1;//Salió todo bien
			   }
			   else
			   {
				   retorno =0;
			   }
		   }
		   else
		   {
		   retorno =-1;
		   }
		}
	}
	return retorno;
}

int modificarMes (eLibro libro[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet, int minimo, int intentos)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
		   if (utn_getNumero (&numeroModificado,"\nIngrese el mes (del 1 al 12) nuevo: ", mensajeErrorUTNGet, minimo, 12, intentos) ==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].fechaPublicacion.mes=numeroModificado;
					retorno = 1;//Salió todo bien
			   }
			   else
			   {
				   retorno =0;
			   }
		   }
		   else
		   {
		   retorno =-1;
		   }
		}
	}
	return retorno;
}

int modificarAnio (eLibro libro[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet, char* mensajeErrorUTNGetPositivo,
					int minimo, int intentos)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
		   if (utn_getNumeroPositivo (&numeroModificado,"\nIngrese el anio (superior a 1700) nuevo: ", mensajeErrorUTNGetPositivo,
				   	   	   	   	   	   1700, intentos) ==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].fechaPublicacion.anio=numeroModificado;
					retorno = 1;//Salió todo bien
			   }
			   else
			   {
				   retorno =0;
			   }
		   }
		   else
		   {
		   retorno =-1;
		   }
		}
	}
	return retorno;
}

void mostrarLibrosOrdenados (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],
		int cantidadTotal, int estadoOcupado, char* mensajeErrorCarga)
{
	int i;
	int j;
	eLibro aux;

	for( i=0; i<cantidadTotal-1; i++)
	{
		if (libro[i].estado == estadoOcupado)
		{
			for( j=i+1; j<cantidadTotal; j++ )
			{
				if(libro[j].estado == estadoOcupado)
				{
					if (libro[i].precio<libro[j].precio)
					{
						aux=libro[i];
						libro[i]=libro[j];
						libro[j]=aux;
					} else
					{
						if (libro[i].precio==libro[j].precio)
						{
							if (strcmp (libro[i].tituloLibro,libro[j].tituloLibro)>0)
							{
								aux=libro[i];
								libro[i]=libro[j];
								libro[j]=aux;
							}
						}
					}

				}
			}
		}
	}
	mostrarDatos(libro, autor, pais, editorial, fecha, cantidadTotal,"\nID \t Autor \t\t\t Nacionalidad \t Editorial "
													"\t Precio  Publicacion \t Libro \n",mensajeErrorCarga, estadoOcupado);
}

void mostrarLibros (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],
		int cantidadTotal, int estadoOcupado, char* mensajeErrorCarga)
{
	int i;
	int j;
	eLibro aux;

	for( i=0; i<cantidadTotal-1; i++)
	{
		if (libro[i].estado == estadoOcupado)
		{
			for( j=i+1; j<cantidadTotal; j++ )
			{
				if(libro[j].estado == estadoOcupado)
				{
					if (libro[i].codigoLibro>libro[j].codigoLibro)
					{
						aux=libro[i];
						libro[i]=libro[j];
						libro[j]=aux;
					}

				}
			}
		}
	}
	mostrarDatos(libro, autor, pais, editorial, fecha, cantidadTotal,"\nID \t Autor \t\t\t Nacionalidad \t Editorial "
													"\t Precio  Publicacion \t Libro \n",mensajeErrorCarga, estadoOcupado);
}

void menuPrincipal (int *opcionMenuPrincipal, char *mensajeErrorGetNumero, int minimo, int maximo, int intentos)
{
	utn_getNumero(opcionMenuPrincipal,
					"\n\n\t\tMenu principal\n"
					"Seleccione que desea realizar:\n"
					"1-Alta\n"
					"2-Baja\n"
					"3-Modificacion\n"
					"4-Importes\n"
					"5-Libros cuya fecha de publicación es anterior a 01/01/2000\n"
					"6-Lista de editoriales\n"
					"7-Lista de paises\n"
					"8-Lista de autores\n"
					"9-Lista de libros por ID\n"
					"10-Lista de libros, por precio y nombre\n"
					"11-Lista de generos\n"
					"12-Lista de libros que no sean novela\n"
					"13-Lista de libros de autores argentinos, editorial a elegir\n"
					"14-Salir\n"
					"Numero ingresado: ",
					mensajeErrorGetNumero,
					minimo,
					maximo,
					intentos);
}

void subMenuModificar (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],
		int cantidadTotalLibros ,int cantidadAutores, int cantidadPaises, int cantidadEditoriales, int cantidadGeneros, int estadoLibre,
		int estadoOcupado, char* mensajeBusquedaId,char* mensajeErrorCarga, char* mensajeErrorGetNumero, char* mensajeErrorGetNumeroPositivo,
		char* mensajeErrorGetCadena,  int intentos)
{
	int opcionInterna;
	do
	{
		mostrarDatos(libro, autor, pais, editorial,fecha,cantidadTotalLibros, "\nID \t Autor \t\t\t Nacionalidad \t Editorial "
					"\t Precio  Publicacion \t Libro \n", mensajeErrorCarga, estadoOcupado);

		utn_getNumero(&opcionInterna,
					"\n¿Que desea modificar?\n"
					"1-Libro\n"
					"2-Autor\n"
					"3-Editorial\n"
					"4-Precio\n"
					"5-Fecha de publicacion\n"
					"6-Genero\n"
					"7-Salir\n"
					"Numero ingresado: ",
					mensajeErrorGetNumero,
					1,
					7,
					intentos);

			switch (opcionInterna)
			{
			case 1:
				respuesta(modificarLibro (libro,cantidadTotalLibros,estadoOcupado, mensajeBusquedaId, mensajeErrorGetNumeroPositivo,
										mensajeErrorGetCadena, 1, intentos, 51));
				break;
			case 2:
				respuesta(modificarAutor(libro,pais, autor,cantidadTotalLibros, estadoOcupado, mensajeBusquedaId, mensajeErrorGetNumero,
										mensajeErrorCarga, 1, intentos, cantidadAutores, cantidadPaises));
				break;
			case 3:
				respuesta(modificarEditorial(libro,editorial,cantidadTotalLibros, estadoOcupado, mensajeBusquedaId, mensajeErrorGetNumero,
											mensajeErrorCarga, 1, intentos, cantidadEditoriales));
				break;
			case 4:
				respuesta (modificarPrecio (libro,cantidadTotalLibros, estadoOcupado,mensajeBusquedaId, mensajeErrorGetNumero,
											mensajeErrorGetNumeroPositivo,0,intentos));
				break;
			case 5:
				subMenuFecha(libro,cantidadTotalLibros, estadoOcupado,mensajeBusquedaId, mensajeErrorGetNumero,
							mensajeErrorGetNumeroPositivo,1,intentos);
				break;
			case 6:
				respuesta (modificarGenero (libro,genero,cantidadTotalLibros, estadoOcupado, mensajeBusquedaId, mensajeErrorGetNumero,
											mensajeErrorCarga, 1, intentos, cantidadGeneros));
								break;
			case 7:
				printf ("Usted a seleccionado salir, vuelta al menu principal.");
				break;
			}
	} while (opcionInterna != 7 );
}

void subMenuFecha (eLibro libro[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet, char* mensajeErrorUTNGetPositivo,
		int minimo, int intentos)
{
	int opcion;
	do
	{
		if (utn_getNumero(&opcion,"\n¿Que desea modificar?\n1-Dia\n2-Mes\n3-Anio\n4-Salir\nNumero ingresado: ",
								mensajeErrorUTNGet,1,4,intentos)== 1)
			{
				switch (opcion)
				{
				case 1:
					respuesta(modificarDia(libro,cantidadTotal, estado,mensaje, mensajeErrorUTNGet,minimo,intentos));
					break;
				case 2:
					respuesta(modificarMes(libro,cantidadTotal, estado,mensaje, mensajeErrorUTNGet,minimo,intentos));
					break;
				case 3:
					respuesta(modificarAnio(libro,cantidadTotal, estado,mensaje,mensajeErrorUTNGet,
							"El anio ingresado deber ser superior a 1700",minimo,intentos));
					break;
				case 4:
					printf ("Selecciono salir, vuelta al menu modificar.\n");
				}
			}
	} while (opcion!=4);

}


void mostrarGenero(eGenero temaEstructura[],int cantidadTotal,int indice, char* mensajeError)
{
	if(indice > -1)
	{
		printf("%d \t %s\n", temaEstructura[indice].codigoGenero, temaEstructura[indice].descripcionGenero);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarGeneros(eGenero temaEstructura[],int cantidadTotal, char* mensaje, char* mensajeError)
{
	   printf("%s", mensaje);
	   for(int i=0; i<cantidadTotal; i++)
	   {
		   mostrarGenero(temaEstructura, cantidadTotal, i, mensajeError);
	   }
}


int modificarGenero (eLibro libro[], eGenero genero[], int cantidadTotal, int estado, char* mensaje, char* mensajeErrorUTNGet,
					char* mensajeErrorCarga, int minimo, int intentos, int cantidadGeneros)
{
	int idAModificiar;
	int i;
	int numeroModificado;
	char confirmacion;
	int retorno=-1;//Si no encontro al empleado

	if (utn_getNumero(&idAModificiar, mensaje, mensajeErrorUTNGet, minimo, cantidadTotal,intentos )==1)
	{
		buscarDato(libro,cantidadTotal,idAModificiar, &i, estado);

		if(i > -1)
		{
			mostrarGeneros(genero, cantidadGeneros,"\nID\t Genero\n",mensajeErrorCarga);
		   if (utn_getNumero(&numeroModificado,"Ingrese el ID del genero nuevo: ",mensajeErrorUTNGet,minimo, cantidadGeneros, intentos)==1)
		   {
			   pedirConfirmacion ( &confirmacion,intentos);
				if(confirmacion == 'S')
			   {
					libro[i].idGenero=numeroModificado;
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

void mostrarDatoConGenero(eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],int indice,
						char* mensajeError)
{
	//printf("%s", mensaje);
	int j;
	int l;
	int k;
	int m;
	int auxPais=0;
	int auxEditorial=0;
	int auxAutor=0;
	int auxGenero=0;

	if(indice > -1)
	{

		for( j=0; j<5; j++ )
		{
			if( libro[indice].idEditorial == editorial[j].codigoEditorial )
			{
				auxEditorial = j;
			}

		}

		for( m=0; m<5; m++ )
		{
			if( libro[indice].idGenero == genero[m].codigoGenero )
			{
				auxGenero = m;
			}

		}

		for( l=0; l<10; l++ )
		{
			if( libro[indice].idAutor == autor[l].codigoAutor )
			{
				auxAutor = l;
				for( k=0; k<5; k++ )
				{
					if( autor[l].idNacionalidad == pais[k].codigoPais )
					{
						auxPais = k;
					}
				}
			}

		}
	printf("\n%d\t %s\t %s\t %s\t %s\t %.2f  %d-%d-%d\t %s", libro[indice].codigoLibro,autor[auxAutor].nombreAutor,pais[auxPais].descripcionPais,
			editorial[auxEditorial].descripcionEditorial,genero[auxGenero].descripcionGenero, libro[indice].precio,
			libro[indice].fechaPublicacion.dia, libro[indice].fechaPublicacion.mes,libro[indice].fechaPublicacion.anio,
			libro[indice].tituloLibro);
	}
	else
	{
		printf("%s", mensajeError);
	}
}

void mostrarLibrosConFiltro (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[], eGenero genero[],
		int cantidadTotal, int estadoOcupado, char* mensaje, char* mensajeErrorCarga)
{
	int i;
	 printf("%s", mensaje);
	for( i=0; i<cantidadTotal-1; i++)
	{
		if (libro[i].estado == estadoOcupado && libro[i].idGenero != 5)
		{
			mostrarDatoConGenero(libro, autor, pais, editorial, fecha, genero, i,mensajeErrorCarga);
		}
	}

}

void mostrarArgentinosConEditorialElegida (eLibro libro[], eAutor autor[], ePais pais[], eEditorial editorial[], eFecha fecha[],
		eGenero genero[], int cantidadTotal, int cantidadEditoriales, int estadoOcupado, char* mensaje, char* mensajeErrorCarga)
{
	int i;
	int k;
	int aux;
	//int m;
	mostrarEditoriales(editorial, cantidadEditoriales,"\nID\t Editorial\n","\n\nNo hay datos para mostrar.\n");
	utn_getNumero (&aux,"\nIngrese la editorial que quiere filtrar: ", "El numero no esta dentro del rango solicitado", 1, 5, 3);


	printf("%s", mensaje);
	for( i=0; i<cantidadTotal; i++)
	{
		if (libro[i].estado == estadoOcupado && libro[i].idEditorial == aux)
		{
			for ( k=0; k<5; k++)
			{
				if( libro[i].idAutor == autor[k].codigoAutor )
				{
							if (autor[k].idNacionalidad == 1)
							{
									mostrarDatoConGenero(libro, autor, pais, editorial, fecha, genero, i,mensajeErrorCarga);
									break;

							}
				}
			}
		}
	}

}
