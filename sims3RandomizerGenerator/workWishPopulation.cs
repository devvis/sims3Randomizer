using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sims3RandomizerGenerator
{
    public partial class mainWnd
    {
        private void populateTeenJob()
        {
            List<string> jobs = new List<string>();
            //Part-time jobs
            jobs.Add("Bookstore Clerk");
            jobs.Add("Film");
            jobs.Add("Grocery Store Clerk");
            jobs.Add("Mausoleum Clerk");
            jobs.Add("Receptionist");
            jobs.Add("Spa Specialist");
            jobs.Add("Test Subject");
            //Self-employed careers
            jobs.Add("Alchemist");
            jobs.Add("Angler");
            jobs.Add("Band");
            jobs.Add("Gardener");
            jobs.Add("Horseman");
            jobs.Add("Inventor");
            jobs.Add("Nectar Maker");
            jobs.Add("Painter");
            jobs.Add("Photographer");
            jobs.Add("Scuba Diver");
            jobs.Add("Sculptor");
            jobs.Add("Writer");
            //No job
            jobs.Add("None");

            this.simJob.Items.Clear();


            foreach (string job in jobs)
            {
                this.simJob.Items.Add(job);

            }

        }

        private void populateAdultJob()
        {
            List<string> jobs = new List<string>();
            //Jobs and professions
            jobs.Add("Acrobat");
            jobs.Add("Architecture");
            jobs.Add("Art Appraiser");
            jobs.Add("Athletic");
            jobs.Add("Business");
            jobs.Add("Criminal");
            jobs.Add("Culinary");
            jobs.Add("Culinary");
            jobs.Add("Education");
            jobs.Add("Fashion");
            jobs.Add("Film");
            jobs.Add("Firefighter");
            jobs.Add("Fortune Teller");
            jobs.Add("Game Development");
            jobs.Add("Ghost Hunter");
            jobs.Add("Investigator");
            jobs.Add("Journalism");
            jobs.Add("Law Enforcement");
            jobs.Add("Lifeguard");
            jobs.Add("Magician");
            jobs.Add("Medicine");
            jobs.Add("Military");
            jobs.Add("Music");
            jobs.Add("Politics");
            jobs.Add("Science");
            jobs.Add("Singer");
            jobs.Add("Sports Agent");
            //Part-time jobs
            jobs.Add("Bookstore Clerk");
            jobs.Add("Film");
            jobs.Add("Grocery Store Clerk");
            jobs.Add("Mausoleum Clerk");
            jobs.Add("Receptionist");
            jobs.Add("Spa Specialist");
            jobs.Add("Test Subject");
            //Self-employed careers
            jobs.Add("Alchemist");
            jobs.Add("Angler");
            jobs.Add("Band");
            jobs.Add("Gardener");
            jobs.Add("Horseman");
            jobs.Add("Inventor");
            jobs.Add("Nectar Maker");
            jobs.Add("Painter");
            jobs.Add("Photographer");
            jobs.Add("Scuba Diver");
            jobs.Add("Sculptor");
            jobs.Add("Writer");
            //No job
            jobs.Add("None");

            this.simJob.Items.Clear();


            foreach (string job in jobs)
            {
                this.simJob.Items.Add(job);

            }

        }

        private void populateChildJob()
        {
            this.simJob.Items.Clear();
            this.simJob.Items.Add("None");
        }


    }
}
