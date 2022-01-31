using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;

namespace Steam.v2
{
    public partial class PlayMyGameForm : Form
    {
        Game allMyGames { get; set; }
        public PlayMyGameForm(Game game)
        {
            allMyGames = game;
            InitializeComponent();
        }
        public PlayMyGameForm()
        {
            InitializeComponent();
        }

        private void PlayMyGameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
