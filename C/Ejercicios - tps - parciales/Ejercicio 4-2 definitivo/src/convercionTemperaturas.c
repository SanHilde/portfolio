#include "convercionTemperaturas.h"

float pasajeFarenheitCelcius(float temperaturaIngresada)
{
float resultado;
resultado= (temperaturaIngresada -32)*5/9;
return resultado;
}

float pasajeCelciusFarenheit(float temperaturaIngresada)
{
float resultado;
resultado= (temperaturaIngresada * 9 / 5)+32;
return resultado;
}
