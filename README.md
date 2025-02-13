ListaDoblementeEnlazada

La implementación consiste en una clase Nodo y una clase ListaDoble.
Clase Nodo:
Representa cada elemento de la lista.
Tiene tres propiedades: Dato, Siguiente y Anterior.
El constructor inicializa estas propiedades.

Clase ListaDoble:
Gestiona la lista doblemente enlazada.
Tiene una propiedad privada cabeza que apunta al primer nodo y una propiedad esCircular que indica si la lista es circular.
Método Insertar: Añade un nuevo nodo al final de la lista. Si la lista es circular, el nuevo nodo se enlaza con la cabeza.
Método Eliminar: Elimina un nodo que contiene el dato especificado. Si la lista es circular, se realizan ajustes adicionales para mantener la estructura.
Método Imprimir: Recorre la lista y muestra los datos de los nodos. Si la lista es circular, se detiene al volver al nodo cabeza.

Un ejemplo de su uso, creo una lista doblemente no circular y le coloco los elementos, 1, 2, 3, 4, despues elimino el elemnto 3 y solo me quedan los elementos 1, 2 y 4 que es lo que se manda a imprimir, sin embargo esta lista al no ser circular, lo que hace es, recorrer desde el elemento 1 y parar en el elemento 4, mientras que en la no circular, la creamos y agregamos los elementos 5, 6, 7 y 8, si queremos eliminar alguno, por ejemplo el 6, solo nos imprimiría los elementos 5, 7 y 8 y esta lista doblemente circular, su característica es que el elemento 1 (en este caso el 5) y el ultimo elemento (en este caso el 8) estan enlazados, lo que hace que la lista cree un bucle en el que la lista se recorra infinitamente
