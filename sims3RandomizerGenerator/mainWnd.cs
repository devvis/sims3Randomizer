using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sims3RandomizerGenerator
{
    public partial class mainWnd : Form
    {
        public mainWnd()
        {
            InitializeComponent();
        }

        private void simSaveButton_Click(object sender, EventArgs e)
        {
            // This should save all the changes to a file :D
            simSaveChallengeFile.ShowDialog();
        }

        private void simSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Here we should save all the current values of the fields into an object
            // for later use when the user presses the simSaveButton
        }

        private void simSaveChallengeFile_FileOk(object sender, CancelEventArgs e)
        {
            // okay :(
            MessageBox.Show("D:");
        }

        private void simAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.simAge.Text)
            {
                case "Toddler":

                    break;
                case "Child":
                    populateChildTraits();
                    break;
                case "Teen":

                    break;
                case "Young Adult":

                    break;
                case "Adult":

                    break;
                case "Elder":

                    break;
                default:

                    break;
            }
        }

        private void populateChildTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Absent-Minded");
            traits.Add("Adventurous");
            traits.Add("Ambitious");
            traits.Add("Angler");
            traits.Add("Artistic");
            traits.Add("Athletic");
            traits.Add("Bookworm");
            traits.Add("Brave");
            traits.Add("Can't Stand Art");
            traits.Add("Clumsy");
            traits.Add("Computer Whiz");
            traits.Add("Couch Potato");
            traits.Add("Coward");
            traits.Add("Daredevil");
            traits.Add("Disciplined");
            traits.Add("Easily Impressed");
            traits.Add("Eccentric");
            traits.Add("Eco Friendly");
            traits.Add("Evil");
            traits.Add("Excitable");
            traits.Add("Family Oriented");
            traits.Add("Friendly");
            traits.Add("Frugal");
            traits.Add("Genius");
            traits.Add("Good");
            traits.Add("Good Sense of Humor");
            traits.Add("Grumpy");
            traits.Add("Hates the Outdoors");
            traits.Add("Heavy Sleeper");
            traits.Add("Hot Headed");
            traits.Add("Hydrophobic");
            traits.Add("Inappropriate");
            traits.Add("Insane");
            traits.Add("Kleptomaniac");
            traits.Add("Light Sleeper");
            traits.Add("Loner");
            traits.Add("Loser");
            traits.Add("Loves the Outdoors");
            traits.Add("Lucky");
            traits.Add("Mean Spirited");
            traits.Add("Mooch");
            traits.Add("Neat");
            traits.Add("Neurotic");
            traits.Add("Never Nude");
            traits.Add("No Sense of Humor");
            traits.Add("Over Emotional");
            traits.Add("Party Animal");
            traits.Add("Perceptive");
            traits.Add("Perfectionist");
            traits.Add("Photographer's Eye");
            traits.Add("Rebellious");
            traits.Add("Shy");
            traits.Add("Slob");
            traits.Add("Snob");
            traits.Add("Star Quality");
            traits.Add("Technophobe");
            traits.Add("Unlucky");
            traits.Add("Vegetarian");
            traits.Add("Vehicle Enthusiast");
            traits.Add("Virtuoso");
            traits.Add("Workaholic");

            this.simTrait1.Text = "";
            this.simTrait2.Text = "";
            this.simTrait3.Text = "";
            this.simTrait4.Items.Add("None");
            this.simTrait5.Items.Add("None");
            
            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
            }

        }
    }
}
