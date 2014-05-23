using System;
using System.Collections.Generic;
using System.IO; //Agregando libreria para Espacio de nombres de flujo
using System.Linq;
using System.Web;

namespace EmployeeQuiz.Models
{
    public class PayrollDm
    {
        //es una clase que dialoga con el archivo
        //Lista de empleados
        List<Employee> empList;

        //Constructor del Modelo
        public PayrollDm(string dbPath)    
        {
            //Creando el objeto de la lista de empleados
            empList = new List<Employee>();

            //Leer un Archivo
            var reader = new StreamReader(
                File.OpenRead(dbPath));

            //Leer linea por linea y Parsear

            while (!reader.EndOfStream)
            {
                //Leo una línea 
                var line = reader.ReadLine();

                //Parsear  separar valores y guardarlos en un objeto
                var valores = line.Split(',');
                empList.Add(
                    new Employee
                    {
                        Id = valores[0],
                        FirstLastname = valores[1],
                        SecondLastname = valores[2],
                        Name = valores[3],
                        Position = valores[4],
                        Wage = double.Parse(valores[5]),
                        Sex = char.Parse(valores[6]),
                        PhotoPath = valores[7]
                        
                        

                    });

               
            }

        }

        //Accesor
        public Employee GetEmployeeById(string id)
        {
           //* Employee emp = null;

           // foreach (var empleadin in empList)
           // {
               /// if (id == empleadin.Id)
               // {
                   // emp = empleadin;


                //}
            var emp = empList.Find(e => e.Id == id);
                return emp;
            }

        }
    }
