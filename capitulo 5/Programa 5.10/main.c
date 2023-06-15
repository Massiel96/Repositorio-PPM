#include <stdio.h>

/* Búsqueda secuencial en arreglos ordenados en forma creciente. */

const int MAX = 100; /* Prototipos de funciones. */
void Lectura(int[], int);
int Busca(int *, int, int);

void main(void)
{
    int RES, ELE, TAM, VEC[MAX];
    do
    {
        printf("Ingrese el tamaño del arreglo: ");
        scanf("%d", &TAM);
    } while (TAM > MAX || TAM < 1);
    /* Se verifica que el tamaño del arreglo sea correcto. */
    Lectura(VEC, TAM);
    printf("\nIngrese el elemento a buscar: ");
    scanf("%d", &ELE);
    RES = Busca(VEC, TAM, ELE); /* Se llama a la función que busca en el arreglo. */
    if (RES)
    {
        /* Si RES tiene un valor verdadero —diferente de 0—, se escribe la posición en la que se encontró al elemento. */
        printf("\nEl elemento se encuentra en la posicion: %d", RES);
    }
    else
    {
        printf("\nEl elemento no se encuentra en el arreglo");
    }
}

void Lectura(int A[], int T)
/* La función Lectura se utiliza para leer un arreglo unidimensional de T elementos de tipo entero. */
{
    int I;
    for (I = 0; I < T; I++)
    {
        printf("Ingrese el elemento %d: ", I + 1);
        scanf("%d", &A[I]);
    }
}

int Busca(int A[], int T, int K)
/* Esta función realiza una búsqueda secuencial en un arreglo ordenado en forma creciente. Si el elemento es encontrado, regresa la posición correspondiente. En caso contrario, regresa 0. */
{
    int I = 0;
    while (I < T && A[I] < K)
    {
        I++;
    }
    if (I < T && A[I] == K)
    {
        return I + 1;
        /* Se asigna I+1 dado que las posiciones en el arreglo comienzan desde 1. */
    }
    else
    {
        return 0;
    }
}
