#include <stdio.h>


/* Cubo-2.
El programa calcula el cubo de los 10 primeros n�meros naturales con la
ayuda de una funci�n. */

int cubo(void);  /* Declaraci�n de la funci�n cubo() */

int I;  /* Variable global */

int main(void) {
    int CUB;
    for (I = 1; I <= 10; I++) {
        CUB = cubo();  /* Llamada a la funci�n cubo() */
        printf("\nEl cubo de %d es: %d", I, CUB);
    }
    return 0;
}

int cubo(void) {
    int I = 2;  /* Variable local entera I con el mismo nombre que la variable global */
    return (I * I * I);
}

