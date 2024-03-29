#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
    char calle[20];
    int numero;
    int cp;
    char localidad[20];
} domicilio;

struct empleado {
    char nombre[20];
    char departamento[20];
    float sueldo;
    domicilio direccion;
};

void Lectura(struct empleado *a) {
    printf("\nIngrese el nombre del empleado: ");
    fgets(a->nombre, sizeof(a->nombre), stdin);
    printf("Ingrese el departamento de la empresa: ");
    fgets(a->departamento, sizeof(a->departamento), stdin);
    printf("Ingrese el sueldo del empleado: ");
    scanf("%f", &a->sueldo);
    getchar(); // Consume the newline character left by scanf

    printf("---Ingrese la direccion del empleado---\n");
    printf("\tCalle: ");
    fgets(a->direccion.calle, sizeof(a->direccion.calle), stdin);
    printf("\tNumero: ");
    scanf("%d", &a->direccion.numero);
    printf("\tCodigo Postal: ");
    scanf("%d", &a->direccion.cp);
    getchar(); // Consume the newline character left by scanf
    printf("\tLocalidad: ");
    fgets(a->direccion.localidad, sizeof(a->direccion.localidad), stdin);
}

int main(void) {
    struct empleado e0 = {"Arturo", "Compras", 15500.75, {"San Jeronimo", 120, 3490, "Toluca"}};
    struct empleado *e1, *e2, e3, e4;

    // Allocate memory for e1 and e2
    e1 = (struct empleado*)malloc(sizeof(struct empleado));
    e2 = (struct empleado*)malloc(sizeof(struct empleado));

    printf("\nIngrese el nombre del empleado 1: ");
    fgets(e1->nombre, sizeof(e1->nombre), stdin);
    printf("Ingrese el departamento de la empresa: ");
    fgets(e1->departamento, sizeof(e1->departamento), stdin);
    printf("Ingrese el sueldo del empleado: ");
    scanf("%f", &e1->sueldo);
    getchar(); // Consume the newline character left by scanf

    Lectura(e2);

    printf("\nIngrese el nombre del empleado 3: ");
    fgets(e3.nombre, sizeof(e3.nombre), stdin);
    printf("Ingrese el departamento de la empresa: ");
    fgets(e3.departamento, sizeof(e3.departamento), stdin);
    printf("Ingrese el sueldo del empleado: ");
    scanf("%f", &e3.sueldo);
    getchar(); // Consume the newline character left by scanf

    Lectura(&e4);

    printf("\nDatos del empleado 1\n");
    printf("%s\t%s\t%.2f\t%s\t%d\t%d\t%s", e1->nombre, e1->departamento, e1->sueldo, e1->direccion.calle, e1->direccion.numero, e1->direccion.cp, e1->direccion.localidad);

    printf("\nDatos del empleado 4\n");
    printf("%s\t%s\t%.2f\t%s\t%d\t%d\t%s", e4.nombre, e4.departamento, e4.sueldo, e4.direccion.calle, e4.direccion.numero, e4.direccion.cp, e4.direccion.localidad);

    // Free dynamically allocated memory
    free(e1);
    free(e2);

    return 0;
}
