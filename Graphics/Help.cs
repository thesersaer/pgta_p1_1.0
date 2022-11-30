using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Help : Form
    {
        int pagina = 0;

        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            labelTitol.Text = "Cargar fichero";
            pagina = 0;
            labelPag.Text = "1/3";
            labelText.Text = "Con el botón cargar fichero te permite cargar un fichero .ast para poder obtener los datos del asterix." + "\n" +
                        "Cuando el programa tenga el fichero cargado, saldrá un mensaje al lado del botón." + "\n" +
                        "Si una vez cargado un fichero quieres sustituirlo por otro nuevo, solo hace falta volver a clicar el botón y se borrara el antiguo y podrás seleccionar el nuevo";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pagina < 2 && pagina >= 0)
            {
                pagina++;
                if (pagina == 0)
                {
                    labelTitol.Text = "Cargar fichero";
                    labelPag.Text = "1/3";
                    labelText.Text = "Con el botón cargar fichero te permite cargar un fichero .ast para poder obtener los datos del asterix." + "\n" + 
                        "Cuando el programa tenga el fichero cargado, saldrá un mensaje al lado del botón." + "\n" +
                        "Si una vez cargado un fichero quieres sustituirlo por otro nuevo, solo hace falta volver a clicar el botón y se borrara el antiguo y podrás seleccionar el nuevo";
                }
                else if(pagina == 1)
                {
                    labelTitol.Text = "Mostrar Tabla";
                    labelPag.Text = "2/3";
                    labelText.Text = "Una vez cargado el fichero asterix, la tabla mostrará la siguiente información de cada detección:  " + "\n" +
                        "               ·Number;" + "\n" + "               ·Category;" + "\n" + "               ·SIC;" + "\n" + "               ·SAC;" + "\n" + "               ·Target Identification;"
                         + "\n" + "               ·Track Number;" + "\n" + "               ·Time of Day;" + "\n" + "               ·Target Address." + "\n" +
                         "Para ver más información de cada detección, solo se debe clicar encima de la tabla y se mostrará la demás información a la izquierda, donde se podrá pasar de página con el botón Next Page." + "\n" +
                         "Para ver las detecciones de una categoria en concreto, solo se debe pulsar en el botón correspondiente que esta encima de la tabla." + "\n" +
                         "Para buscar una detección en concreto solo se debe seleccionar qué se quiere buscar, escribir en el textBOX que hay debajo de la tabla y clicar en el botón search";
                }
                else if(pagina== 2)
                {
                    labelTitol.Text = "Mostrar Mapa";
                    labelPag.Text = "3/3";
                    labelText.Text = "Una vez cargado el fichero asterix, se mostrara en el mapa la posición de cada detección en el momento del contador." + "\n" +
                        "Se puede poner en marcha o pausar el tiempo con el botón Play/Pause." + "\n" +
                        "Para reiniciar la simulación se debe pulsar el botón RESET." + "\n" +
                        "Para seleccionar una hora inicial se debe seleccionar la hora a partir de las listas que hay debajo del mapa y luego seleccionar aceptar. La hora inical por defecto es la mínima que hay en el fichero" + "\n" +
                        "Para hacer zoom en el mapa se puede hacer con la rueda del ratón o con el trackBar que hay al lado del mapa." + "\n" +
                        "Para centrar el mapa en LEBL se debe pulsar el botón LEBL. Si se desea ver Barcelona se debe pulsar BCN y si se desea ver Catalunya se debe pulsar CAT" + "\n" +
                        "Para configurar los aspectos de la simulación se debe pulsar el botón Configuracion. Allí, podrás modificar la velocidad de simulación, las categorías que se van a mostrar, el tipo de mapa y si se quiere mostrar los puntos antiguos o no." + "\n" +
                        "Una vez cambiada la configuración, se debe clicar el botón aceptar.";
                }
            }
            else
            {
                MessageBox.Show("There are no more pages");
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pagina <= 2 && pagina > 0)
            {
                pagina--;
                if (pagina == 0)
                {
                    labelTitol.Text = "Cargar fichero";
                    labelPag.Text = "1/3";
                    labelText.Text = "Con el botón cargar fichero te permite cargar un fichero .ast para poder obtener los datos del asterix." + "\n" +
                        "Cuando el programa tenga el fichero cargado, saldrá un mensaje al lado del botón." + "\n" +
                        "Si una vez cargado un fichero quieres sustituirlo por otro nuevo, solo hace falta volver a clicar el botón y se borrara el antiguo y podrás seleccionar el nuevo";
                }
                else if (pagina == 1)
                {
                    labelTitol.Text = "Mostrar Tabla";
                    labelPag.Text = "2/3";
                    labelText.Text = "Una vez cargado el fichero asterix, la tabla mostrará la siguiente información de cada detección:  " + "\n" +
                        "               ·Number;" + "\n" + "               ·Category;" + "\n" + "               ·SIC;" + "\n" + "               ·SAC;" + "\n" + "               ·Target Identification;"
                         + "\n" + "               ·Track Number;" + "\n" + "               ·Time of Day;" + "\n" + "               ·Target Address." + "\n" +
                         "Para ver más información de cada detección, solo se debe clicar encima de la tabla y se mostrará la demás información a la izquierda, donde se podrá pasar de página con el botón Next Page." + "\n" +
                         "Para ver las detecciones de una categoria en concreto, solo se debe pulsar en el botón correspondiente que esta encima de la tabla." + "\n" +
                         "Para buscar una detección en concreto solo se debe seleccionar qué se quiere buscar, escribir en el textBOX que hay debajo de la tabla y clicar en el botón search";
                }
                else if (pagina == 2)
                {
                    labelTitol.Text = "Mostrar Mapa";
                    labelPag.Text = "3/3";
                    labelText.Text = "Una vez cargado el fichero asterix, se mostrara en el mapa la posición de cada detección en el momento del contador." + "\n" +
                        "Se puede poner en marcha o pausar el tiempo con el botón Play/Pause." + "\n" +
                        "Para reiniciar la simulación se debe pulsar el botón RESET." + "\n" +
                        "Para seleccionar una hora inicial se debe seleccionar la hora a partir de las listas que hay debajo del mapa y luego seleccionar aceptar. La hora inical por defecto es la mínima que hay en el fichero" + "\n" +
                        "Para hacer zoom en el mapa se puede hacer con la rueda del ratón o con el trackBar que hay al lado del mapa." + "\n" +
                        "Para centrar el mapa en LEBL se debe pulsar el botón LEBL. Si se desea ver Barcelona se debe pulsar BCN y si se desea ver Catalunya se debe pulsar CAT" + "\n" +
                        "Para configurar los aspectos de la simulación se debe pulsar el botón Configuracion. Allí, podrás modificar la velocidad de simulación, las categorías que se van a mostrar, el tipo de mapa y si se quiere mostrar los puntos antiguos o no." + "\n" +
                        "Una vez cambiada la configuración, se debe clicar el botón aceptar.";
                }
            }
            else
            {
                MessageBox.Show("Minimum pages reached");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
