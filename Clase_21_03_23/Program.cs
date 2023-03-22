using System;
using System.Runtime.CompilerServices;

class Program

{
    public class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get; set; }
        public int Edad { get; set; }
       

        public virtual void mostrar()
        {
            Console.WriteLine("Esta persona se llama {0} y su edad es {1}", Nombre , Edad);
        }

    }
    public class Empleado : Persona
    {
        private int sueldo_bruto;

        public int SueldoBruto { get; set; }
      
        public override void mostrar()
        {
            Console.WriteLine("El empleado se llama {0}, tiene {1}, años y su sueldo bruto es de {2}", Nombre, Edad, SueldoBruto);
        }
        private void calcular_salario_neto()
        {
            Console.WriteLine(sueldo_bruto * 0.83);
        }

    }

    public class Cliente : Persona
    {
        private int telefono_de_contacto;

        public int TelefonoDeContacto { get; set; }
     
        public override void mostrar()
        {
            Console.WriteLine("El cliente se llama {0}, tiene {1} años y su número de teléfono es {2}", Nombre, Edad, TelefonoDeContacto);
        }
    }


    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Nombre= "Miyuki";
        persona.Edad =26;
        persona.mostrar();

        Empleado empleado = new Empleado();
        empleado.Nombre = "Hiroshi";
        empleado.Edad = 25;
        empleado.SueldoBruto = 150000;
        empleado.mostrar();


        Cliente cliente = new Cliente();
        cliente.Nombre = "Mara";
        cliente.Edad = 31;
        cliente.TelefonoDeContacto = 988776655;
        cliente.mostrar();
    }
}


