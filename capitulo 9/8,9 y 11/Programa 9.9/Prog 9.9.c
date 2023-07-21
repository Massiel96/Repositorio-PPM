#include <stdio.h>

/* Alumnos.
El programa lee bloques -variables de tipo estructura alumno- de un archivo
de acceso directo. */

typedef struct{      /* Declaracion de la estructura alumno. */
int matricula;
char nombre[20];
int carerra;
float promedio;
} alumno;

void lee(FILE *);  /* Prototipo de funcion. */

void main(void)
{
    FILE *ar;
    if ((ar = fopen ("ad1.dat", "r")) != NULL)
        lee(ar);
    else
        printf("\n El archivo no se puede abrir");
    fclose(ar);
}

void lee(FILE *ap)
/* Esta funcion se utiliza para leer bloques de un archivo de acceso directo. */
{
    alumno alu;

    fread(&alu, sizeof(alumno), 1, ap);
    /* Observa que la funcion fread tiene los mismos argumentos que la funcion
    fwrite del programa anterior. Tambien es importante tomar nota de que cuando
    tenemos que leer los registros de un archivo utilizando una estructura
    repetitiva como el while, debemos realizar una primera lectura antes de
    ingresar al ciclo y luego las siguientes dentro del ciclo, pero como última
    instrucción del mismo. Esto se debe a que la lógica que siguen las
    instrucciones fwrite y fread es moverse y leer o escribir, según sea el caso.
    Si no lo hiciéramos de esta forma, terminaríamos escribiendo la información
    del último registro dos veces. Vamos a realizar un ejemplo sencillo para
    comprobar esto. */

    while (!feof(ap))
    {
      printf("\nMatricula: %d", alu.matricula);
      printf("\tCarrera: %d", alu.carerra);
      printf("\TPromedio: %f\t ", alu.promedio);
      puts(alu.nombre);
      fread(&alu, sizeof(alumno), 1, ap);
    }
}
