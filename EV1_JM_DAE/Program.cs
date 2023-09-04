using System.ComponentModel.Design;
using System.Numerics;

namespace EV1_JM_DAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainFlag = true;
            string mainMenuChoice;
            int aux1;

            while (mainFlag)
            {
                mainMenuChoice = "n";
                Console.WriteLine("----------------- EVALUACION PRACTICA 1 - JULIAN MANZANO -----------------");
                Console.WriteLine("\tElija el ejercicio que desea ejecutar (digite el numero): ");
                Console.WriteLine("\t\t[1] - Ejercicio 1");
                Console.WriteLine("\t\t[2] - Ejercicio 2");
                Console.WriteLine("\t\t[0] - SALIR");
                Console.Write("\tSeleccion: ");
                mainMenuChoice = Console.ReadLine();
                aux1 = int.Parse(mainMenuChoice);
                
                Console.Clear();

                switch(aux1)
                {
                    case 0:
                        mainFlag = false;
                        Console.WriteLine("Demo de ejercicios finalizada...");
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 1:
                        string[] artista = { };
                        string[] titulo = { };
                        string[] duracion = { };
                        string[] size = { };
                        string addNew;
                        bool flagEj1 = true;

                        while (flagEj1)
                        {
                            Console.WriteLine("----------------- ALMACEN DE CANCIONES -----------------");
                            Console.WriteLine("Ingrese el artista de la canción: ");
                            artista = artista.Append(Console.ReadLine()).ToArray();
                            Console.WriteLine("Ingrese el titulo de la canción: ");
                            titulo = titulo.Append(Console.ReadLine()).ToArray();
                            Console.WriteLine("Ingrese la duración de la cancion (en seg): ");
                            duracion = duracion.Append(Console.ReadLine()).ToArray();
                            Console.WriteLine("Ingrese el tamano de la cancion (en KB): ");
                            size = size.Append(Console.ReadLine()).ToArray();

                            Console.WriteLine("¿Desea agregar otra cancion? (S/N): ");
                            addNew = Console.ReadLine();
                            addNew = addNew.ToUpper();

                            Console.Clear();

                            if (addNew == "S")
                            {
                                flagEj1 = true;
                            }
                            else
                            {
                                flagEj1 = false;
                            }
                        };

                        Console.Clear();

                        Console.WriteLine("----------------- CANCIONES ALMACENADAS -----------------");
                        Console.WriteLine(String.Format("{0,-16} {1,-15} {2,-10} {3,-10}","Artista","Titulo","Duracion","Size"));

                        for (int i = 0; i < artista.Length; i++)
                        {
                            Console.WriteLine(String.Format("{0,-16} {1,-15} {2,-10} {3,-10}", artista[i], titulo[i], duracion[i], size[i]));
                        }

                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        string[] id = { };
                        string[] name = { };
                        string[] fecha = { };
                        string[] grado = { };
                        string[] registro = { };
                        bool flagEj2 = true;
                        int ej2Choice = 999;
                        int result = 9999;
                        string auxedicion;
                        string newName;
                        string newFecha;
                        string newGrado;
                        string newRegistro;

                        while (flagEj2)
                        {
                            Console.WriteLine("----------------- SISTEMA REGISTRO DE ESCUELA -----------------");
                            Console.WriteLine("\tBIENVENIDO AL MENU PRINCIPAL, elija la opción deseada: ");
                            Console.WriteLine("\t\t[1] - Agregar nuevo alumno");
                            Console.WriteLine("\t\t[2] - Mostrar listado de alumnos");
                            Console.WriteLine("\t\t[3] - Buscar alumno");
                            Console.WriteLine("\t\t[4] - Editar información de alumno");
                            Console.WriteLine("\t\t[0] - SALIR");
                            Console.Write("\tSeleccion: ");

                            ej2Choice = int.Parse(Console.ReadLine());

                            switch (ej2Choice)
                            {
                                case 0:

                                    Console.Clear();
                                    flagEj2 = false;
                                    break;
                                case 1:

                                    bool case1Flag = true;
                                    string addAlumno;
                                    Console.Clear();

                                    while (case1Flag)
                                    {
                                        Console.WriteLine("|----------------------- AGREGAR ALUMNO -----------------------|");
                                        Console.WriteLine("Ingrese el codigo del alumno: ");
                                        id = id.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese el nombre del alumno: ");
                                        name = name.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese la fecha de nacimiento del alumno: ");
                                        fecha = fecha.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese el grado del alumno: ");
                                        grado = grado.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese el año de registro del alumno: ");
                                        registro = registro.Append(Console.ReadLine()).ToArray();

                                        Console.WriteLine("¿Desea agregar otro alumno? (S/N): ");
                                        addAlumno = Console.ReadLine();
                                        addAlumno = addAlumno.ToUpper();

                                        Console.Clear();

                                        if (addAlumno == "S")
                                        {
                                            case1Flag = true;
                                        }
                                        else
                                        {
                                            case1Flag = false;
                                        }

                                    }
                                    
                                    break;

                                case 2:

                                    if(id.Length == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("----------ERROR----------");
                                        Console.WriteLine("NO HAY ALUMNOS QUE MOSTRAR...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();

                                        Console.WriteLine("|----------------------- LISTA ALUMNOS -----------------------|");
                                        Console.WriteLine(String.Format("{0,-10} {1,-45} {2,-15} {3,-15} {4,-15}", "ID", "Nombre Completo", "Fecha Nac.", "Grado", "Año Registro"));

                                        for (int i = 0; i < id.Length; i++)
                                        {
                                            Console.WriteLine(String.Format("{0,-10} {1,-45} {2,-15} {3,-15} {4,-15}", id[i], name[i], fecha[i], grado[i], registro[i]));
                                        }

                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    
                                    break;

                                case 3:
                                    result = 9999;
                                    string searchID;
                                    Console.Clear();
                                    Console.WriteLine("|----------------------- BUSCAR ALUMNO -----------------------|");
                                    Console.Write("Ingrese ID a buscar: ");
                                    searchID = Console.ReadLine();

                                    for (int i = 0; i < id.Length; i++)
                                    {
                                        if (searchID == id[i])
                                        {
                                            result = i;
                                            break;
                                        }
                                    }

                                    if (result == 9999)
                                    {
                                        Console.WriteLine("Alumno no encontrado, intente nuevamente...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("|----------------------- ALUMNO ENCONTRADO -----------------------|");
                                        Console.WriteLine(String.Format("{0,-10} {1,-45} {2,-15} {3,-15} {4,-15}", "ID", "Nombre Completo", "Fecha Nac.", "Grado", "Año Registro"));
                                        Console.WriteLine(String.Format("{0,-10} {1,-45} {2,-15} {3,-15} {4,-15}", id[result], name[result], fecha[result], grado[result], registro[result]));
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    break;

                                case 4:

                                    result = 9999;

                                    Console.WriteLine("|----------------------- EDITAR ALUMNO -----------------------|");
                                    Console.Write("Ingrese ID: ");
                                    searchID = Console.ReadLine();

                                    for (int i = 0; i < id.Length; i++)
                                    {
                                        if (searchID == id[i])
                                        {
                                            result = i;
                                            break;
                                        }
                                    }

                                    if (result == 9999)
                                    {
                                        Console.WriteLine("Alumno no encontrado, intente nuevamente...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("|----------------------- EDITAR ALUMNO -----------------------|");
                                        Console.WriteLine("\t¿Que informacion desea editar? Seleccione:");
                                        Console.WriteLine("\t\t[1] - Nombre Alumno");
                                        Console.WriteLine("\t\t[2] - Fecha de Nacimiento");
                                        Console.WriteLine("\t\t[3] - Grado");
                                        Console.WriteLine("\t\t[4] - Anio de Registro");
                                        Console.WriteLine("\t\t[0] - SALIR");
                                        Console.Write("Seleccion: ");
                                        auxedicion = Console.ReadLine();

                                        switch (auxedicion)
                                        {
                                            case "1":

                                                Console.WriteLine("Nombre actual: " + name[result]);
                                                Console.Write("Ingrese nuevo nombre: ");
                                                newName = Console.ReadLine();
                                                Console.WriteLine("Nombre modificado...");
                                                name[result] = newName;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "2":

                                                Console.WriteLine("Fecha de nacimiento actual: " + fecha[result]);
                                                Console.Write("Ingrese nueva fecha de nacimiento: ");
                                                newFecha = Console.ReadLine();
                                                Console.WriteLine("Fecha de nacimiento modificada...");
                                                fecha[result] = newFecha;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "3":

                                                Console.WriteLine("Grado actual: " + grado[result]);
                                                Console.Write("Ingrese nuevo grado: ");
                                                newGrado = Console.ReadLine();
                                                Console.WriteLine("Grado modificado...");
                                                grado[result] = newGrado;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "4":

                                                Console.WriteLine("Anio de Registro actual: " + registro[result]);
                                                Console.Write("Ingrese nuevo Anio de registro: ");
                                                newRegistro = Console.ReadLine();
                                                Console.WriteLine("Anio de registro modificado...");
                                                registro[result] = newRegistro;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "0":
                                                Console.Clear();
                                                break;

                                            default:
                                                Console.WriteLine("EDICION INVÁLIDA, INTENTE NUEVAMENTE...");
                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;

                                        }

                                    }

                                    break;

                                default:
                                    
                                    Console.Clear();
                                    Console.WriteLine("Opcion invalida... intente de nuevo");
                                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Opcion invalida... intente de nuevo");
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}