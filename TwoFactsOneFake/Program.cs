using System;
using System.Collections.Generic;
using System.IO;

namespace TwoFactsOneFake
{
    class Program
    {
        private static Random rnd = new Random();
        private static int sol = -1;
        private static string playAgain = "Y";
        static List<string> facts = new List<string>();
        static List<string> fakes = new List<string>();
        private static int score = 0;
        private static int errs = 0;
        static List<int> blacklistFact = new List<int>();
        static List<int> blacklistFake = new List<int>();

        static void Main(string[] args)
        {
            //string factSelect = @"C:\Users\siels\source\repos\TwoFactsOneFake\facts.txt";
            //string fakeSelect = @"C:\Users\siels\source\repos\TwoFactsOneFake\fakes.txt";

            facts.Add("The arcade game \"Donkey Kong\" (1986), where the character later known as Mario made his debut, was originally meant to be a Popeye game, but Nintendo couldn't get the license.");
            facts.Add("The gene for six fingers is dominant. That means if you have a parent with six fingers on each hand and a parent with five fingers, chances are you'll have six fingers.");
            facts.Add("Bolivia has two capitals.");
            facts.Add("If you reach 100 years old in Great Britain, the king sends you a letter.");
            facts.Add("Blue raspberries aren't real, it's an artificial flavor invented in a lab.");
            facts.Add("It rains diamonds in Uranus and Neptune.");
            facts.Add("You can die from drinking too much water. It's called water poisoning.");
            facts.Add("It's illegal to own a pet turtle in Reykjavík.");
            facts.Add("Teeth are as unique as fingerprints.");
            facts.Add("Fish can cough.");
            facts.Add("Your fingernails grow faster when you're cold.");
            facts.Add("Both zebras and tigers have black skin, it's their stripes that are colored.");
            facts.Add("Snails can nap for up to three years.");
            facts.Add("Every 60 seconds in Africa, a minute passes.");
            facts.Add("Cows can walk up stairs, but not down them.");
            facts.Add("The shortest war in history lasted 38 minutes.");
            facts.Add("The world’s first animated feature film was made in Argentina.");
            facts.Add("German chocolate cake was invented in Texas.");
            facts.Add("The Philippines consists of over 7,500 islands.");
            facts.Add("A one-way trip on the Trans-Siberian Railway involves crossing about 4,000 bridges.");
            facts.Add("You can hold your breath for the rest of your life.");
            facts.Add("If your shirt isn't tucked into your pants, your pants are tucked into your shirt.");
            facts.Add("The average person spends two weeks of their life waiting at traffic lights.");
            facts.Add("You pump over 200 million liters of blood in your life.");
            facts.Add("Japan has one vending machine for every 40 people.");
            facts.Add("California considers wasps to be fish.");
            facts.Add("Until 1913, parents or guardians could mail their children to another adult through the post office.");
            facts.Add("The longest English word is 189,819 letters long.");
            facts.Add("Some octopus species lay 55,000 eggs at a time.");
            facts.Add("That tiny pocket in jeans was designed to store pocket watches.");
            facts.Add("No number before 1,000 contains the letter A when spelled out.");
            facts.Add("Movie trailers originally played after the movie.");
            facts.Add("Bees can fly higher than Mount Everest.");
            facts.Add("It's illegal in Alabama to walk down the street with an ice cream cone in your pocket.");
            facts.Add("When you eat pineapples, the pineapple eats you back.");
            facts.Add("On average, the city that wins the Super Bowl has a reduced rate of cardiac arrest than usual, and the losing city has a higher one.");
            facts.Add("You are more likely to be born on your birthday than on any other day of the year.");
            facts.Add("There are around 2,000 thunderstorms on Earth every minute.");
            facts.Add("Sloths are faster on water than on land.");
            facts.Add("Venus is the only planet that spins clockwise.");
            facts.Add("Children are actually edible.");
            facts.Add("Monkeys don't eat bananas in the wild.");
            facts.Add("The Sahara Desert used to be a rainforest.");
            facts.Add("Neighborhoods with more dogs have less crime.");
            facts.Add("Two of the voice actors for Mickey and Minnie Mouse were married in real life.");
            facts.Add("The Moai heads on Easter Island have bodies buried underground.");
            facts.Add("You're more likely to get struck by lightning than to win the lottery.");
            facts.Add("You're more likely to be killed by a vending machine than by a shark.");
            facts.Add("In Japan, eating KFC is a Christmas tradidion, because they think it's a tradition in America.");
            facts.Add("The country that eats the most ice cream per person is New Zealand.");
            facts.Add("Treadmills were originally invented as torture devices.");
            facts.Add("Hair grows faster when you're pregnant.");
            facts.Add("Mosquitos are more attracted to you if you eat lots of bananas.");
            facts.Add("The human body is 70% water.");
            facts.Add("James Buchanan was one of the Presidents of all time.");
            facts.Add("Martin Van Buren was the first President to be born in the United States.");
            facts.Add("Moonlight is just reflected sunlight. \"Phases\" of the Moon are due to the angles the sun hits from.");
            facts.Add("Giraffes have the same amount of neck bones as humans.");
            facts.Add("Penguin poop is pink.");
            facts.Add("The symbol \"&\" used to be part of the English alphabet.");
            facts.Add("There is a functioning hotel made out of snow.");
            facts.Add("\"Athena\" (1986) is the first known video game that used mythological themes.");
            facts.Add("Four pairs of states in America share part of their names.");
            facts.Add("Airplanes were invented a few days after a newspaper declared that \"man won't fly for a million years.\"");
            facts.Add("Although there have been 46 Presidents, only 45 people have served as President. That's because one of them was elected two separate times.");

            fakes.Add("In Spanish-speaking countries, the card game \"Uno\" is sold as \"One.\"");
            fakes.Add("If hamsters spend more than one month alone, they'll die.");
            fakes.Add("Checkered shirts are illegal in Armenia.");
            fakes.Add("The name \"Percy\" did not exist before the Percy Jackson books. The author invented the name, and people liked it enough that they gave it to their children.");
            fakes.Add("There are no people in Antarctica.");
            fakes.Add("Arkansas doesn't actually exist, it's a made up state invented to scare children.");
            fakes.Add("It's illegal to be American in 12 countries.");
            fakes.Add("The name \"Mark\" is short for \"Marquese.\"");
            fakes.Add("The Great Wall of China is actually in France. Although it was started in China, the only surviving section of it is in France.");
            fakes.Add("Most elephants don't have feelings.");
            fakes.Add("Before 1657, there was no moon.");
            fakes.Add("If you sleep for more than 28 hours, you'll never wake up.");
            fakes.Add("Any bridge built before 1930 is illegal.");
            fakes.Add("Birthday candles are actually edible.");
            fakes.Add("85% of Christmas gifts are returned.");
            fakes.Add("Your fingernails grow faster when you're dead.");
            fakes.Add("Atlanta spelled backwards is still Atlanta.");
            fakes.Add("All mushrooms come from Brazil.");
            fakes.Add("If you take a \"once a day\" vitamin twice, you die.");
            fakes.Add("Shakespeare invented the letter Q.");
            fakes.Add("An octopus is three times more likely to kill you on land than in water.");
            fakes.Add("It is illegal to wear pajamas outside.");
            fakes.Add("Clapping after a movie is illegal in Florida and Georgia, subject to a fine.");
            fakes.Add("In Brazil, it is illegal to clap after the plane lands, and it could net you a fine.");
            fakes.Add("Kissing before marriage is technically illegal in 6 states, although the law is rarely enforced.");
            fakes.Add("Studies have shown that 86% of students actually like homework.");
            fakes.Add("Every time you sneeze, you lose 0.0000085% of your brain cells.");
            fakes.Add("You are more likely to die on your birthday than on any other day of the year.");
            fakes.Add("The name \"Instagram\" contains every vowel.");
            fakes.Add("In outer space, blood turns blue.");
            fakes.Add("The average person runs more distance than they walk.");
            fakes.Add("The order of the alphabet was defined in the Bible.");
            fakes.Add("Every American is assigned an FBI agent to spy on them 24/7.");
            fakes.Add("The year 2006 was one month longer than the rest. A special 13th month named \"Undecember\" was added to catch up with the Sun's orbital shift.");
            fakes.Add("In Pennsylvania, due to a legal loophole, you're technically allowed to take one scoop of any flavor of ice cream at any store for free. Stores get around this by charging for the cup.");
            fakes.Add("Cats can't take fall damage.");
            fakes.Add("Prisons are illegal in Switzerland. If you build one, you'll be sent to... uh... wait...");
            fakes.Add("If you get permanent marker on your skin, you can never get it off.");
            fakes.Add("In Peru, part of police training is done through Grand Theft Auto Online, to \"get in the mind of the criminal.\"");
            fakes.Add("Beds were invented in 1412. Before that, people slept on trees.");
            fakes.Add("\"SpongeBob SquarePants\" is based on a true story.");
            fakes.Add("In a rare anomaly, no babies were born on December 6th, 1919, anywhere in the world.");
            fakes.Add("The name \"Shannon\" will be made illegal starting in 2024. Women named Shannon must change their names by January 1st.");

            while (playAgain == "Y")
            {
                Welcome();
                int ansInt = -1;
                sol = Play(facts, fakes);
                bool okAns = false;
                do
                {
                    Console.Write("The cap is number... ");
                    string ans = Console.ReadLine();
                    ans.Trim();
                    try
                    {
                        ansInt = Int32.Parse(ans);
                        okAns = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input! Please write a number.");
                        okAns = false;
                    }

                } while (!okAns);
                if (ansInt == sol)
                {
                    score++;
                    Console.WriteLine("CORRECT!");
                }
                else
                {
                    errs++;
                    Console.WriteLine("Oops! Incorrect! The fake fact was number " + sol + ".");
                }

                Console.WriteLine("You have gotten " + score + " correct answers, and made " + errs + " mistakes.");

                Console.WriteLine("Play again? (Y/N)");
                playAgain = Console.ReadLine().ToUpper();
                Console.Clear();
            }
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to Two Facts and a Cap!");
            Console.WriteLine("You will be shown three facts, but one of them is a lie!");
            Console.WriteLine("Your job will be to spot the fake fact. Good luck!");
        }

