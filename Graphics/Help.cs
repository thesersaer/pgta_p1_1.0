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
        int ex;
        int ey;
        bool Arrastre = false;


        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            labelTitol.Text = "LOAD FILE";
            pagina = 0;
            labelPag.Text = "1/3";
            labelText.Text = "With the button load file it allows you to load an .ast file to be able to obtain the data of the asterix." + "\n" +
                        "When the program has the file loaded, a message will appear next to the button." + "\n" +
                        "If once a file has been loaded you want to replace it with a new one, you just need to click the button again and the old one will be deleted and you will be able to select the new one.";
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pagina < 2 && pagina >= 0)
            {
                pagina++;
                if (pagina == 0)
                {
                    labelTitol.Text = "LOAD FILE";
                    labelPag.Text = "1/3";
                    labelText.Text = "With the button load file it allows you to load an .ast file to be able to obtain the data of the asterix." + "\n" +
                        "When the program has the file loaded, a message will appear next to the button." + "\n" +
                        "If once a file has been loaded you want to replace it with a new one, you just need to click the button again and the old one will be deleted and you will be able to select the new one.";
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                }
                else if(pagina == 1)
                {
                    labelTitol.Text = "SHOW TABLE";
                    labelPag.Text = "2/3";
                    labelText.Text = "Once the asterix file is loaded, the table will show the following information for each detection:  " + "\n" +
                        "               ·Number;" + "\n" + "               ·Category;" + "\n" + "               ·SIC;" + "\n" + "               ·SAC;" + "\n" + "               ·Target Identification;"
                         + "\n" + "               ·Track Number;" + "\n" + "               ·Time of Day;" + "\n" + "               ·Target Address." + "\n" +
                         "To see more information on each detection, just click on the table and the other information will be displayed on the left, where you can go to the next page with the Next Page button." + "\n" +
                         "To see the detections of a specific category, you just have to click on the corresponding button that is below the table." + "\n" +
                         "To search for a specific detection, you just have to select what you want to search for, write in the textBOX below the table and click on the search button.";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                }
                else if(pagina== 2)
                {
                    labelTitol.Text = "SHOW MAP";
                    labelPag.Text = "3/3";
                    labelText.Text = "Once the asterix file is loaded, the position of each detection at the time of the counter will be shown on the map." + "\n" +
                        "Time can be started or paused with the Play/Pause button." + "\n" +
                        "To restart the simulation, press the RESET button." + "\n" +
                        "To select a start time you must select the time from the lists below the map and then select accept." +  "\n" + "The default start time is the minimum in the file." + "\n" +
                        "To zoom in on the map you can do it with the mouse wheel or with the trackBar next to the map." + "\n" +
                        "To see the characteristics of a point, select that point on the map and the basic information will appear in the table below the map." + "\n"+
                        "To center the map on LEBL you must press the LEBL button. If you want to see Barcelona you must press BCN and if you want to see Catalonia you must press CAT." + "\n" +
                        "To configure the aspects of the simulation, you must press the Configuration button." + "\n" + "There, you will be able to modify the simulation speed, the categories that are going to be displayed, the type of map and if you want to show the old points or not." + "\n" +
                        "Once the configuration has been changed, the accept button must be clicked.";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
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
                    labelTitol.Text = "LOAD FILE";
                    labelPag.Text = "1/3";
                    labelText.Text = "With the button load file it allows you to load an .ast file to be able to obtain the data of the asterix." + "\n" +
                        "When the program has the file loaded, a message will appear next to the button." + "\n" +
                        "If once a file has been loaded you want to replace it with a new one, you just need to click the button again and the old one will be deleted and you will be able to select the new one.";
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                }
                else if (pagina == 1)
                {
                    labelTitol.Text = "SHOW TABLE";
                    labelPag.Text = "2/3";
                    labelText.Text = "Once the asterix file is loaded, the table will show the following information for each detection:  " + "\n" +
                        "               ·Number;" + "\n" + "               ·Category;" + "\n" + "               ·SIC;" + "\n" + "               ·SAC;" + "\n" + "               ·Target Identification;"
                         + "\n" + "               ·Track Number;" + "\n" + "               ·Time of Day;" + "\n" + "               ·Target Address." + "\n" +
                         "To see more information on each detection, just click on the table and the other information will be displayed on the left, where you can go to the next page with the Next Page button." + "\n" +
                         "To see the detections of a specific category, you just have to click on the corresponding button that is below the table." + "\n" +
                         "To search for a specific detection, you just have to select what you want to search for, write in the textBOX below the table and click on the search button.";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                }
                else if (pagina == 2)
                {
                    labelTitol.Text = "SHOW MAP";
                    labelPag.Text = "3/3";
                    labelText.Text = "Una vez cargado el fichero asterix, se mostrara en el mapa la posición de cada detección en el momento del contador." + "\n" +
                        "Se puede poner en marcha o pausar el tiempo con el botón Play/Pause." + "\n" +
                        "Para reiniciar la simulación se debe pulsar el botón RESET." + "\n" +
                        "Para seleccionar una hora inicial se debe seleccionar la hora a partir de las listas que hay debajo del mapa y luego seleccionar aceptar. La hora inical por defecto es la mínima que hay en el fichero" + "\n" +
                        "Para hacer zoom en el mapa se puede hacer con la rueda del ratón o con el trackBar que hay al lado del mapa." + "\n" +
                        "Para centrar el mapa en LEBL se debe pulsar el botón LEBL. Si se desea ver Barcelona se debe pulsar BCN y si se desea ver Catalunya se debe pulsar CAT" + "\n" +
                        "Para configurar los aspectos de la simulación se debe pulsar el botón Configuracion. Allí, podrás modificar la velocidad de simulación, las categorías que se van a mostrar, el tipo de mapa y si se quiere mostrar los puntos antiguos o no." + "\n" +
                        "Una vez cambiada la configuración, se debe clicar el botón aceptar.";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void Help_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void Help_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }

        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }
    }
}
