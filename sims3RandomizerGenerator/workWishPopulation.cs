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
            jobs.Add("Architectural Design");
            jobs.Add("Art Appraiser");
            jobs.Add("Athletic");
            jobs.Add("Business");
            jobs.Add("Criminal");
            jobs.Add("Culinary");
            jobs.Add("Daycare");
            jobs.Add("Education");
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
            jobs.Add("Medical");
            jobs.Add("Military");
            jobs.Add("Music");
            jobs.Add("Politics");
            jobs.Add("Science");
            jobs.Add("Singer");
            jobs.Add("Sports Agent");
            jobs.Add("Stylist");
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

        private void populateWish()
        {
            List<string> wish = new List<string>();
            // non-career wishes
            wish.Add("Chess Legend");
            wish.Add("Gold Digger");
            wish.Add("Golden Tongue, Golden Fingers");
            wish.Add("Heartbreaker");
            wish.Add("Illustrious Author");
            wish.Add("Jack of All Trades");
            wish.Add("Living in the Lap of Luxury");
            wish.Add("Master of the Arts");
            wish.Add("Perfect Mind, Perfect Body");
            wish.Add("Presenting the Perfect Private Aquarium");
            wish.Add("Professional Author");
            wish.Add("Renaissance Sim");
            wish.Add("Super Popular");
            wish.Add("Surrounded by Family");
            wish.Add("Swimming in Cash");
            wish.Add("The Culinary Librarian");
            wish.Add("The Perfect Garden");
            wish.Add("The Tinkerer");
            wish.Add("Bottomless Nectar Cellar");
            wish.Add("Great Explorer");
            wish.Add("Martial Arts Master");
            wish.Add("Physical Perfection");
            wish.Add("Private Museum");
            wish.Add("Seasoned Traveler");
            wish.Add("Visionary");
            wish.Add("World-Class Gallery");
            wish.Add("Descendant of da Vinci");
            wish.Add("Monster Maker");
            wish.Add("Possession is Nine Tenths of the Law");
            wish.Add("Lifestyle of the Rich and Famous");
            wish.Add("Master Mixologist");
            wish.Add("Master Romancer");
            wish.Add("One Sim Band");
            wish.Add("The Animal Rescuer");
            wish.Add("The Ark Builder");
            wish.Add("The Canine Companion");
            wish.Add("The Cat Herder");
            wish.Add("The Fairy Tale Finder");
            wish.Add("The Jockey");
            wish.Add("The Zoologist");
            wish.Add("Alchemy Artisan");
            wish.Add("Greener Gardens");
            wish.Add("Leader of the Pack");
            wish.Add("Magic Makeover");
            wish.Add("Mystic Healer");
            wish.Add("Turn the Town");
            wish.Add("Zombie Master");
            wish.Add("Blog Artist");
            wish.Add("Major Master");
            wish.Add("Perfect Student");
            wish.Add("Reach Max Influence with All Social Groups");
            wish.Add("Street Credible");
            wish.Add("Deep Sea Diver");
            wish.Add("Grand Explorer");
            wish.Add("Resort Empire");


            // career-wishes
            switch (this.simJob.Text)
            {
                case "Astronaut":
                    wish.Add("Become an Astronaut");
                    break;
                case "Science":
                    wish.Add("Become a Creature-Robot Cross Breeder");
                    wish.Add("Scientific Specialist");
                    break;
                case "Criminal":
                    wish.Add("Become a Master Thief");
                    wish.Add("The Emperor of Evil");
                    break;
                case "Athletic":
                    wish.Add("Become a Superstar Athlete");
                    break;
                case "Culinary":
                    wish.Add("Celebrated Five-Star Chef");
                    break;
                case "Business":
                    wish.Add("CEO of a Mega-Corporation");
                    wish.Add("Scientific Specialist");
                    break;
                case "Law Enforcement":
                    wish.Add("Forensic Specialist: Dynamic DNA Profiler");
                    wish.Add("International Super Spy");
                    break;
                case "Music":
                    wish.Add("Hit Movie Composer");
                    wish.Add("Rock Star");
                    break;
                case "Political":
                    wish.Add("Leader of the Free World");
                    break;
                case "Journalism":
                    wish.Add("Star News Anchor");
                    break;
                case "Medical":
                    wish.Add("World Renowned Surgeon");
                    wish.Add("Scientific Specialist");
                    break;
                case "Stylist":
                    wish.Add("Fashion Phenomenon");
                    break;
                case "Firefighter":
                    wish.Add("Firefighter Super Hero");
                    break;
                case "Architectural Design":
                    wish.Add("Home Design Hotshot");
                    break;
                case "Ghost Hunter":
                    wish.Add("Paranormal Profiteer");
                    break;
                case "Investigator":
                    wish.Add("Pervasive Private Eye");
                    break;
                case "Film":
                    wish.Add("Distinguished Director");
                    wish.Add("Superstar Actor");
                    break;
                case "Acrobat":
                    wish.Add("Master Acrobat");
                    break;
                case "Magician":
                    wish.Add("Master Magician");
                    break;
                case "Singer":
                    wish.Add("Vocal Legend");
                    break;
                case "Fortune Teller":
                    wish.Add("Celebrity Psychic");
                    wish.Add("Master of Mysticism");
                    break;
                case "Lifeguard":
                    wish.Add("Seaside Savior");
                    break;
                default:
                    wish.Add("Become an Astronaut");
                    wish.Add("Become a Creature-Robot Cross Breeder");
                    wish.Add("Become a Master Thief");
                    wish.Add("Become a Superstar Athlete");
                    wish.Add("Celebrated Five-Star Chef");
                    wish.Add("CEO of a Mega-Corporation");
                    wish.Add("Forensic Specialist: Dynamic DNA Profiler");
                    wish.Add("Hit Movie Composer");
                    wish.Add("International Super Spy");
                    wish.Add("Leader of the Free World");
                    wish.Add("Rock Star");
                    wish.Add("Star News Anchor");
                    wish.Add("The Emperor of Evil");
                    wish.Add("World Renowned Surgeon");
                    wish.Add("Fashion Phenomenon");
                    wish.Add("Firefighter Super Hero");
                    wish.Add("Home Design Hotshot");
                    wish.Add("Paranormal Profiteer");
                    wish.Add("Pervasive Private Eye");
                    wish.Add("Distinguished Director");
                    wish.Add("Superstar Actor");
                    wish.Add("Master Acrobat");
                    wish.Add("Master Magician");
                    wish.Add("Vocal Legend");
                    wish.Add("Celebrity Psychic");
                    wish.Add("Master of Mysticism");
                    wish.Add("Scientific Specialist");
                    wish.Add("Seaside Savior");
                    break;
            }


            wish.Sort();

            this.simLifetime.Items.Clear();


            foreach (string w in wish)
            {
                this.simLifetime.Items.Add(w);

            }
        }


    }
}
