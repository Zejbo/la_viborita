using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace la_viborita
{
    public partial class Form1 : Form
    {
        private List<Circle> Vibora = new List<Circle>();
        private Circle Comida = new Circle();

        public Form1()
        {
            
            InitializeComponent();

            new Settings();
            Game_Timer.Interval = 1000 / Settings.velocidad;
            Game_Timer.Tick += updateScreen ;
            Game_Timer.Start();
            start_Game();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tocar_Tecla(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void Soltar_Tecla(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;


            if (Settings.Perdiste == false )
            {
                Brush colorSerpiente;
                for (int i = 0; i < Vibora.Count; i++)
                {
                    if (i==0)
                    {
                        colorSerpiente = Brushes.Black;
                    }
                    else
                    {
                        colorSerpiente = Brushes.Red;
                    };
                    canvas.FillEllipse(colorSerpiente,
                                        new Rectangle(
                                            Vibora[i].X * Settings.Ancho,
                                            Vibora[i].Y * Settings.Altura,
                                            Settings.Ancho, Settings.Altura
                                            )) ;

                    canvas.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            Comida.X * Settings.Ancho,
                                            Comida.Y * Settings.Altura,
                                            Settings.Ancho, Settings.Altura
                                            ));




                }
                

            }
            else if (Settings.Perdiste == false)
            {
                string Game_over_text = "Perdiste \n" + "Tu puntaje final es "+ Settings.Puntaje + "\n Toca enter para volver a jugar"   ;
                Scoreboard_Text.Text = Game_over_text;
                Scoreboard_Text.Visible = true;
            }
        }
        private void start_Game()
        {
            Scoreboard_Text.Visible = false;
            new Settings();
            Vibora.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Vibora.Add(head);
            label1.Text = Settings.Puntaje.ToString();
            GenerarComida(); 
        }
        private void Mover_jugador() 
        {
            for (int i = Vibora.Count - 1 ; i > 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Direccion)
                    {
                        case Direcciones.Derecha :
                            Vibora[i].X++;
                            break;
                        case Direcciones.Izquierda:
                            Vibora[i].X--;
                            break;
                        case Direcciones.Arriba:
                            Vibora[i].Y--;
                            break;
                        case Direcciones.Abajo:
                            Vibora[i].Y++;
                            break;
                    }
                    int maxXpos = Fondo_del_juego.Size.Width / Settings.Ancho;
                    int maxYpos = Fondo_del_juego.Size.Height / Settings.Altura;
                    if (Vibora[i].X < 0 || Vibora[i].Y < 0 ||
                            Vibora[i].X > maxXpos || Vibora[i].Y > maxYpos)
                    {
                        Morir();
                    }
                    for (int j = 1; j < Vibora.Count; j++)
                    {
                        if ( Vibora[i].X == Vibora[j].X && Vibora[i].Y == Vibora[j].Y)
                        {
                            Morir();
                        }
                    }

                    if (Vibora[0].X == Comida.X && Vibora[0].Y == Comida.Y)
                    {
                        //if so we run the eat function
                        Comer();
                    }
                    else 
                    {
                        // if there are no collisions then we continue moving the snake and its parts
                        Vibora[i].X = Vibora[i - 1].X;
                        Vibora[i].Y = Vibora[i - 1].Y;
                    }
                } 
            }
        }
        private void GenerarComida() { 
        int maxXpos = Fondo_del_juego.Size.Width / Settings.Ancho;
        int maxYpos = Fondo_del_juego.Size.Height / Settings.Altura;
            // create a maximum Y position int with half the size of the play area
            Random rnd = new Random(); // create a new random class
            Comida = new Circle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
            // create a new food with a random x and y
        }
        private void Comer()
        {
            Circle body = new Circle
            {
                X = Vibora[Vibora.Count - 1].X,
                Y = Vibora[Vibora.Count - 1].Y

            };

            Vibora.Add(body); // add the part to the snakes array
            Settings.Puntaje += Settings.Puntos; // increase the score for the game
            label2.Text = Settings.Puntaje.ToString(); // show the score on the label 2
            GenerarComida(); // run the generate food function
        }
        private void Morir()
        {
            Settings.Perdiste = true;
            
        }
        private void updateScreen (object sender, EventArgs e)
        {
            if (Settings.Perdiste == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    start_Game();
                }
            }
            else if (Settings.Perdiste == false)
            {
                if (Input.KeyPress(Keys.Right) && Settings.Direccion != Direcciones.Izquierda)
                {
                    Settings.Direccion = Direcciones.Derecha ;
                }
                if (Input.KeyPress(Keys.Left) && Settings.Direccion != Direcciones.Derecha)
                {
                    Settings.Direccion = Direcciones.Izquierda;
                }
                if (Input.KeyPress(Keys.Up) && Settings.Direccion != Direcciones.Abajo)
                {
                    Settings.Direccion = Direcciones.Arriba;
                }
                if (Input.KeyPress(Keys.Down) && Settings.Direccion != Direcciones.Arriba)
                {
                    Settings.Direccion = Direcciones.Abajo;
                }


                Mover_jugador();

                Fondo_del_juego.Invalidate();



            }
        }


    }
}
