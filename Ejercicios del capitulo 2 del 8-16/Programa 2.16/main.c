#include <stdio.h>
/*Empresa textil.
el programa, al recibir como datos las categoria y antiguedad de
un empleado, determina si el mismo reune las conidciones establecidas por
la empresa para ocupar un nuevo cargo en una sucursal.

CLA, CAT, ANT, RES:  vairiables de tipo entero.
SAL: variables de tipo Real . */

void main(void)
{
    int CLA, CAT, ANT, RES;
    printf("\nIngrese la clave, categoria y antiguedad del trabador:");
    scanf("%d %d", &CLA, &CAT, &ANT);
    switch(CAT)
    {
    case 3:
   case 4: if (ANT >= 5)
                RES = 1;
            else
               RES = 0;
           break;
        case 2: if (ANT >= 7)
                        RES = 1;
         else
                            RES = 0;
         break;
    default: RES = 0;
            break;
    }
    if (RES)
   printf("\nEl trabajador con clave %d reune las condiciones para el puesto", CLA);
   else

  printf("\nEl trabajador con clave %d no reune las condiciones para el puesto", CLA);
}
