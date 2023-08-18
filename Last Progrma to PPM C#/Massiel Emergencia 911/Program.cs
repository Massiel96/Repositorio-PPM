using System;

namespace AtencionDeEmergencia
{ 
    class program
    {
        // Mensage de bienvenida a la Emergencia Massiel 911.
      static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Emergencia Massiel 911.");
            Console.WriteLine("Favor de responder las preguntas con 'si' o 'no' para un un servicio satifactorio.");
           
            // Declaro la variable para almacenar las respuestas.
            string respuesta1, respuesta2, respuesta3, respuesta4, respuesta5;

            // "do, why" para obtener las respuesta hasta que sean validas. lo repito todo hasta respuesta5.
            do
            {
                Console.Write("Has esperimentado dificultades de respiracion en otras ocaciones? ");
                respuesta1 = Console.ReadLine().ToLower();
                if (respuesta1 != "si" && respuesta1 != "no")
                {
                    Console.WriteLine("Lo siento su respuesta no es valida, favor de responder 'si' o 'no'. ");
                }

            } while (respuesta1 != "si" && respuesta1 != "no");

            do
            {

                Console.Write("Has experimentado otro sintomas asmatico, como presion en el pecho?");
                respuesta2 = Console.ReadLine().ToLower();
                if (respuesta2 != "si" && respuesta2 != "no")
                {
                    Console.WriteLine("Lo siento su respuesta no es valida, favor de responder 'si' o 'no'.");
                }

            } while (respuesta2 != "si" && respuesta2 != "no");

            do
            {
                Console.Write("Has utilizado tu inhalador recientemente?");
                respuesta3 = Console.ReadLine().ToLower();
                if (respuesta3 != "si" && respuesta3 != "no")
                {
                    Console.WriteLine("Lo siento su respuesta no es valida, favor de responder 'si' o 'no'.");
                } 

            } while (respuesta3 != "si" && respuesta3 != "no");

            do
            {
                Console.Write("Has presentado problemas para realizar las actividades cotidianas debido a las crisis asmaticas ?");
                respuesta4 = Console.ReadLine().ToLower();
                if (respuesta4 != "si" && respuesta4 != "no")
                {
                    //Mensaje de que su respuesta no es valida si no contesta "si" o "no". repetimo la misma ? hasta que conteste "si" o "no"
                    Console.WriteLine("Lo siento su respuesta no es valida, favor de responder 'si' o 'no'.");
                }

            } while (respuesta4 != "si" && respuesta4 != "no");

            do
            {
                Console.Write("Tienes historial de hospitalizacion o ingreso a cuidados intensivo a causa de su condicion asmatica ?");
                respuesta5 = Console.ReadLine().ToLower();
                if (respuesta5 != "si" && respuesta5 != "no")
                {
                    Console.WriteLine("Lo siento su respuesta no es valida, favor de responder 'si' o 'no'.");
                }

            } while (respuesta5 != "si" && respuesta5 != "no");

            //Declaracion de la variable para las respuesta positivas.

            int respuestasSi = 0;

            // comparo respuesta "si" afirmativas aumentan el contador

            if (respuesta1 == "si") 
            {
                respuestasSi++; 
            }
            if (respuesta2 == "si") 
            {
                respuestasSi++;
            }
            if (respuesta3 == "si") 
            {
                respuestasSi++;
            }
            if (respuesta4 == "si") 
            {
                respuestasSi++;
            }
            if (respuesta5 == "si") 
            {
                respuestasSi++;

                // Aqui nos guiamos del numero de contesta afimativas y luego doy mi recomendacion.
            }
            if (respuestasSi >= 3)

            {
                //Recomendacion para "si" >=3. 
                Console.WriteLine("Recomendacion: Bien, usted se tomara 2 tableta de Metaproterenol de 200 mg todas las noche antes de dormir. ");
                Console.WriteLine("Tomara su ducha con agua tibia y si los sintomas persisten vendra a emergencia para ser ingrasad@ en caso de ser necesario. ");
                Console.WriteLine("Favor no olvide llevar siempre consigo su inhalador.");
            }

            else 
        
            {
                //Recomendacion para "si" <3.
                Console.WriteLine("Recomendacion: Favor trate de caminar despacio, no corra o suba escaleras de pronto,");
                Console.WriteLine(" mantengase en posiciones de comodidad siempre");
                Console.WriteLine("no consuma dulces ni tome cocacola y recuerde que su salud depende de usted y nadie mas.");
            }
            //Mensaje de despedida y opcion de salida.
            Console.WriteLine("Gracias por su visita fue un placer atenderle, Recuerde que la mejor forma de predicir el futuro es creandolo ");
            Console.WriteLine("Favor presione cualquier tecla para salir del programa.");
            Console.ReadKey();

        }   

}
}
