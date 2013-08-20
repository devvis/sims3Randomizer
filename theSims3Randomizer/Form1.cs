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
            int i = 0;
            int[] traits;
            switch (age)
            {
                case 0:
                    while (i < 1)
                    {
                        traits += returnToddlerTraits();
                    }
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
            return "yolo";
        }

        private string returnChildTraits()
        {
            return "yolo";
        }

        private string returnTeenTratis()
        {
            return "yolo";
        }

        private string returnAdultTraits()
        {
            return "yolo";
        }



    }
}
