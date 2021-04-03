using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidPuller
{
    public partial class Form1 : Form
    {
        List<Image> imagesRare = new List<Image>();
        List<Image> imagesEpic = new List<Image>();
        List<Image> imagesLego = new List<Image>();
        
        
        public Form1()
        {
            InitializeComponent();
            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            OpenAncient.BringToFront();
            OpenVoid.BringToFront();
            OpenSacred.BringToFront();
            Clear.BringToFront();
            Result.BringToFront();
        }
        private void OpenAncient_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int chance = random.Next(0,100);
            int rares = RareBox.Items.Count;
            int epics = EpicBox.Items.Count;
            int legos = LegoBox.Items.Count;
            try
            {
                if (chance > 7)
                {
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Bombardier.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Cataphract.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Conquerer.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Courtier.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Crossbowman.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Grandmaster.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Halberdier.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Myrmidon.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Preserver.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Quaestor.jpg"));
                    imagesRare.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Rare\Valerie.jpg"));
                    int rare = random.Next(0, rares);
                    Result.Text = RareBox.Items[rare].ToString() + "\n Got rare!";
                    PictureBox.Image = imagesRare[rare];
                    imagesRare.Clear();
                }

                if (chance > 1 & chance <= 7)
                {
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Alaric the Hooded.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Archmage Hellmut.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Chancellor Yasmin.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Gerhard the Stone.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Hordin.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Knight-Errant.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Lordly Legionary.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Masked Fearmonger.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Oathbound.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Seneschal.jpg"));
                    imagesEpic.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Epic\Stag Knight.jpg"));
                    int epic = random.Next(0, epics);
                    Result.Text = EpicBox.Items[epic].ToString() + "\n Got epic!";
                    PictureBox.Image = imagesEpic[epic];
                    imagesEpic.Clear();
                }

                if (chance <= 1)
                {
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Black Knight.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Cillian the Lucky.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Lord Champfort.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Lugan the Steadfast.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Minaya.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Richtoff the Bold.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Septimus.jpg"));
                    imagesLego.Add(Image.FromFile(@"C:\Users\My\Desktop\Pictures\Banner lords\Legendary\Sethallia.jpg"));
                    int lego = random.Next(0, legos);
                    Result.Text = LegoBox.Items[lego].ToString() + "\n Got lego!";
                    PictureBox.Image = imagesLego[lego];
                    imagesLego.Clear();
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("No memory!");
            }
        }
        private void OpenSacred_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int chance = random.Next(0, 100);
            int epics = EpicBox.Items.Count;
            int legos = LegoBox.Items.Count;

            if (chance > 6) {
                int epic = random.Next(1, epics);
                Result.Text = EpicBox.Items[epic].ToString() + "\n Got epic!";
            }

            if (chance <= 6) {
                int lego = random.Next(1, legos);
                Result.Text = LegoBox.Items[lego].ToString() + "\n Got lego!";
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            PictureBox.Image = null;
        }
        private void OpenVoid_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int chance = random.Next(0, 100);
            int rares = VoidRareBox.Items.Count;
            int epics = VoidEpicBox.Items.Count;
            int legos = VoidLegoBox.Items.Count;

            if (chance > 7) {
                int rare = random.Next(1, rares);
                Result.Text = VoidRareBox.Items[rare].ToString() + "\n Got rare!";
            }

            if (chance > 1 & chance <=7) {
                int epic = random.Next(1, epics);
                Result.Text = VoidEpicBox.Items[epic].ToString() + "\n Got epic!";
            }

            if (chance == 1) {
                int lego = random.Next(1, legos);
                Result.Text = VoidLegoBox.Items[lego].ToString() + "\n Got lego!";
            }
        }


        public Image images { get; set; }
    }
}
