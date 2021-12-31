using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3PED
{
    internal class Lista
    {
        public Nodo inicio; //cabeza de la lita

        //contructor por defecto 
        public Lista()
        {
            inicio = null;
        }

        //método para insertar al final de la lista , como lo hace ArrayList
        public void InsertarF(int item)
        {
            Nodo auxiliar = new Nodo(); //nodo temporal que todavía no permanece a la lista
            auxiliar.dato = item; //almacenar en el atributo dato el valor recibido en el parámetro
            auxiliar.siguiente = null; //hace que el apuntador señale a null

            if(inicio == null) //verifica si la lista está vacia
            {
                inicio = auxiliar; //hacemos que nodo sea parte de la lista, lohacemos la cabeza
            }
            else
            {
                Nodo puntero; //utilizamos este nodo para recorrer la lista, así no se mueve la cabeza
                puntero = inicio; //situamos a puntero señalando al mismo nodo que inicio
                while(puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //se desplaza por todos los nodos de la lista
                }
                puntero.siguiente = auxiliar; //hacemos que último nodo ahora señale al auxiliar
            }
        }

        public void InsertarI(int item)
        {
            Nodo auxiliar = new Nodo(); //nodo temporal que después se agrega a la lista
            auxiliar.dato = item; //almacena valor en el atributo fato
            auxiliar.siguiente = null; //hacemos que puntero siguiente señale a null

            if(inicio == null)
            {
                inicio= auxiliar; //al estar vacia la cola lo hacemos la cabeza
            }
            else
            {
                Nodo puntero; //para recorrer  lista
                puntero = inicio; //dos apuntadores señalando al mismo nodo
                inicio = auxiliar; //asignamos como cabeza al nodo auxiliar
                auxiliar.siguiente = puntero; //el puntero de auxiliar que ahora es cabeza se enlaza con
                //el nodo que era antes la cabeza que tiene apuntador puntetero
            }
        }
        public void EliminarI()
        {
            if (inicio == null) //cuando lista esté vacia {
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                inicio = inicio.siguiente; //a quien estaba señalando inicio será nuevo inicio
            }
        }
        //método para eliminar nodo al final de la lista
        public void EliminarF()
        {
            if(inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                Nodo punteroantm, punteropost; //requiere dos punteros para mover porque no declaré la cola
                punteroantm = inicio; //inicalizo ambos en la cabeza de la lista
                punteropost = inicio;

                while (punteropost.siguiente !=null) //mientras que puntero posterior no señale null
                {
                    punteroantm = punteropost; //el puntero anterior será a quien señale el posterior
                    punteropost = punteropost.siguiente; //puntero posterior será a quien señalaba antes el posterior
                }
                punteroantm.siguiente = null; //con esto sacamos el que estaba al final de la lista, el útimo nodo 
                //era el que estaba señalando el punteropost pero ahora el último será en donde se quedó punteroant
            }
        }

        //método para insertar en una posición especifica de la lista
        public void InsertarP(int item, int pos)
        {
            Nodo auxiliar = new Nodo(); //definición de nuevo nodo con sus atributos
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if(inicio == null)
            {
                Console.WriteLine("La lista está vacia, por lo tanto se va a insertar en la 1a. posición");
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio; //para recorrer la lista
                if(pos == 1) //si la posición que pidieron es la 1, se inserta en la cabeza
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else //si la posición solicitada no es la 1
                {
                    for(int i = 1; i < pos-1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null) //si llegamos al final de la lista
                        {
                            break;
                        }

                        Nodo punteronext; //apuntador de ayuda
                        punteronext = puntero.siguiente; //a quien señalaba el puntero ahí se ubicará el apuntador punteronext
                        puntero.siguiente = auxiliar; // ahora el apuntador puntero señalará al nodo auxiliar (el nuevo)
                        auxiliar.siguiente = punteronext;//el nodo recien ingresado señalará a punteronext
                        //con estas cutro líneas es cómo se corta momentaneamente la lista y luego se une de nuevoo
                    }
                }
            }
        }
        public void mostar()
        {
            if (inicio == null) //si  lista esta vacía
            {
                Console.WriteLine("La  lista está vacia");
            }
            else
            {
                Nodo puntero;
                puntero = inicio; //inicializamos a puntero en el mismo nodo que la cabeza
                Console.Write("{0} -> \t", puntero.dato); //imprimir valor de nodo. Ehirte y no WriteLine
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //avanzamos un nodo en la lista
                    Console.Write("{0} -> \t", puntero.dato); //usar Write para que no salte de línea
                }
            }
            Console.WriteLine();
        }

         static void Main(string[] args)
        {
            //creamos una instancia de la clase Lista para que podamos utilizar los métodos
            Lista lista = new Lista();

            //le agremos cutro nodos a la lista
            //lista.InsertarI(40);
            //lista.InsertarI(30);
            //lista.InsertarI(20);
            //lista.InsertarI(10);

            //mostamos el contenido dentro de la lista
            //lista.mostar();

            //insertando en posición
            //lista.InsertarP(220,3);
            //lista.mostar();
            //Console.ReadKey();

            //menú
            Console.Write(
                "a.) Insertar al Frente" + "n" + 
                "b.) Insertar al Final" + "n" + 
                "c.) Insertar en una posición específica" + "n" +
                "d.) Eliminar al Frente" + "n"+
                "e.) Eliminar al Final" + "n"+
                "f.) Mostrar lista" + "n"+
                "g.) Salir" + "n"); 

            Console.Write("Seleccione una opción: ");

            switch (Console.Read())
            {
                case '1':
                    Console.Write("Suma..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '2':
                    Console.Write("Resta..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '3':
                    Console.Write("Multiplicación..");
                    // Continuar lógica y extraer métodos //
                    break;
                case '4':
                    Console.Write("División..");
                    // Continuar lógica y extraer métodos //
                    break;
            }
            Console.ReadKey();

        }

    }//finn de la clase lista

}
