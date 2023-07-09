using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Somegame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        //private HubConnection _connection;


        private DispatcherTimer GameTimer = new DispatcherTimer();
        private bool UpKeyPressed, DownKeyPressed, LeftKeyPressed, RightKeyPressed;
        private float SpeedX, SpeedY, Friction = 0.88f, Speed = 2;
        private void KeyboardDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.W)
            {
                UpKeyPressed = true;
            }
            if (e.Key == Key.A)
            {
                LeftKeyPressed = true;
            }if (e.Key == Key.D)
            {
                RightKeyPressed = true;
            }if (e.Key == Key.S)
            {
                DownKeyPressed = true;
            }
        } private void KeyboardUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                UpKeyPressed = true;
            }
            if (e.Key == Key.A)
            {
                LeftKeyPressed = true;
            }
            if (e.Key == Key.D)
            {
                RightKeyPressed = true;
            }
            if (e.Key == Key.S)
            {
                DownKeyPressed = true;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
           
            //_connection = new HubConnection("https://localhost:7250/testhub");

            GameScreen.Focus();

            GameTimer.Interval = TimeSpan.FromMilliseconds(16);
            GameTimer.Tick += GameTick;
            GameTimer.Start();
        }

        private void GameTick(object? sender, EventArgs e)
        {
            if (UpKeyPressed)
            {
                SpeedY += Speed;
            }
            if (RightKeyPressed)
            {
                SpeedX += Speed;
            }
            if (LeftKeyPressed)
            {
                SpeedX -= Speed;
            }
            if (DownKeyPressed)
            {
                SpeedY -= Speed;
            }

            SpeedX = SpeedX * Friction;
            SpeedY = SpeedY * Friction;

            Canvas.SetLeft(Player, Canvas.GetLeft(Player) + SpeedX);
            Canvas.SetTop(Player, Canvas.GetTop(Player) - SpeedY);
        }
    }
}
