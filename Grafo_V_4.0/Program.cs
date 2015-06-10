using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Grafos
{
    class Program
    {
        static int[,] Matriz_2D = new int[100, 100];
        //static int Dimension; 
        static int contador = 0;
        public static void Menu()
        {
            Console.Clear();//Para limpiar el menu despues de seleccionar algo 
            Console.WriteLine("============= Metodos ==============");
            Console.WriteLine("1. DFS");// El metodo de DFS
            Console.WriteLine("2. BSF");//El metodo de BSF
            Console.WriteLine("3. Encontar Camino A-Z");// Metodo de encontral camino
            Console.WriteLine("4. Ciclo");// Metodo de encontral camino
            Console.WriteLine("5. Camino mas Corto");///camino mas corto 
            Console.WriteLine("0. Salir");///salir 
            Console.Write(">> ");
        }


        static void Main(string[] args)  ///main del proyecto 
        {
            string Opcion; ///opcion para los cases
            string rkohell = "";
            if(contador==0)
                {
                    int f = 1;
                    string load = "=";
                    Console.BackgroundColor = ConsoleColor.Blue;
                    for (int g = 5; g < 28; g++) { Console.SetCursorPosition(f + g, 21); Console.Write(load); }
                    for (int g = 10; g < 29; g++) { Console.SetCursorPosition(f + g, 20); Console.Write(load); }
                    for (int g = 12; g < 30; g++) { Console.SetCursorPosition(f + g, 19); Console.Write(load); }
                    for (int g = 14; g < 30; g++) { Console.SetCursorPosition(f + g, 18); Console.Write(load); }
                    for (int g = 16; g < 30; g++) { Console.SetCursorPosition(f + g, 17); Console.Write(load); }
                    for (int g = 18; g < 30; g++) { Console.SetCursorPosition(f + g, 16); Console.Write(load); }
                    for (int g = 22; g < 30; g++) { Console.SetCursorPosition(f + g, 15); Console.Write(load); }
                    for (int g = 22; g < 30; g++) { Console.SetCursorPosition(f + g, 14); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g, 13); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g, 12); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g, 11); Console.Write(load); }
                    for (int g = 27; g < 30; g++) { Console.SetCursorPosition(f + g, 10); Console.Write(load); }
                    for (int g = 27; g < 30; g++) { Console.SetCursorPosition(f + g, 9); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g, 8); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g, 7); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g, 6); Console.Write(load); }
                    for (int g = 29; g < 30; g++) { Console.SetCursorPosition(f + g, 5); Console.Write(load); }
                    for (int g = 29; g < 30; g++) { Console.SetCursorPosition(f + g, 4); Console.Write(load); }

                    //bola
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g, 13); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g, 12); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g, 14); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 10); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g, 11); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 15); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 16); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 8); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 9); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 16); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g, 17); Console.Write(load); }
                    for (int g = 37; g < 39; g++) { Console.SetCursorPosition(f + g, 7); Console.Write(load); }
                    for (int g = 37; g < 39; g++) { Console.SetCursorPosition(f + g, 18); Console.Write(load); }

                    //Bola Inversa    
                    Console.BackgroundColor = ConsoleColor.Blue;
                    for (int g = 37; g < 39; g++) { Console.SetCursorPosition(f + g + 4, 18); Console.Write(load); }
                    for (int g = 37; g < 39; g++) { Console.SetCursorPosition(f + g + 4, 7); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 17); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 16); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 8); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 9); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 15); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 16); Console.Write(load); }
                    for (int g = 35; g < 39; g++) { Console.SetCursorPosition(f + g + 6, 10); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g + 8, 11); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g + 8, 13); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g + 8, 12); Console.Write(load); }
                    for (int g = 33; g < 39; g++) { Console.SetCursorPosition(f + g + 8, 14); Console.Write(load); }

                    //Roja inversa    
                    Console.BackgroundColor = ConsoleColor.Red;
                    for (int g = 5; g < 28; g++) { Console.SetCursorPosition(f + g + 47, 21); Console.Write(load); }
                    for (int g = 10; g < 29; g++) { Console.SetCursorPosition(f + g + 41, 20); Console.Write(load); }
                    for (int g = 12; g < 30; g++) { Console.SetCursorPosition(f + g + 38, 19); Console.Write(load); }
                    for (int g = 14; g < 30; g++) { Console.SetCursorPosition(f + g + 36, 18); Console.Write(load); }
                    for (int g = 16; g < 30; g++) { Console.SetCursorPosition(f + g + 34, 17); Console.Write(load); }
                    for (int g = 18; g < 30; g++) { Console.SetCursorPosition(f + g + 32, 16); Console.Write(load); }
                    for (int g = 22; g < 30; g++) { Console.SetCursorPosition(f + g + 28, 15); Console.Write(load); }
                    for (int g = 22; g < 30; g++) { Console.SetCursorPosition(f + g + 28, 14); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g + 25, 13); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g + 25, 12); Console.Write(load); }
                    for (int g = 25; g < 30; g++) { Console.SetCursorPosition(f + g + 25, 11); Console.Write(load); }
                    for (int g = 27; g < 30; g++) { Console.SetCursorPosition(f + g + 23, 10); Console.Write(load); }
                    for (int g = 27; g < 30; g++) { Console.SetCursorPosition(f + g + 23, 9); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g + 22, 8); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g + 22, 7); Console.Write(load); }
                    for (int g = 28; g < 30; g++) { Console.SetCursorPosition(f + g + 22, 6); Console.Write(load); }
                    for (int g = 29; g < 30; g++) { Console.SetCursorPosition(f + g + 21, 5); Console.Write(load); }
                    for (int g = 29; g < 30; g++) { Console.SetCursorPosition(f + g + 21, 4); Console.Write(load); }

                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Introduce el nombre del archivo C:Unidad Disco Local ??"); ///Se pide el nodo que quieres iniciar 
                    rkohell =(Console.ReadLine()); ///se lee el nodo de incio que se pidio anteriormente 
                    string curFile = @"C:\"+rkohell;
                    Console.WriteLine(File.Exists(curFile) ? "El Archivo Si existe." : "El Archivo No existe");

                    Console.ReadKey();
                }
            
            Grafo Direcionador = LEERTXT(rkohell);
            do ///hacer los cases mientras que la opcion sea menor que 5
            {
                Menu(); //se llama al menu 
                Opcion = Console.ReadLine(); ///opcion para los case
                switch (Opcion)             ///se lee la opcion que se escribe 
                                            ///
                {
                    case "1": //DFS
                        {
                            Console.Clear();///Se limpia todo para poder inicializar el Meodo DFS
                            Console.WriteLine("Hola Metodo DFS - Profundidad");/// Se escribe "Hola Metodo DFS - Profundidad"
                            Console.WriteLine("Introduce el nodo donde quieres iniciar ??"); ///Se pide el nodo que quieres iniciar 
                            int rko = int.Parse(Console.ReadLine()); ///se lee el nodo de incio que se pidio anteriormente 
                            Console.Write(Direcionador.DFS(Direcionador.getNodo(rko - 1))); //Se manda a llamr al Metodo DFS y se imprime 
                            Console.ReadKey();//Se deniene hasta que ingrese otra tecla del teclado 
                            break; ///Brake para el case "1"
                        }
                    case "2"://BFS
                        {
                            Console.Clear();///Se limpia todo para poder inicializar el Meodo DFS
                            Console.WriteLine("Hola Metodo BFS - Profundidad");/// Se escribe "Hola Metodo BFS - Profundidad"
                            Console.WriteLine("Introduce el nodo donde quieres iniciar ??");//Se pide el nodo que quieres iniciar 
                            int rko = int.Parse(Console.ReadLine());//se lee el nodo de incio que se pidio anteriormente 
                            Console.WriteLine(Direcionador.BFS(Direcionador.getNodo(rko - 1)));//Se manda a llamr al Metodo DFS y se imprime 
                            Console.ReadKey();//Se deniene hasta que ingrese otra tecla del teclado 
                            break; ///Brake para el case "2"
                        }
                    case "3"://CAMINO A-B
                        {
                            Console.Clear();///Se limpia todo para poder inicializar el Meodo Camino de A-B
                            Console.WriteLine("Hola Metodo Encontar Camino A-Z"); //Se escribe "Hola Metodo Encontar Camino A-Z"
                            Console.WriteLine("Introduce el nodo donde quieres iniciar ??");//Se pide el nodo que quieres iniciar 
                            int rko = int.Parse(Console.ReadLine());//se lee el nodo de incio que se pidio anteriormente 
                            Console.WriteLine("Introduce el nodo Destino??");///se pide el nodo destino 
                            int hellgate = int.Parse(Console.ReadLine());///se lee el nodo de destino 
                            Console.WriteLine(Direcionador.BUSCARRUTA(Direcionador.getNodo(rko - 1), Direcionador.getNodo(hellgate - 1)));///se manda llamar al metodo de de ruta A-Z
                            Console.ReadKey();//Se deniene hasta que ingrese otra tecla del teclado 
                            break; ///Brake para el case "3"
                        }
                    case "4"://Encontrar optimo
                        {
                            Console.Clear();///Se limpia todo para poder inicializar el Meodo Camino mas Corto
                            Console.WriteLine("Hola Este metodo esta en ciclo");//Se escribe "Hola Metodo Camino mas Corto"
                            Console.WriteLine("Introduce el nodo donde quieres iniciar ??");//Se pide el nodo que quieres iniciar 
                            int rko = int.Parse(Console.ReadLine());//se lee el nodo de incio que se pidio anteriormente 
                            Console.WriteLine(Direcionador.ciclo(Direcionador.getNodo(rko)));
                            Console.ReadKey();//Se deniene hasta que ingrese otra tecla del teclado 
                            break; ///Brake para el case "4"
                        }
                    case "5"://Encontrar optimo
                        {
                            Console.Clear();///Se limpia todo para poder inicializar el Meodo Camino mas Corto
                            Console.WriteLine("Metodo en Progreso");//Se escribe "Hola Metodo Camino mas Corto"
                            
                            break; ///Brake para el case "4"
                        }
                }

            } while (Opcion != "0");///mientras las opciones sean diferentes de 0 se van a ejecutar los cases

            Console.ReadKey(); //espera una tecla para continuar 


        }

        public static Grafo LEERTXT(string archivo) ///se lee el archivo y se crean los nodos tomando linea por linea el archivo 
        {   //Se lee el archivo 
            int counter = 0;

            Console.Clear();
            Console.WriteLine("========= El Grafo Generado es ========== ");
            string line;
            StreamReader file = new StreamReader(@"C:/" + "\\" + archivo); //la ruta desde el disco D + el nombre del archivo 
            string[] linea = file.ReadLine().Split(' '); ///se hace un split para poder separar cada peso en su respectivo nodo
            Nodo[] nodos = new Nodo[linea.Length]; //se crea un nuevo nodo con un tamaño de la linea que se leeyo 
            /*
              while ((line = file.ReadLine()) != null)
                            {
                                String[] ia = line.Split(' ');
                                //Console.WriteLine(line);
                                //Console.WriteLine(ia.Length);
                                //Console.WriteLine(ia[0]);
                                for (int i = 0; i < (Dimension - 1); i++)
                                {
                                    Matriz_2D[j, i] = int.Parse(ia[i]);
                                }
                                j++;
                                counter++;
                            }
             */
            int Dimesion = linea.Length;

            for (int i = 0; i < Dimesion; i++) ///se crea un for para poder crear lo nodos 
                nodos[i] = new Nodo();  ///se crean los nodos dependiendo del tamaño de la primera linea que se leeyo 


            for (int i = 0; i < Dimesion; i++) ///se crea un for para poder recorrer la lista de pesos en "x"
            {
                for (int j = 0; j < Dimesion; j++)///se crea un for para poder recorrer la lista de pesos en "Y"
                {
                    if (j == i)   
                        {       
                        nodos[i].setContenidoNodo(i + 1);   //le pasamos el contendio a el nodo
                        }
                        else if (int.Parse(linea[j]) != 0)  //En caso contrario y que haya conexión crea la liga. 
                    {
                        Liga x = new Liga(nodos[i], nodos[j], int.Parse(linea[j])); //se manda llamar al metodo liga para agregar las nuevas ligas a los nodos creados anteriormente 
                        nodos[i].agregarliga(x);//se agrega la liga y el peso de nodo en posicion i con la liga x que es el graof que se creo 
                    }
                }
                if (i < linea.Length - 1)   //Recorre el texto hasta la última linea.
                    linea = file.ReadLine().Split(' '); /////se hace un split para poder separar cada peso en su respectivo nodo
            }

          
            for (int i = 0; i < nodos.Length; i++)///se usa un for para recorrer en x
            {
                for (int j = 0; j < nodos[i].getLigasTotal().Count; j++) //se usa otro for para recorrer en y
                {
                    Console.Write("q" + nodos[i].getContenidoNodo()+" ===> "); ///se imprime el nodo de la pocision i
                    Console.Write("q" + nodos[i].getLiga(j).getLlegadaNodo().getContenidoNodo()); ///se imprime el nodo a donde va la liga 
                    Console.WriteLine("  Tiene una Distancia de " + nodos[i].getLiga(j).getCosto()+" metros");//se imprime el costo del nodo de la pocision i
                }
            }
            Console.ReadKey();//Despues de mostrar al usuario, este espera una tecla para continuar 
            file.Close();///se cierra el documento que se leeyo 

            return new Grafo(nodos.ToList<Nodo>()); //return un nuevo grafo con los nuevos nodos de la lista que se creo 
        }
    }

    class Nodo ///se crea la clase Nodo para guardar los nodos 
    {
        private int ContenidoNodo; //el valor del nodo devido a que los nodos son numeros 
        private bool NodoVisitado; ///true si fue visitado o false si no, para poder hacer el recorrimiento
        private List<Liga> Arco = new List<Liga>();  ///las ligas de listas 

        public Nodo() //el constructor del nodo 
        {
            this.ContenidoNodo = 0; //es el contenido del nodo 
            NodoVisitado = false;//es el visitado si esta en falso 
        }
        public Nodo(int valor) /// es el que agrega el valor del nodo Ej: nodo1=1
        {
            this.ContenidoNodo = valor;//el valor del nodo se agrega a valor 
            NodoVisitado = false;//visitado en falso 
        }
        public int getContenidoNodo() ///Get del valor para ver el nombre del nodo 
        {
            return ContenidoNodo; ///te entrega el nombre del nodo 
        }
        public List<Liga> getLigasTotal() //las listas y sus ligas de la tabla 
        {
            return Arco;  //retunr de las ligas de la tabla 
        }
        public Liga getLiga(int indice) //Get de la liga liga/te da la liga del indice que le entregas 
        {
            if (indice < Arco.Count) //si el indice es menor que las ligas 
                return Arco[indice];///retunr de las ligas[indice]
            else                     /// Si no 
                return null;         ///retunr nulo 
        }
        public bool getNodoVisitado()   ///Booleano del Get Visitado
        {
            return NodoVisitado;   //Return Visitado 
        }
        public void setNodoVisitado(bool visitado) //set de los visitados 
        {
            this.NodoVisitado = visitado; ///Agrega los visitados 
        }
        public void setContenidoNodo(int valor) ///agrega el nombre del nodo 
        {
            this.ContenidoNodo = valor; ///agrega el nombre del nodo 
        }
        public void setLigasTotales(List<Liga> ligas) /// te da las ligas de las listas del documento leido 
        {
            this.Arco = ligas;   ///las ligas de las lista 
        }
        public void setLiga(int indice, Liga liga) ///El set de las ligas // int indice y  liga de las ligas 
        {
            if (indice < Arco.Count)  ///si el inidce es menor que las el ancho de las ligas 
                Arco[indice] = liga;  ///las ligas guardan la liga 
        }
       
        public void agregarliga(Liga ligaNueva)  ///agregar una nueva liga //liga liganueva
        {
            Arco.Add(ligaNueva); ///se agrega la nueva liga tomando a la nueva liga como los nodos que se van a tomar para la liga 
        }
    }
    class Liga
    {
        private Nodo NodoInicial;
        private Nodo LlegadaNodo;
        private int Distancia;

        public Liga(Nodo origen, Nodo destino, int costo)
        {
            this.NodoInicial = origen;
            this.LlegadaNodo = destino;
            this.Distancia = costo;
        }
        public Liga(Nodo origen, int costo)
        {
            this.NodoInicial = origen;
            this.LlegadaNodo = null;
            this.Distancia = costo;
        }
        public Nodo getNodoInicial()
        {
            return NodoInicial;
        }
        public Nodo getLlegadaNodo()
        {
            return LlegadaNodo;
        }
        public int getCosto()
        {
            return Distancia;
        }
        public void setNodoInicial(Nodo origen)
        {
            this.NodoInicial = origen;
        }
        public void setLlegadaNodo(Nodo destino)
        {
            this.LlegadaNodo = destino;
        }
        public void setCosto(int costo)
        {
            this.Distancia = costo;
        }
    }
    class Grafo
    {
        private List<Nodo> nodos;
        public Grafo()
        {
            nodos = null;
        }
        public Grafo(List<Nodo> nodos)
        {
            this.nodos = nodos;
        }
        public Nodo getNodo(int index)
        {
            if (index < nodos.Count)
                return nodos[index];
            else
                return null;
        }
        
        public StringBuilder DFS(Nodo nodo)
        {
            StringBuilder Pivote = new StringBuilder();/// se crea new el stringbulder 
            nodo.setNodoVisitado(true);///Se pone al nodo como visitado 
            Stack pila = new Stack();//se crea la pila 
            pila.Push(nodo);//se mete el nodo en la pila 

            while (pila.Count != 0)//mientras la pila sea diferente de 0 sigue asiendo eso 
            {
                Nodo aux = (Nodo)pila.Pop();/// se crea el nodo auxiliar y se saca de la pila 
                Pivote.AppendLine(aux.getContenidoNodo().ToString());//del stringbulder se agrega el valor del nodo 
                List<Liga> ligasn = aux.getLigasTotal();// se crea una lista nueva llamada ligasn 
                Liga[] neibords = new Liga[aux.getLigasTotal().Count]; //se crea la liga vecionos con las lista total del auxiliar
                ligasn.CopyTo(neibords);//las lisstas se copian a vecinos 

                //1  método DFS( origen):
                //2      creamos una pila S
                //3      agregamos origen a la pila S
                //4      marcamos origen como visitado
                //5      mientras S no este vacío:
                //6          sacamos un elemento de la pila S llamado v
                //7          para cada vertice w adyacente a v en el Grafo: 
                //8              si w no ah sido visitado:
                //9                 marcamos como visitado w
                //10                 insertamos w dentro de la pila S

                for (int i = 0; i < neibords.Length; i++)//se crea un for para recorrer con la capasidad de vecinos
                {
                    if (neibords[i].getLlegadaNodo().getNodoVisitado() == false)//si los vecinos qu va a visitar estan en falso 
                    {
                        neibords[i].getLlegadaNodo().setNodoVisitado(true);//los vecinos se agregan a visitados y quedan en true
                        pila.Push(neibords[i].getLlegadaNodo());//se agregan los vecinos a la pila
                    }
                }
            }//********************************
            //***********************************
            Fv();
            return Pivote;
        }
        public StringBuilder BFS(Nodo nodo)// creacion del metodo nabegacion profunda pide el nodo de inicio 
        {
            StringBuilder str = new StringBuilder();/// se crea new el stringbulder 
            nodo.setNodoVisitado(true);//Se pone al nodo como visitado 
            Queue<Nodo> cola = new Queue<Nodo>();//se crea una cola  de nodos
            
            cola.Enqueue(nodo);

            while (cola.Count != 0)
            {
                Nodo aux = (Nodo)cola.Dequeue();/////mientras la pila sea diferente de 0 sigue asiendo eso 
                str.AppendLine(aux.getContenidoNodo().ToString());//del stringbulder se agrega el valor del nodo 
                List<Liga> ligasn = aux.getLigasTotal();// se crea una lista nueva llamada ligasn 
                Liga[] vecinos = new Liga[aux.getLigasTotal().Count];//se crea la liga vecionos con las lista total del auxiliar
                ligasn.CopyTo(vecinos);

                for (int i = 0; i < vecinos.Length; i++)//se crea un for para recorrer con la capasidad de vecinos
                {
                    if (vecinos[i].getLlegadaNodo().getNodoVisitado() == false)//si los vecinos qu va a visitar estan en falso 
                    {
                        vecinos[i].getLlegadaNodo().setNodoVisitado(true);
                        cola.Enqueue(vecinos[i].getLlegadaNodo());
                    }
                }

            }
            Fv();
            return str;
        }
        private void Fv()
        {
            for (int i = 0; i < nodos.Count; i++)
                {
                nodos[i].setNodoVisitado(false);
                }
        }
        public StringBuilder BUSCARRUTA(Nodo origen, Nodo destino)//se crea el metodo de ruta qx ==> qy, se necesita el origen y el destino 
        {
            StringBuilder str = new StringBuilder();////se crea el str
            origen.setNodoVisitado(true);// el origen se deja en visitado
            Stack cola = new Stack(); //se crea un nuevo stack llamado cola
            cola.Push(origen);//se mete el nodo origen a la cola
            Nodo Temporal = (Nodo)cola.Pop();//el nodo auxiliar para sacar de la cola

            int cont = origen.getLigasTotal().Count - 1;//un contador que tiene el total de las listas ligads totales -1

            while (Temporal != destino && cola.Count > 0)//mientras aux sea diferente de destino y cola.count mayor que 0
            {

                str.AppendLine(Temporal.getContenidoNodo().ToString());//se agrega el str el nodo 
                List<Liga> ligasn = Temporal.getLigasTotal();

                for (int i = 0; i < ligasn.Count; i++)//se crea un for que tenga una distancia de ligas count
                {
                    if (ligasn[i].getLlegadaNodo().getLigasTotal().Count == 1) //Marca como visitado pero no lo agrega a la cola.
                    {
                        if (ligasn[i].getLlegadaNodo() != destino)/// si el destino de la liga no esta visitado
                        {
                            ligasn[i].getLlegadaNodo().setNodoVisitado(true); //se marca como visitado 
                        }
                    }

                    if (ligasn[i].getLlegadaNodo().getNodoVisitado() == false)
                    {
                        ligasn[i].getLlegadaNodo().setNodoVisitado(true);
                        cola.Push(ligasn[i].getLlegadaNodo());//se agrega a la cola como visitado 
                        
                    }
                    
                }

                if (cola.Count == cont)//si la cola es igual que el cont 
                {
                    str.Clear();//se limpia el stringbulder
                    str.Append(origen.getContenidoNodo().ToString());
                }

                if (cola.Count > 0)
                    Temporal = (Nodo)cola.Pop();
            }
            str.AppendLine(Temporal.getContenidoNodo().ToString());// el origen del nodo se agrega al stringbulder
            Fv();
            return str;
        }
        public StringBuilder ciclo(Nodo origen)
        {
            StringBuilder str = new StringBuilder();
            origen.setNodoVisitado(true);
            Stack pila = new Stack();
            pila.Push(origen);
            bool ciclo = false;
            //    n.setVisitado(true);
            //    Grafo Grafo = new Grafo();
            //    Liga Gx = new Liga();
            //    Stack<Nodo> pila = new Stack<Nodo>();
            //    pila.Push(n);
            
            while (!ciclo && pila.Count != 0)
            {
                //    while (pila.Count != 0)
                //    {
                //        Nodo tempNode = pila.Pop();
                //        Console.WriteLine("Nodo : " + tempNode.getContenidoNodo());
             
                Nodo aux = (Nodo)pila.Pop();
                str.AppendLine(aux.getContenidoNodo().ToString());
                List<Liga> ligasn = aux.getLigasTotal();

                for (int i = 0; i < ligasn.Count; i++)
                {
                    if (ligasn[i].getLlegadaNodo().getNodoVisitado() == true)
                         {
                        ciclo = true;
                         }
                    else if (ligasn[i].getLlegadaNodo().getNodoVisitado() == false)
                    {
                        ligasn[i].getLlegadaNodo().setNodoVisitado(true);
                        pila.Push(ligasn[i].getLlegadaNodo());
                    }
                }
            }
            Fv();
            return str;
        }
      
       
      
    }

}