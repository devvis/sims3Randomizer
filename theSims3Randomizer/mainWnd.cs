using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theSims3Randomizer
{
    public partial class mainWnd : Form
    {
        public mainWnd()
        {
            InitializeComponent();
        }


        private string returnSimTraits(int age)
        {
            // 0: toddler
            // 1: child
            // 2: teen
            // 3: adult
            switch (age)
            {
                case 0:
                    break;

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }


            return "yolo";

        }

        private string returnToddlerTraits()
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
            traits.Add("Genious");
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

            traits.Remove("Genious");



            return "yolo";
        }

        private string returnChildTraits()
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
            traits.Add("Can’t Stand Art");
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
            traits.Add("Photographer’s Eye");
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

            return "yolo";
        }

        private string returnTeenTratis()
        {
            List<string> traits = new List<string>();


            return "yolo";
        }

        private string returnAdultTraits()
        {
            return "yolo";
        }



    }
}
