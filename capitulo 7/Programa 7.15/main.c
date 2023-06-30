#include <stdio.h>
#include <ctype.h>

/* Decodifica.
El programa decodifica una cadena de caracteres compuesta por números y
letras. */

void interpreta(char *cadena);   /* Prototipo de función */

void main(void)
{
    char cad[50];
    printf("\nIngrese la cadena de caracteres: ");
    fgets(cad, sizeof(cad), stdin);
    interpreta(cad);
    return 0;
}

void interpreta(char *cadena)
/* Esta función se utiliza para decodificar la cadena de caracteres. */

{
    int i = 0, j, k;
    while (cadena[i] != '\0')
    {
        if (isalpha(cadena[i]))  /* Se utiliza cadena en lugar de cad */
        {
            k = cadena[i - 1] - '0';  /* Se corrige la variable k */
            for (j = 0; j < k; j++)
                putchar(cadena[i]);
        }
        i++;
    }
}