        static string Selection(List<string> input, bool type)
        {
            int select = rnd.Next(0, input.Count);

            if (blacklistFact.Count > facts.Count - 3)
            {
                blacklistFact.Clear();
            }

            if (blacklistFake.Count > fakes.Count - 3)
            {
                blacklistFake.Clear();
            }

            if (type)
            {
                for (int i = 0; i < blacklistFact.Count; i++)
                {
                    if (select == blacklistFact[i])
                    {
                        return Selection(input, type);
                    }
                }
            }
            else
            {
                for (int i = 0; i < blacklistFake.Count; i++)
                {
                    if (select == blacklistFake[i])
                    {
                        return Selection(input, type);
                    }
                }

            }

            if (type)
            {
                blacklistFact.Add(select);
            }
            else
            {
                blacklistFake.Add(select);
            }

            return input[select];
        }

        static int Play(List<string> factSelect, List<string> fakeSelect)
        {
            switch (rnd.Next(0, 3))
            {
                case 0:
                    Console.WriteLine("1. " + Selection(factSelect, true));
                    Console.WriteLine("2. " + Selection(factSelect, true));
                    Console.WriteLine("3. " + Selection(fakeSelect, false));
                    return 3;

                case 1:
                    Console.WriteLine("1. " + Selection(factSelect, true));
                    Console.WriteLine("2. " + Selection(fakeSelect, false));
                    Console.WriteLine("3. " + Selection(factSelect, true));
                    return 2;

                case 2:
                    Console.WriteLine("1. " + Selection(fakeSelect, false));
                    Console.WriteLine("2. " + Selection(factSelect, true));
                    Console.WriteLine("3. " + Selection(factSelect, true));
                    return 1;

                default:
                    Console.WriteLine("1. " + Selection(factSelect, true));
                    Console.WriteLine("2. " + Selection(factSelect, true));
                    Console.WriteLine("3. " + Selection(fakeSelect, false));
                    return 3;
            }
        }

    }
}
