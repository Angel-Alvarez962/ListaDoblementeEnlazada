using System;

public class Nodo
{
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }
    public Nodo Anterior { get; set; }

    // Constructor del nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}

public class ListaDoble
{
    private Nodo cabeza;
    private bool esCircular;

    // Constructor de la lista doblemente enlazada
    public ListaDoble(bool esCircular = false)
    {
        cabeza = null;
        this.esCircular = esCircular;
    }

    // Método para insertar un nuevo dato en la lista
    public void Insertar(int dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            // Si la lista está vacía, se establece el nuevo nodo como cabeza
            cabeza = nuevoNodo;
            if (esCircular)
            {
                // Si la lista es circular, se enlaza el nodo consigo mismo
                cabeza.Siguiente = cabeza;
                cabeza.Anterior = cabeza;
            }
        }
        else
        {
            Nodo actual = cabeza;
            // Se recorre la lista hasta encontrar el último nodo
            while (actual.Siguiente != null && actual.Siguiente != cabeza)
            {
                actual = actual.Siguiente;
            }
            // Se enlaza el nuevo nodo al final de la lista
            actual.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = actual;
            if (esCircular)
            {
                // Si la lista es circular, se enlaza el nuevo nodo a la cabeza
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
            }
        }
    }

    // Método para eliminar un dato de la lista
    public void Eliminar(int dato)
    {
        if (cabeza == null)
        {
            // Si la lista está vacía, no se hace nada
            return;
        }

        Nodo actual = cabeza;
        do
        {
            if (actual.Dato == dato)
            {
                // Se enlazan los nodos anterior y siguiente, saltándose el nodo actual
                if (actual.Anterior != null)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }
                if (actual.Siguiente != null)
                {
                    actual.Siguiente.Anterior = actual.Anterior;
                }
                if (actual == cabeza)
                {
                    // Si el nodo a eliminar es la cabeza, se actualiza la cabeza
                    cabeza = actual.Siguiente;
                }
                if (esCircular)
                {
                    // Ajustes adicionales si la lista es circular
                    if (actual == cabeza)
                    {
                        if (actual.Siguiente == cabeza)
                        {
                            cabeza = null;
                        }
                        else
                        {
                            cabeza.Anterior = actual.Anterior;
                            actual.Anterior.Siguiente = cabeza;
                        }
                    }
                    else
                    {
                        if (actual.Siguiente == cabeza)
                        {
                            actual.Anterior.Siguiente = cabeza;
                            cabeza.Anterior = actual.Anterior;
                        }
                    }
                }
                break;
            }
            actual = actual.Siguiente;
        } while (esCircular && actual != cabeza);
    }

    // Método para imprimir la lista
    public void Imprimir()
    {
        if (cabeza == null)
        {
            // Si la lista está vacía, se muestra un mensaje
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        do
        {
            // Se imprime el dato de cada nodo
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        } while (esCircular && actual != cabeza);

        Console.WriteLine();
    }
}


