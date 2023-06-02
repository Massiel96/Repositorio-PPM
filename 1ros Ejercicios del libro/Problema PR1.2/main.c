#include <stdio.h>

/* aplicacion de operaciones. */

 void main(void)
{
    int i = 15, j, k, l;

    j = (15 > i--) > (14 < ++i);
    printf("\nE; valor de j es: %d" , j);

    i = 15;

    k = ! ('b' != 'd') > (!i - 1);
    printf("\nEl valor de k es: %d" , k);

    int x = (! (34 > (70 % 2))) || 0;
    printf("\nEl valor de 1 es: %d" , 1);


}
