using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace PRACTICA3_SEMAFOROS
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private Queue<string> entrada = new Queue<string>(); //se declara la cola de entrada para los vehiculos
        private Queue<string> salida = new Queue<string>(); // se declara la cola de salida para los vehiculos
        private SemaphoreSlim semaforo = new SemaphoreSlim(1, 1);//clase liviana en el espacio de nombres System.Threading de .NET que representa un contador de señales que puede utilizarse para controlar el acceso a un recurso compartido o para limitar el número de tareas que pueden ejecutarse en paralelo. Controla el acceso a los cambios de estado del semáforo (verde y rojo) en la simulación de entrada y salida de vehículos.
        private CancellationTokenSource cancellationTokenSource;//declaro un campo llamado CancellationTokenSource de tipo cancellationTokenSource, esta ultima es una clase en el espacio de nombres System.Threading de .NET esta genera tokens de cancelacion y controlar la cancelacion de operaciones asincronas.

        private async void button1_Click(object sender, EventArgs e) //boton de agregar vehiculos a la cola de entrada
        {
            listBoxcolaentrada.Items.Clear();  //para limpiar el listbox cuando ingrese otra cantidad de vehiculos
            int vehiculos = int.Parse(txtCantidadVehiculos.Text);

            for (int i = 0; i < vehiculos; i++)
            {

                entrada.Enqueue($"Coche Entrando: {entrada.Count + 1}");//enqueue es un metodo para agregar a la cola de c#
                lblEntrada.Text = $"Coches Entrando: {entrada.Count}"; //agrega al label la cantidad de vehiculos entrando

                listBoxcolaentrada.Items.Add($"Coche Entrando {entrada.Count}");//agrega el vehiculo al listbox
            }

            await ControllerSemaphore();// indica que el programa debe esperar a que la función ControllerSemaphore() se complete antes de continuar con la siguiente línea de código en el método que contiene esta llamada, sin bloquear el hilo principal y permitiendo que otras tareas continúen ejecutándose.
        }

        private async void button2_Click(object sender, EventArgs e)//boton para agregar a la cola de salida los vehiculos
        {
            listBoxcolasalida.Items.Clear(); //para limpiar el listbox cuando ingrese otra cantidad de vehiculos
            int vehiculos = int.Parse(txtCantidadVehiculos.Text);

            for (int i = 0; i < vehiculos; i++)
            {
                salida.Enqueue($"Coche Saliendo: {salida.Count + 1}");//enqueue es un metodo para agregar a la cola de c#
                lblSalida.Text = $"Coches Saliendo: {salida.Count}";//agrega al label la cantidad de vehiculos saliendo

                listBoxcolasalida.Items.Add($"Coche Saliendo {salida.Count}"); //agrega el vehiculo al listbox
            }

            await ControllerSemaphore(); //para ser uso del metodo de controlsemaforo se tiene que hacer el metodo que lo contiene async
        }

        //defino un metodo privado y asincrono que no devuelve un resultado solo una tarea que indica la finalizacion de la operacion en segundo plano
        //async indica que puede realizar operaciones asincronas sin bloquear el hilo principal de la ejecucion.

        //system.Threading.Task.Task Task indica que el metodo devuelve una tarea que representa una operacion en segundo plano, permite el uso de await en operaciones que demoran algun tiempo en completarse.
        private async System.Threading.Tasks.Task ControllerSemaphore()
        {
            //compruebo si mi variable cancellationTokenSource no es null, si no es null quiere decir que existe un cancellationTokenSource ya creado y su token podria haber sido utilizado para iniciar operaciones asincronas.
            if (cancellationTokenSource != null)
            {
                //si no es null llamo al metodo cancel() de cancellationTokenSource le manda una señal de cancelacion al token de cancelacion asociada a ese cancellationTokenSource
                //las operaciones asincronas que utilizan este token verifican si se ha solicitado la cancelacion y de ser asi se cancelaran.
                cancellationTokenSource.Cancel();
            }

            cancellationTokenSource = new CancellationTokenSource();//creo una nueva instancia y se asigna en cancellationTokenSource aqui se genera un nuevo cancellationTokenSource y su token de cancelacion asociado que se utilizara para la siguiente operacion asincrona 
            var token = cancellationTokenSource.Token;//se obtiene el token de cancelacion nuevo cancellationTokenSource utilizando .Token y lo guardo en la variable token.

            if (string.IsNullOrEmpty(txtTiempoSemaforo.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor en el campo 'Tiempo de semáforo'", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxcolaentrada.Items.Clear();//si no ingreso el tiempo el listbox ingresa la cantidad de vehiculos con esta linea hago que se borre la informacion del listbox para volver a ingresar la cantidad de vehiculos
                entrada.Clear();//reiniciamos el contador de los vehiculos

                return;
            }

            int tiempoSemaforo = int.Parse(txtTiempoSemaforo.Text);

            string unidadTiempo = cmbUnidadTiempo.SelectedItem.ToString();

            if (unidadTiempo == "Segundos")
            {
                tiempoSemaforo *= 1000;//1segundo - 1000 milisegundos
            }
            else
            {
                tiempoSemaforo *= 60 * 1000;//1 minuto - 60000 milisegundos
            }

            while (entrada.Count > 0 || salida.Count > 0)//se entra siempre que haya elementos en alguna de las colas entrada o salida
            {
                try
                {
                    //utilizo un SemaphoreSlim llamado semaforo para controlar el acceso al semáforo y sincronizar las operaciones. WaitAsync(token) espera de forma asíncrona hasta que se adquiere el semáforo. El token de cancelación se pasa como argumento para permitir la cancelación de la operación.
                    await semaforo.WaitAsync(token);
                    if (entrada.Count > 0)//si hay vehiculos en la cola de entrada
                    {
                        pictureBox1.BackColor = Color.Green;
                        entrada.Dequeue();//Se desencola un vehículo de la cola de entrada con entrada.Dequeue().
                        lblEntrada.Text = $"Coches Entrando: {entrada.Count}";//muestro la cantidad de vehículos restantes en la cola de entrada.
                        await System.Threading.Tasks.Task.Delay(tiempoSemaforo, token);//Se espera de forma asíncrona durante el tiempo especificado en tiempoSemaforo antes de continuar.
                    }

                    pictureBox1.BackColor = Color.Red;
                    await System.Threading.Tasks.Task.Delay(tiempoSemaforo, token);

                    if (salida.Count > 0)
                    {
                        pictureBox1.BackColor = Color.Green;
                        salida.Dequeue();
                        lblSalida.Text = $"Coches Saliendo: {salida.Count}";
                        await System.Threading.Tasks.Task.Delay(tiempoSemaforo, token);
                    }

                    pictureBox1.BackColor = Color.Red;
                }
                catch (OperationCanceledException) { }
                finally
                {
                    semaforo.Release();//se libera el semaforo para permitir que otras operaciones lo adquieran.
                }
            }
        }
    }
}
