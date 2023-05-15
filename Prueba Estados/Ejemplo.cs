using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Estados
{
    public class Ejemplo
    {

        private BackgroundWorker worker = new BackgroundWorker();

        public void procesar()
        {
            Console.WriteLine("Iniciando procesar...");

            // register background worker events
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            // start background worker in different thread to the GUI
            worker.RunWorkerAsync();
        }
        /*Programación Multihilo (Estudiar)*/
        public void operacion2()
        {
            Console.WriteLine("Ejecutando operacion 2");
        }


        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // This is where the processor intensive code should go
            ProcessorIntensiveCode();

            // if we need any output to be used, put it in the DoWorkEventArgs object
            e.Result = "finalizado 1";
        }

        private void ProcessorIntensiveCode()
        {
            System.Threading.Thread.Sleep(5000);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // will output "all done" to the console //enviará "todo listo" a la consola
            Console.WriteLine((string)e.Result);
        }

    }
}
