#include "validacionTemperaturas.h"

float validacionCelcius (float temperaturaIngresada)
{
while (temperaturaIngresada > 100 || temperaturaIngresada<0)
	{
		printf ("La temperatura ingresada supera los 100°C o es menor a 0°C, reingrese temperatura: ");
		scanf ("%f", &temperaturaIngresada);
	}
return temperaturaIngresada;
}

float validacionFarenheit (float temperaturaIngresada)
{
while (temperaturaIngresada > 212 || temperaturaIngresada<32)
	{
		printf ("La temperatura ingresada supera los 212°F o es menor a 32°F, reingrese temperatura: ");
		scanf ("%f", &temperaturaIngresada);
	}
return temperaturaIngresada;
}
