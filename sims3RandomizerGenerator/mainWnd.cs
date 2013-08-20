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
            if (this.simType.Text != "Dog" || this.simType.Text != "Cat" || this.simType.Text != "Horse")
            {
                // we've already taken care of pet-traits in the Type-selection
                // and they don't change based on age, hence they're uneccessary here.
                switch (this.simAge.Text)
                {
                    case "Toddler":
                        populateToddlerTraits();
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
        }

        private void populateToddlerTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Abscent-Minded");
            traits.Add("Artistic");
            traits.Add("Athletic");
            traits.Add("Brave");
            traits.Add("Clumsy");
            traits.Add("Couch Potato");
            traits.Add("Disciplined");
            traits.Add("Easily Impressed");
            traits.Add("Eccentric");
            traits.Add("Evil");
            traits.Add("Excitable");
            traits.Add("Friendly");
            traits.Add("Genius");
            traits.Add("Good");
            traits.Add("Grumpy");
            traits.Add("Hates the Outdoors");
            traits.Add("Heavy Sleeper");
            traits.Add("Insane");
            traits.Add("Light Sleeper");
            traits.Add("Loner");
            traits.Add("Loves the Outdoors");
            traits.Add("Neurotic");
            traits.Add("Perceptive");
            traits.Add("Slob");
            traits.Add("Virtuoso");

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
            this.simTrait3.Items.Add("None");
            this.simTrait4.Items.Add("None");
            this.simTrait5.Items.Add("None");



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
            }

        }



        private void populatePetAges()
        {
            this.simAge.Items.Clear();
            this.simAge.Items.Add("Adult");
            this.simAge.Items.Add("Elder");
        }

        private void populateHumanAges()
        {
            this.simAge.Items.Clear();
            this.simAge.Items.Add("Toddler");
            this.simAge.Items.Add("Child");
            this.simAge.Items.Add("Teen");
            this.simAge.Items.Add("Young Adult");
            this.simAge.Items.Add("Adult");
            this.simAge.Items.Add("Elder");
        }


        private void simType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.simType.Text)
            {
                case "Dog":
                    // populateDogTraits();
                    populatePetAges();
                    break;
                case "Cat":
                    // populateCatTraits();
                    populatePetAges();
                    break;
                case "Horse":
                    // populateHorseTraits();
                    populatePetAges();
                    break;
                default:
                    populateHumanAges();
                    break;
            }
        }
    }
}
