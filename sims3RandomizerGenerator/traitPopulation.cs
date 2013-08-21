using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sims3RandomizerGenerator
{
    public partial class mainWnd 
    {
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

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
            this.simTrait4.Items.Add("None");
            this.simTrait5.Items.Add("None");



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
            }

        }

        private void populateTeenTraits()
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

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
            this.simTrait5.Items.Add("None");



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
                this.simTrait4.Items.Add(trait);
            }

        }

        private void populateAdultTraits()
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

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
                this.simTrait4.Items.Add(trait);
                this.simTrait5.Items.Add(trait);
            }

        }

        private void populateDogTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Adventurous");
            traits.Add("Aggressive");
            traits.Add("Clueless");
            traits.Add("Destructive");
            traits.Add("Friendly");
            traits.Add("Genious");
            traits.Add("Hunter");
            traits.Add("Hydrophobic");
            traits.Add("Hyper");
            traits.Add("Independent");
            traits.Add("Lazy");
            traits.Add("Likes Swimming");
            traits.Add("Loyal");
            traits.Add("Neat");
            traits.Add("Noisy");
            traits.Add("Non-Destructive");
            traits.Add("Piggy");
            traits.Add("Playful");
            traits.Add("Proud");
            traits.Add("Quiet");
            traits.Add("Shy");
            traits.Add("Skittish");

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
            this.simTrait4.Items.Add("None");
            this.simTrait5.Items.Add("None");



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
            }

        }

        private void populateCatTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Adventurous");
            traits.Add("Aggressive");
            traits.Add("Clueless");
            traits.Add("Destructive");
            traits.Add("Friendly");
            traits.Add("Genious");
            traits.Add("Hunter");
            traits.Add("Hyper");
            traits.Add("Independent");
            traits.Add("Lazy"); ;
            traits.Add("Neat");
            traits.Add("Noisy");
            traits.Add("Non-Destructive");
            traits.Add("Piggy");
            traits.Add("Playful");
            traits.Add("Proud");
            traits.Add("Quiet");
            traits.Add("Shy");
            traits.Add("Skittish");

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
            this.simTrait4.Items.Add("None");
            this.simTrait5.Items.Add("None");



            foreach (string trait in traits)
            {
                this.simTrait1.Items.Add(trait);
                this.simTrait2.Items.Add(trait);
                this.simTrait3.Items.Add(trait);
            }

        }

        private void populateHorseTraits()
        {
            List<string> traits = new List<string>();
            traits.Add("Aggressive");
            traits.Add("Agile");
            traits.Add("Brave");
            traits.Add("Clueless");
            traits.Add("Fast");
            traits.Add("Friendly");
            traits.Add("Genius");
            traits.Add("Hates Jumping");
            traits.Add("Lazy");
            traits.Add("Neat");
            traits.Add("Nervous");
            traits.Add("Noisy");
            traits.Add("Obedient");
            traits.Add("Ornery");
            traits.Add("Piggy");
            traits.Add("Playful");
            traits.Add("Quiet");
            traits.Add("Shy");
            traits.Add("Untrained");

            this.simTrait1.Items.Clear();
            this.simTrait2.Items.Clear();
            this.simTrait3.Items.Clear();
            this.simTrait4.Items.Clear();
            this.simTrait5.Items.Clear();
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
