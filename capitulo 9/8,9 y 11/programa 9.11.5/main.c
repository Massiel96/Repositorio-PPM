#include <stdio.h>


typedef struct     /* Declaración de la estructura empleado. */
{
    int clave;
    int departamento;
    float salario;
    float empleado[12];

}empleado;

void promedio(FILE *);
int main(void)
{
    printf("clave de empleado: %d\n", emp.numeroEmpleado);
    printf("Nombre: %s\n", emp.nombre);
    printf("Salario: %.2f\n", emp.salario);

    return 0;
}
}

int main(void) {
    FILE *ar;
    if ((ar = fopen("arc9.txt", "r")) != NULL) {
        promedio(ar);
        fclose(ar);
    }

else {
        printf("No se puede abrir el archivo\n");
    }
    return 0;
}


