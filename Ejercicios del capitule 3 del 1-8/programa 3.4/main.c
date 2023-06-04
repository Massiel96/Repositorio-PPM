#include <stdio.h>
#include <math.h>

int main(void)
{
    int NUM;
    long CUA, SUC = 0;

    printf("Ingrese un numero entero (-0 para terminar): ");
    scanf("%d", &NUM);

    while (NUM != 0)
    {
        CUA = pow(NUM, 2);
        printf("%d al cuadrado es %ld\n", NUM, CUA);
        SUC += CUA;

        printf("Ingrese un numero entero (-0 para terminar): ");
        scanf("%d", &NUM);
    }

    printf("\nLa suma de los cuadrados es %ld\n", SUC);

    return 0;
}

