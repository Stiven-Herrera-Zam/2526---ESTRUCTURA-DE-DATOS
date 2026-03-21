using System;

class Nodo
{
    public int Valor;
    public Nodo Izq;
    public Nodo Der;

    public Nodo(int valor)
    {
        Valor = valor;
        Izq = null;
        Der = null;
    }
}

class ArbolBST
{
    public Nodo Raiz;

    public ArbolBST()
    {
        Raiz = null;
    }

    // Insertar
    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izq = InsertarRec(nodo.Izq, valor);
        else
            nodo.Der = InsertarRec(nodo.Der, valor);

        return nodo;
    }

    // Buscar
    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (nodo.Valor == valor) return true;

        if (valor < nodo.Valor)
            return BuscarRec(nodo.Izq, valor);
        else
            return BuscarRec(nodo.Der, valor);
    }

    // Eliminar
    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return nodo;

        if (valor < nodo.Valor)
            nodo.Izq = EliminarRec(nodo.Izq, valor);
        else if (valor > nodo.Valor)
            nodo.Der = EliminarRec(nodo.Der, valor);
        else
        {
            if (nodo.Izq == null) return nodo.Der;
            if (nodo.Der == null) return nodo.Izq;

            nodo.Valor = Minimo(nodo.Der);
            nodo.Der = EliminarRec(nodo.Der, nodo.Valor);
        }

        return nodo;
    }

    // Mínimo
    public int Minimo(Nodo nodo)
    {
        while (nodo.Izq != null)
            nodo = nodo.Izq;
        return nodo.Valor;
    }

    // Máximo
    public int Maximo(Nodo nodo)
    {
        while (nodo.Der != null)
            nodo = nodo.Der;
        return nodo.Valor;
    }

    // Recorridos
    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izq);
            Preorden(nodo.Der);
        }
    }

    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izq);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Der);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izq);
            Postorden(nodo.Der);
            Console.Write(nodo.Valor + " ");
        }
    }

    // Altura
    public int Altura(Nodo nodo)
    {
        if (nodo == null) return -1;

        int izq = Altura(nodo.Izq);
        int der = Altura(nodo.Der);

        return 1 + Math.Max(izq, der);
    }

    // Limpiar
    public void Limpiar()
    {
        Raiz = null;
        Console.WriteLine("Árbol limpiado.");
    }
}

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n=== MENU ARBOL BST ===");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Mostrar Preorden");
            Console.WriteLine("5. Mostrar Inorden");
            Console.WriteLine("6. Mostrar Postorden");
            Console.WriteLine("7. Mostrar minimo y maximo");
            Console.WriteLine("8. Mostrar altura");
            Console.WriteLine("9. Limpiar arbol");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor a insertar: ");
                    arbol.Insertar(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    Console.WriteLine(arbol.Buscar(int.Parse(Console.ReadLine())) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    arbol.Eliminar(int.Parse(Console.ReadLine()));
                    break;

                case 4:
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    if (arbol.Raiz != null)
                    {
                        Console.WriteLine("Minimo: " + arbol.Minimo(arbol.Raiz));
                        Console.WriteLine("Maximo: " + arbol.Maximo(arbol.Raiz));
                    }
                    else Console.WriteLine("El arbol esta vacio.");
                    break;

                case 8:
                    Console.WriteLine("Altura del arbol: " + arbol.Altura(arbol.Raiz));
                    break;

                case 9:
                    arbol.Limpiar();
                    break;
            }
        }
    }
}