using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theSims3Randomizer
{
    public partial class mainWnd
    {
        // I PRESENT TO YOU:
        // LIST-HELL :D
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

        private string[] getDogTraits()
        {
            List<string> dogTraits = new List<string>();

            dogTraits.Add("Adventurous");
            dogTraits.Add("Aggressive");
            dogTraits.Add("Clueless");
            dogTraits.Add("Destructive");
            dogTraits.Add("Friendly");
            dogTraits.Add("Genious");
            dogTraits.Add("Hunter");
            dogTraits.Add("Hydrophobic");
            dogTraits.Add("Hyper");
            dogTraits.Add("Independent");
            dogTraits.Add("Lazy");
            dogTraits.Add("Likes Swimming");
            dogTraits.Add("Loyal");
            dogTraits.Add("Neat");
            dogTraits.Add("Noisy");
            dogTraits.Add("Non-Destructive");
            dogTraits.Add("Piggy");
            dogTraits.Add("Playful");
            dogTraits.Add("Proud");
            dogTraits.Add("Quiet");
            dogTraits.Add("Shy");
            dogTraits.Add("Skittish");

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = dogTraits.OrderBy(x => rnd.Next()).Take(3);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }

        private string[] getCatTraits()
        {
            List<string> catTraits = new List<string>();

            catTraits.Add("Adventurous");
            catTraits.Add("Aggressive");
            catTraits.Add("Clueless");
            catTraits.Add("Destructive");
            catTraits.Add("Friendly");
            catTraits.Add("Genious");
            catTraits.Add("Hunter");
            catTraits.Add("Hyper");
            catTraits.Add("Independent");
            catTraits.Add("Lazy"); ;
            catTraits.Add("Neat");
            catTraits.Add("Noisy");
            catTraits.Add("Non-Destructive");
            catTraits.Add("Piggy");
            catTraits.Add("Playful");
            catTraits.Add("Proud");
            catTraits.Add("Quiet");
            catTraits.Add("Shy");
            catTraits.Add("Skittish");

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = catTraits.OrderBy(x => rnd.Next()).Take(3);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }

        private string[] getHorseTraits()
        {
            List<string> horseTraits = new List<string>();

            horseTraits.Add("Aggressive");
            horseTraits.Add("Agile");
            horseTraits.Add("Brave");
            horseTraits.Add("Clueless");
            horseTraits.Add("Fast");
            horseTraits.Add("Friendly");
            horseTraits.Add("Genius");
            horseTraits.Add("Hates Jumping");
            horseTraits.Add("Lazy");
            horseTraits.Add("Neat");
            horseTraits.Add("Nervous");
            horseTraits.Add("Noisy");
            horseTraits.Add("Obedient");
            horseTraits.Add("Ornery");
            horseTraits.Add("Piggy");
            horseTraits.Add("Playful");
            horseTraits.Add("Quiet");
            horseTraits.Add("Shy");
            horseTraits.Add("Untrained");

            IEnumerable<string> selectedTraits;
            string[] returnTraits;
            selectedTraits = horseTraits.OrderBy(x => rnd.Next()).Take(3);
            returnTraits = selectedTraits.ToArray();

            return returnTraits;
        }
    }

}
