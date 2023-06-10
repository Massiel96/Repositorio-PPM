#include <stdio.h>

/* prueba de parametros por valor.*/

int f1 (int);           /*prototipo de funcion. El parametro es por valor
                         y d tipo entero.8*/


void main(void)
{
    int I, K = 4;
    for (I = 1; I<= 3; I++)
    {
      printf("\n\nValor de K antes de llamar la funcion: %d", ++K);
        printf("\nValor de K despues de llamar a la funcion: %d" , f1(K));
        /* Llamada a la función f1. Se pasa una copia de la variable K. */
    }
}
int f1(int R)
{
    R += R;
    return (R);
}
