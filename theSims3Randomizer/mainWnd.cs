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
            resetLabels();
        }

        private static Random rnd = new Random();




        private void generateFirstSim()
        {
            string simType, simWish, simAge, simGender, lifespan, simJob;
            string[] simTraits;
            int i = 1;

            simType = getSimType(true);
            simAge = getAgeByType(simType, true);
            simWish = getLifetimeWish(simType);
            simTraits = getSimTraits(simAge, simType);
            simGender = getSimGender();
            lifespan = getLifespan();
            simJob = getJob(simAge);

            this.sim1Gender.Text = simGender;
            this.sim1Lifetime.Text = simWish;
            this.sim1Type.Text = simType;

            foreach (string trait in simTraits)
            {
                switch (i)
                {
                    case 1:
                        this.sim1Trait1.Text = trait;
                        i++;
                        break;
                    case 2:
                        this.sim1Trait2.Text = trait;
                        i++;
                        break;
                    case 3:
                        this.sim1Trait3.Text = trait;
                        i++;
                        break;
                    case 4:
                        this.sim1Trait4.Text = trait;
                        i++;
                        break;
                    case 5:
                        this.sim1Trait5.Text = trait;
                        i++;
                        break;
                    default:
                        break;
                }
            }

            this.sim1Age.Text = simAge;
            this.sim1Career.Text = simJob;
            this.lifespan.Text = lifespan;
        }


        private void generateSims()
        {
            int numOfSims, i = 0;
            string simType, simWish, simAge, simGender, simJob;
            string[] simTraits;

            numOfSims = rnd.Next(2, 9);
            while (i <= numOfSims)
            {
                simType = getSimType(false);
                simAge = getAgeByType(simType, false);
                simWish = getLifetimeWish(simType);
                simTraits = getSimTraits(simAge, simType);
                simGender = getSimGender();
                if (simType == "Horse" || simType == "Dog" || simType == "Cat")
                {
                    simJob = "None";
                }

                else
                {
                    simJob = getJob(simAge);
                }
                populateLabels(i, simType, simAge, simWish, simTraits, simGender, simJob);
                i++;
            }
        }

        private void populateLabels(int num, string simType, string simAge, string simWish, string[] simTraits, string simGender, string simJob)
        {
            int i = 1;
            switch(num)
            {
                case 2:
                    this.sim2Gender.Text = simGender;
                    this.sim2Lifetime.Text = simWish;
                    this.sim2Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim2Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim2Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim2Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim2Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim2Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim2Age.Text = simAge;
                    this.sim2Career.Text = simJob;
                    break;
                case 3:
                    this.sim3Gender.Text = simGender;
                    this.sim3Lifetime.Text = simWish;
                    this.sim3Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim3Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim3Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim3Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim3Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim3Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim3Age.Text = simAge;
                    this.sim3Career.Text = simJob;
                    break;

                case 4:
                    this.sim4Gender.Text = simGender;
                    this.sim4Lifetime.Text = simWish;
                    this.sim4Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim4Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim4Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim4Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim4Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim4Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim4Age.Text = simAge;
                    this.sim4Career.Text = simJob;
                    break;

                case 5:
                    this.sim5Gender.Text = simGender;
                    this.sim5Lifetime.Text = simWish;
                    this.sim5Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim5Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim5Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim5Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim5Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim5Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim5Age.Text = simAge;
                    this.sim5Career.Text = simJob;
                    break;

                case 6:
                    this.sim6Gender.Text = simGender;
                    this.sim6Lifetime.Text = simWish;
                    this.sim6Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim6Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim6Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim6Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim6Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim6Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim6Age.Text = simAge;
                    this.sim6Career.Text = simJob;
                    break;

                case 7:
                    this.sim7Gender.Text = simGender;
                    this.sim7Lifetime.Text = simWish;
                    this.sim7Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim7Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim7Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim7Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim7Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim7Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim7Age.Text = simAge;
                    this.sim7Career.Text = simJob;
                    break;

                case 8:
                    this.sim8Gender.Text = simGender;
                    this.sim8Lifetime.Text = simWish;
                    this.sim8Type.Text = simType;

                    foreach (string trait in simTraits)
                    {
                        switch (i)
                        {
                            case 1:
                                this.sim8Trait1.Text = trait;
                                i++;
                                break;
                            case 2:
                                this.sim8Trait2.Text = trait;
                                i++;
                                break;
                            case 3:
                                this.sim8Trait3.Text = trait;
                                i++;
                                break;
                            case 4:
                                this.sim8Trait4.Text = trait;
                                i++;
                                break;
                            case 5:
                                this.sim8Trait5.Text = trait;
                                i++;
                                break;
                            default:
                                break;
                        }
                    }

                    this.sim8Age.Text = simAge;
                    this.sim8Career.Text = simJob;
                    break;

                default:

                    break;
            }
        }


        private string[] getSimTraits(string age, string type)
        {
            switch (type)
            {
                case "Dog":
                    return getDogTraits();
                case "Cat":
                    return getCatTraits();
                case "Horse":
                    return getHorseTraits();
                default:
                    switch (age)
                    {
                        case "Toddler":
                            return getToddlerTraits();

                        case "Child":
                            return getChildTraits();

                        case "Teen":
                            return getTeenTraits();

                        case "Young Adult":
                        case "Adult":
                        case "Elder":
                            return getAdultTraits();
                        default:
                            throw new System.ArgumentException("Index is out of range, please die!");
                    }
            }
        }

        private string getJob(string age)
        {
            switch (age)
            {

                case "Toddler":
                case "Child":
                    return "None";

                case "Teen":
                    return getTeenJob();

                case "Young Adult":
                case "Adult":
                case "Elder":
                    return getAdultJob();
                default:
                    throw new System.ArgumentException("Index is out of range, please die!");
            }
        }

        private string getTeenJob()
        {
            List<string> teenJob = new List<string>();
            //Part-time jobs
            teenJob.Add("Bookstore Clerk");
            teenJob.Add("Film");
            teenJob.Add("Grocery Store Clerk");
            teenJob.Add("Mausoleum Clerk");
            teenJob.Add("Receptionist");
            teenJob.Add("Spa Specialist");
            teenJob.Add("Test Subject");
            //Self-employed careers
            teenJob.Add("Alchemist");
            teenJob.Add("Angler");
            teenJob.Add("Band");
            teenJob.Add("Gardener");
            teenJob.Add("Horseman");
            teenJob.Add("Inventor");
            teenJob.Add("Nectar Maker");
            teenJob.Add("Painter");
            teenJob.Add("Photographer");
            teenJob.Add("Scuba Diver");
            teenJob.Add("Sculptor");
            teenJob.Add("Writer");
            //No job
            teenJob.Add("None");

            int r = rnd.Next(teenJob.Count);

        return teenJob[r];
        
    }

        private string getAdultJob()
        {
            List<string> adultJob = new List<string>();
            //Jobs and professions
            adultJob.Add("Acrobat");
            adultJob.Add("Architecture");
            adultJob.Add("Art Appraiser");
            adultJob.Add("Athletic");
            adultJob.Add("Business");
            adultJob.Add("Criminal");
            adultJob.Add("Culinary");
            adultJob.Add("Culinary");
            adultJob.Add("Education");
            adultJob.Add("Stylist");
            adultJob.Add("Film");
            adultJob.Add("Firefighter");
            adultJob.Add("Fortune Teller");
            adultJob.Add("Game Development");
            adultJob.Add("Ghost Hunter");
            adultJob.Add("Investigator");
            adultJob.Add("Journalism");
            adultJob.Add("Law Enforcement");
            adultJob.Add("Lifeguard");
            adultJob.Add("Magician");
            adultJob.Add("Medicine");
            adultJob.Add("Military");
            adultJob.Add("Music");
            adultJob.Add("Politics");
            adultJob.Add("Science");
            adultJob.Add("Singer");
            adultJob.Add("Sports Agent");
            //Part-time jobs
            adultJob.Add("Bookstore Clerk");
            adultJob.Add("Film");
            adultJob.Add("Grocery Store Clerk");
            adultJob.Add("Mausoleum Clerk");
            adultJob.Add("Receptionist");
            adultJob.Add("Spa Specialist");
            adultJob.Add("Test Subject");
            //Self-employed careers
            adultJob.Add("Alchemist");
            adultJob.Add("Angler");
            adultJob.Add("Band");
            adultJob.Add("Gardener");
            adultJob.Add("Horseman");
            adultJob.Add("Inventor");
            adultJob.Add("Nectar Maker");
            adultJob.Add("Painter");
            adultJob.Add("Photographer");
            adultJob.Add("Scuba Diver");
            adultJob.Add("Sculptor");
            adultJob.Add("Writer");
            //No job
            adultJob.Add("None");

            int r = rnd.Next(adultJob.Count);

            return adultJob[r];
        }


        private string getLifespan()
        {
            int span = rnd.Next(1, 5);
            switch (span)
            {
                case 1:
                    return "Short";
                case 2:
                    return "Medium";
                case 3:
                    return "Normal";
                case 4:
                    return "Long";
                default:
                    throw new IndexOutOfRangeException("How is this even possible. Fuck logic.");
            }
        }

        private string getSimGender()
        {
            int r = rnd.Next(1, 3);

            if (r == 1)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private string getSimType(bool first)
        {
            // 0: human
            // 1: fairy
            // 2: werewolf
            // 3: witch
            // 4: vampire
            // 5: dog
            // 6: cat
            // 7: horse
            int r;
            if (first == true)
            {
                // we want to make sure that our first sim is always some kind of "human-like"
                r = rnd.Next(0, 5);
            }
            else
            {
                r = rnd.Next(0, 8);
            }
            switch (r)
            {
                case 0:
                    return "Human";
                case 1:
                    return "Fairy";
                case 2:
                    return "Werewolf";
                case 3:
                    return "Witch";
                case 4:
                    return "Vampire";
                case 5:
                    return "Dog";
                case 6:
                    return "Cat";
                case 7:
                    return "Horse";
                default:
                    throw new IndexOutOfRangeException("How is this even possible. Fuck logic.");
            }
        }

        private string getAgeByType(string type, bool first)
        {
            // 0: toddler / adult pet
            // 1: child / elder pet
            // 2: teen
            // 3: young-adult
            // 4: adult
            // 5: elder
            int r;
            switch (type)
            {
                case "Dog":
                case "Cat":
                case "Horse":
                    r = rnd.Next(0, 2);
                    if (r == 0)
                    {
                        return "Adult";
                    }
                    else
                    {
                        return "Elder";
                    }

                default:
                    if (first == true)
                    {
                        r = rnd.Next(3, 6);
                    }
                    else
                    {
                        r = rnd.Next(0, 6);
                    }
                    switch (r)
                    {
                        case 0:
                            return "Toddler";
                        case 1:
                            return "Child";
                        case 2:
                            return "Teen";
                        case 3:
                            return "Young Adult";
                        case 4:
                            return "Adult";
                        case 5:
                            return "Elder";
                        default:
                            throw new IndexOutOfRangeException("How is this even possible. Fuck logic.");
                    }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            resetLabels();
            generateFirstSim();
            generateSims();
        }


        private void resetLabels()
        {
            this.sim1Age.Text = "None";
            this.sim2Age.Text = "None";
            this.sim3Age.Text = "None";
            this.sim4Age.Text = "None";
            this.sim5Age.Text = "None";
            this.sim6Age.Text = "None";
            this.sim7Age.Text = "None";
            this.sim8Age.Text = "None";

            this.sim1Career.Text = "None";
            this.sim2Career.Text = "None";
            this.sim3Career.Text = "None";
            this.sim4Career.Text = "None";
            this.sim5Career.Text = "None";
            this.sim6Career.Text = "None";
            this.sim7Career.Text = "None";
            this.sim8Career.Text = "None";

            this.sim1Gender.Text = "None";
            this.sim2Gender.Text = "None";
            this.sim3Gender.Text = "None";
            this.sim4Gender.Text = "None";
            this.sim5Gender.Text = "None";
            this.sim6Gender.Text = "None";
            this.sim7Gender.Text = "None";
            this.sim8Gender.Text = "None";

            this.sim1Lifetime.Text = "None";
            this.sim2Lifetime.Text = "None";
            this.sim3Lifetime.Text = "None";
            this.sim4Lifetime.Text = "None";
            this.sim5Lifetime.Text = "None";
            this.sim6Lifetime.Text = "None";
            this.sim7Lifetime.Text = "None";
            this.sim8Lifetime.Text = "None";

            this.sim1Trait1.Text = "None";
            this.sim2Trait1.Text = "None";
            this.sim3Trait1.Text = "None";
            this.sim4Trait1.Text = "None";
            this.sim5Trait1.Text = "None";
            this.sim6Trait1.Text = "None";
            this.sim7Trait1.Text = "None";
            this.sim8Trait1.Text = "None";

            this.sim1Trait2.Text = "None";
            this.sim2Trait2.Text = "None";
            this.sim3Trait2.Text = "None";
            this.sim4Trait2.Text = "None";
            this.sim5Trait2.Text = "None";
            this.sim6Trait2.Text = "None";
            this.sim7Trait2.Text = "None";
            this.sim8Trait2.Text = "None";

            this.sim1Trait3.Text = "None";
            this.sim2Trait3.Text = "None";
            this.sim3Trait3.Text = "None";
            this.sim4Trait3.Text = "None";
            this.sim5Trait3.Text = "None";
            this.sim6Trait3.Text = "None";
            this.sim7Trait3.Text = "None";
            this.sim8Trait3.Text = "None";

            this.sim1Trait4.Text = "None";
            this.sim2Trait4.Text = "None";
            this.sim3Trait4.Text = "None";
            this.sim4Trait4.Text = "None";
            this.sim5Trait4.Text = "None";
            this.sim6Trait4.Text = "None";
            this.sim7Trait4.Text = "None";
            this.sim8Trait4.Text = "None";

            this.sim1Trait5.Text = "None";
            this.sim2Trait5.Text = "None";
            this.sim3Trait5.Text = "None";
            this.sim4Trait5.Text = "None";
            this.sim5Trait5.Text = "None";
            this.sim6Trait5.Text = "None";
            this.sim7Trait5.Text = "None";
            this.sim8Trait5.Text = "None";

            this.sim1Type.Text = "None";
            this.sim2Type.Text = "None";
            this.sim3Type.Text = "None";
            this.sim4Type.Text = "None";
            this.sim5Type.Text = "None";
            this.sim6Type.Text = "None";
            this.sim7Type.Text = "None";
            this.sim8Type.Text = "None";

            this.lifespan.Text = "None";
        }

    }
}
