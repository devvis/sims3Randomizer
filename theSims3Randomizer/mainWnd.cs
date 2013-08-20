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
            //simJob = getJob(simAge);

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
            this.lifespan.Text = lifespan;
        }


        private void generateSims()
        {
            int numOfSims, i = 0;
            string simType, simWish, simAge, simGender;
            string[] simTraits;

            numOfSims = rnd.Next(2, 9);
            while (i <= numOfSims)
            {
                simType = getSimType(false);
                simAge = getAgeByType(simType, false);
                simWish = getLifetimeWish(simType);
                simTraits = getSimTraits(simAge, simType);
                simGender = getSimGender();
                populateLabels(i, simType, simAge, simWish, simTraits, simGender);
                i++;
            }
        }

        private void populateLabels(int num, string simType, string simAge, string simWish, string[] simTraits, string simGender)
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
                    break;

                default:

                    break;
            }
        }



/*
        private void generateSim()
        {
            //int numOfSims = rnd.Next(1, 8);
            int numOfSims = rnd.Next(1, 1);
            int i = 1;

            string simType, simAge;

            while (i <= numOfSims)
            {
                if (i == 1)
                {
                    getAgeByType("Human", true); // we need the first sim to always be a grown-up human
                }
                else
                {
                    getAgeByType(simType, false);
                }
            }


        }
*/



        private string[] getSimTraits(string age, string type)
        {
            switch (type)
            {
                case "Dog":
                case "Cat":
                case "Horse":
                    return getToddlerTraits();
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
        /*
        private string getJob(string age)
        {
            switch (age)
            {

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

        private string getJob()
        {
            List<string> SimJob = new List<string>();

        }
        */

        private string getLifetimeWish(string type)
        {
            List<string> lifetimeWishes = new List<string>();
            switch (type)
            {
                case "Dog":
                case "Cat":
                case "Horse":
                    lifetimeWishes.Add("None");
                    break;
                default:
                    lifetimeWishes.Add("Alchemy Artisan");
                    lifetimeWishes.Add("Become a Creature-Robot Cross Breeder");
                    lifetimeWishes.Add("Become a Master Thief");
                    lifetimeWishes.Add("Become an Astronaut");
                    lifetimeWishes.Add("Become a Superstar Athlete");
                    lifetimeWishes.Add("Blog Artist");
                    lifetimeWishes.Add("Bottomless Nectar Cellar");
                    lifetimeWishes.Add("Celebrated Five-Star Chef");
                    lifetimeWishes.Add("Celebrity Psychic");
                    lifetimeWishes.Add("CEO of a Mega-Corporation");
                    lifetimeWishes.Add("Chess Legend");
                    lifetimeWishes.Add("Deep Sea Diver");
                    lifetimeWishes.Add("Descendant of Da Vinci");
                    lifetimeWishes.Add("Distinguished Director");
                    lifetimeWishes.Add("Emperor of Evil");
                    lifetimeWishes.Add("Fashion Phenomenon");
                    lifetimeWishes.Add("Firefighter Super Hero");
                    lifetimeWishes.Add("Forensics Specialist - Dynamic DNA Profiler");
                    lifetimeWishes.Add("Gold Digger");
                    lifetimeWishes.Add("Golden Tongue/Golden Fingers");
                    lifetimeWishes.Add("Grand Explorer");
                    lifetimeWishes.Add("Great Explorer");
                    lifetimeWishes.Add("Greener Gardens");
                    lifetimeWishes.Add("Heartbreaker");
                    lifetimeWishes.Add("Hit Movie Composer");
                    lifetimeWishes.Add("Home Design Hotshot");
                    lifetimeWishes.Add("Illustrious Author");
                    lifetimeWishes.Add("International Super Spy");
                    lifetimeWishes.Add("Jack of All Trades");
                    lifetimeWishes.Add("Leader of the Free World");
                    lifetimeWishes.Add("Leader of the Pack");
                    lifetimeWishes.Add("Lifestyle of the Rich and Famous");
                    lifetimeWishes.Add("Living in the Lap of Luxury");
                    lifetimeWishes.Add("Magic Makeover");
                    lifetimeWishes.Add("Major Master");
                    lifetimeWishes.Add("Martial Arts Master");
                    lifetimeWishes.Add("Master Acrobat");
                    lifetimeWishes.Add("Master of the Arts");
                    lifetimeWishes.Add("Master of Mysticism");
                    lifetimeWishes.Add("Master Magician");
                    lifetimeWishes.Add("Master Mixologist");
                    lifetimeWishes.Add("Master Romancer");
                    lifetimeWishes.Add("Monster Maker");
                    lifetimeWishes.Add("Mystic Healer");
                    lifetimeWishes.Add("One Sim Band");
                    lifetimeWishes.Add("Paranormal Profiteer");
                    lifetimeWishes.Add("Perfect Mind, Perfect Body");
                    lifetimeWishes.Add("Perfect Student");
                    lifetimeWishes.Add("Pervasive Private Eye");
                    lifetimeWishes.Add("Physical Perfection");
                    lifetimeWishes.Add("Presenting the Perfect Private Aquarium");
                    lifetimeWishes.Add("Possession is Nine Tenths of the Law");
                    lifetimeWishes.Add("Private Museum");
                    lifetimeWishes.Add("Professional Author");
                    lifetimeWishes.Add("Reach Max Influence with all Social Groups");
                    lifetimeWishes.Add("Renaissance Sim");
                    lifetimeWishes.Add("Resort Empire");
                    lifetimeWishes.Add("Rock Star");
                    lifetimeWishes.Add("Scientific Specialist");
                    lifetimeWishes.Add("Seaside Savior");
                    lifetimeWishes.Add("Seasoned Traveler");
                    lifetimeWishes.Add("Star News Anchor");
                    lifetimeWishes.Add("Street Credible");
                    lifetimeWishes.Add("Super Popular");
                    lifetimeWishes.Add("Superstar Actor");
                    lifetimeWishes.Add("Surronded by Family");
                    lifetimeWishes.Add("Swimming in Cash");
                    lifetimeWishes.Add("The Animal Rescuer");
                    lifetimeWishes.Add("The Ark Builder");
                    lifetimeWishes.Add("The Canine Companion");
                    lifetimeWishes.Add("The Cat Herder");
                    lifetimeWishes.Add("The Culinary Librarian");
                    lifetimeWishes.Add("The Fairy Tale Finder");
                    lifetimeWishes.Add("The Jockey");
                    lifetimeWishes.Add("The Zoologist");
                    lifetimeWishes.Add("The Perfect Garden");
                    lifetimeWishes.Add("The Tinkerer");
                    lifetimeWishes.Add("Turn the Town");
                    lifetimeWishes.Add("Visionary");
                    lifetimeWishes.Add("Vocal Legend");
                    lifetimeWishes.Add("World Class Gallery");
                    lifetimeWishes.Add("World-Reknowned Surgeon");
                    lifetimeWishes.Add("Zombie Master");
                    break;
            }
                    int r = rnd.Next(lifetimeWishes.Count);

            return lifetimeWishes[r];
        }

        private string[] getToddlerTraits()
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

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = traits.OrderBy(x => rnd.Next()).Take(2);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }

        private string[] getChildTraits()
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

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = traits.OrderBy(x => rnd.Next()).Take(3);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }

        private string[] getTeenTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Absent-Minded");
            traits.Add("Adventurous");
            traits.Add("Ambitious");
            traits.Add("Angler");
            traits.Add("Artistic");
            traits.Add("Athletic");
            traits.Add("Bookworm");
            traits.Add("Born Salesman");
            traits.Add("Brave");
            traits.Add("Can't Stand Art");
            traits.Add("Charismatic");
            traits.Add("Childish");
            traits.Add("Clumsy");
            traits.Add("Commitment Issues");
            traits.Add("Computer Whiz");
            traits.Add("Couch Potato");
            traits.Add("Coward");
            traits.Add("Daredevil");
            traits.Add("Disciplined");
            traits.Add("Dislikes Children");
            traits.Add("Dramatic");
            traits.Add("Easily Impressed");
            traits.Add("Eccentric");
            traits.Add("Eco Friendly");
            traits.Add("Evil");
            traits.Add("Excitable");
            traits.Add("Family Oriented");
            traits.Add("Flirty");
            traits.Add("Friendly");
            traits.Add("Frugal");
            traits.Add("Genius");
            traits.Add("Good");
            traits.Add("Good Sense of Humor");
            traits.Add("Great Kisser");
            traits.Add("Green Thumb");
            traits.Add("Grumpy");
            traits.Add("Handy");
            traits.Add("Hates the Outdoors");
            traits.Add("Heavy Sleeper");
            traits.Add("Hopeless Romantic");
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
            traits.Add("Natural Cook");
            traits.Add("Neat");
            traits.Add("Neurotic");
            traits.Add("Never Nude");
            traits.Add("No Sense of Humor");
            traits.Add("Nurturing");
            traits.Add("Over Emotional");
            traits.Add("Party Animal");
            traits.Add("Perceptive");
            traits.Add("Perfectionist");
            traits.Add("Photographer's Eye");
            traits.Add("Rebellious");
            traits.Add("Savvy Sculptor");
            traits.Add("Schmoozer");
            traits.Add("Shy");
            traits.Add("Slob");
            traits.Add("Snob");
            traits.Add("Star Quality");
            traits.Add("Technophobe");
            traits.Add("Unflirty");
            traits.Add("Unlucky");
            traits.Add("Vegetarian");
            traits.Add("Vehicle Enthusiast");
            traits.Add("Virtuoso");
            traits.Add("Workaholic");

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = traits.OrderBy(x => rnd.Next()).Take(4);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }

        private string[] getAdultTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Absent-Minded");
            traits.Add("Adventurous");
            traits.Add("Ambitious");
            traits.Add("Angler");
            traits.Add("Artistic");
            traits.Add("Athletic");
            traits.Add("Bookworm");
            traits.Add("Born Salesman");
            traits.Add("Brave");
            traits.Add("Can't Stand Art");
            traits.Add("Charismatic");
            traits.Add("Childish");
            traits.Add("Clumsy");
            traits.Add("Commitment Issues");
            traits.Add("Computer Whiz");
            traits.Add("Couch Potato");
            traits.Add("Coward");
            traits.Add("Daredevil");
            traits.Add("Disciplined");
            traits.Add("Dislikes Children");
            traits.Add("Dramatic");
            traits.Add("Easily Impressed");
            traits.Add("Eccentric");
            traits.Add("Eco Friendly");
            traits.Add("Evil");
            traits.Add("Excitable");
            traits.Add("Family Oriented");
            traits.Add("Flirty");
            traits.Add("Friendly");
            traits.Add("Frugal");
            traits.Add("Genius");
            traits.Add("Good");
            traits.Add("Good Sense of Humor");
            traits.Add("Great Kisser");
            traits.Add("Green Thumb");
            traits.Add("Grumpy");
            traits.Add("Handy");
            traits.Add("Hates the Outdoors");
            traits.Add("Heavy Sleeper");
            traits.Add("Hopeless Romantic");
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
            traits.Add("Natural Cook");
            traits.Add("Neat");
            traits.Add("Neurotic");
            traits.Add("Never Nude");
            traits.Add("No Sense of Humor");
            traits.Add("Nurturing");
            traits.Add("Over Emotional");
            traits.Add("Party Animal");
            traits.Add("Perceptive");
            traits.Add("Perfectionist");
            traits.Add("Photographer's Eye");
            traits.Add("Rebellious");
            traits.Add("Savvy Sculptor");
            traits.Add("Schmoozer");
            traits.Add("Shy");
            traits.Add("Slob");
            traits.Add("Snob");
            traits.Add("Star Quality");
            traits.Add("Technophobe");
            traits.Add("Unflirty");
            traits.Add("Unlucky");
            traits.Add("Vegetarian");
            traits.Add("Vehicle Enthusiast");
            traits.Add("Virtuoso");
            traits.Add("Workaholic");

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = traits.OrderBy(x => rnd.Next()).Take(5);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
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
            // 5: zombie
            // 6: dog
            // 7: cat
            // 8: horse
            int r;
            if (first == true)
            {
                // we want to make sure that our first sim is always some kind of "human-like"
                r = rnd.Next(0, 6);
            }
            else
            {
                r = rnd.Next(0, 9);
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
                    return "Zombie";
                case 6:
                    return "Dog";
                case 7:
                    return "Cat";
                case 8:
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
            //sim2Static.Hide();
            //sim3Static.Hide();
            //sim4Static.Hide();
            //sim5Static.Hide();
            //sim6Static.Hide();
            //sim7Static.Hide();
            //sim8Static.Hide();
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
        }

    }
}
