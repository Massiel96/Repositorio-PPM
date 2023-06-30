#include <stdio.h>
#include <string.h>
#include <ctype.h>

/* Min�sculas y may�sculas.
El programa, al recibir como dato un arreglo unidimensional de tipo
cadena de caracteres, determina el n�mero de min�sculas y may�sculas
que hay en cada cadena. */

void minymay(char *cad);    /* Prototipo de funci�n */

void main(void)
{
    int i, n;
    char FRA[20][50];
    /* Observa c�mo se declara el arreglo unidimensional de cadena de
caracteres. */

    printf("\nIngrese el n�mero de filas del arreglo: ");
    scanf("%d", &n);

    for (i = 0; i < n; i++)
    {
        /* Para cada fila se lee la cadena correspondiente. */
        printf("Ingrese la l�nea %d de texto: ", i + 1);
        fflush(stdin);
        fgets(FRA[i], sizeof(FRA[i]), stdin);
        FRA[i][strcspn(FRA[i], "\n")] = '\0';  // Eliminar el car�cter de nueva l�nea del final
    }

    printf("\n\n");

    for (i = 0; i < n; i++)
    {
        minymay(FRA[i]);
    }

    return 0;
}

void minymay(char *cadena)
/* estas funcion se utiliza para calcular el numero de minusculas
y mayusculas que hay en cada cadena. */
{
    int i = 0, mi = 0, ma = 0;

    while (cadena[i] != '\0')
    {
        if (islower(cadena[i]))
            mi++;
        else if (isupper(cadena[i]))
            ma++;

        i++;
    }

    printf("N�mero de letras min�sculas: %d\n", mi);
    printf("N�mero de letras may�sculas: %d\n", ma);
}


