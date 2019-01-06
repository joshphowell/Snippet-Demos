using SnippetDemos.Models;
using System;
using System.Collections.Generic;

namespace SnippetDemos.Helpers
{
    public class DemoHelper
    {
        private const string loremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut ac blandit leo. Nam sem elit, laoreet sit amet molestie quis, mollis eget metus. Maecenas ultrices vulputate sollicitudin. Nullam ut dignissim leo. In fringilla, mi id ultricies gravida, enim nisi iaculis sem, ut volutpat urna odio at sapien. Praesent condimentum lorem in nunc semper fermentum. In placerat gravida nulla, in pellentesque dolor blandit a. Praesent id purus gravida, faucibus sem nec, tempor nisi. Phasellus tempus consectetur justo in varius. Cras neque erat, sollicitudin at consequat at, feugiat vel sem. Sed sit amet viverra dolor. Nullam vel dapibus lectus. Suspendisse dolor turpis, lacinia a semper quis, condimentum at ante. Mauris in gravida lorem. Mauris venenatis orci sit amet pretium tempus. Nullam dapibus tristique tellus ut commodo.
            Integer consectetur tincidunt quam eu lobortis.Nulla at velit nisi.Nam iaculis tortor mollis condimentum tincidunt. Nulla ut augue tellus. Fusce sodales interdum sem eu convallis. Aliquam erat volutpat.Pellentesque tempus ligula quis ante venenatis, eget sagittis lacus vehicula. Nullam ac aliquet ipsum. Morbi quis dui imperdiet dui venenatis fermentum.Morbi suscipit tincidunt turpis nec sodales. Nunc vel interdum nisi, vitae congue magna.Suspendisse potenti.

            Vestibulum lacinia dolor a mi condimentum auctor.Sed et ipsum lorem. Fusce venenatis volutpat velit, sit amet sodales justo ultricies eu. Ut elementum eu justo id imperdiet. Etiam lorem nisi, porttitor ac venenatis porttitor, blandit quis ipsum.Duis in libero et diam volutpat porttitor.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Cras congue metus quis malesuada cursus. Phasellus a lorem et felis fringilla interdum.Nullam arcu neque, euismod at ipsum ut, fermentum feugiat libero.Vestibulum id dolor nibh. Phasellus dignissim elit a felis porttitor, nec scelerisque diam semper. Duis sed odio mollis, blandit arcu vitae, congue lorem. Phasellus finibus placerat placerat.

            Nulla et convallis purus, vitae gravida erat.Praesent ac aliquam massa, consequat aliquet turpis.Pellentesque efficitur, ex efficitur volutpat feugiat, nisl turpis malesuada arcu, at porta nisi lorem a risus. Sed pretium tincidunt convallis. Fusce pulvinar non massa ac gravida. Curabitur nec lectus volutpat, sagittis orci at, suscipit risus. Aliquam mauris nisl, tincidunt a libero vel, scelerisque tempus metus.Suspendisse volutpat ultricies imperdiet. Vivamus aliquet at lorem id facilisis. Phasellus tortor libero, placerat nec risus vitae, scelerisque congue lorem.Sed fermentum arcu et elementum efficitur.

            Suspendisse ac mollis mauris, id maximus elit.Phasellus tincidunt dolor in turpis cursus, vitae scelerisque metus accumsan. Suspendisse orci nunc, iaculis scelerisque nibh in, ultrices egestas enim.Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Ut pretium mollis purus sed congue. In congue lacus venenatis, egestas ex ac, ornare lorem. Aenean cursus pharetra urna, non venenatis dolor rutrum a.Praesent sit amet vulputate lacus, vel lobortis eros.Etiam non blandit sem. Ut pretium eros sit amet ultricies luctus.Donec consectetur accumsan nisi, sit amet mattis felis placerat eu.";
        private static readonly string[] randomWords =
        {
                "hello", "also", "man", "the", "for", "and", "a", "with", "bird", "fox", "useful", "funny",
                "peculiar", "They", "after", "doing", "she", "walked", "to"
        };

        private static readonly string[] randomNames =
        {
            "Abraham", "Ben", "Callum", "Dan", "Elise", "Frederick", "Gareth", "Helga", "Isaac", "Josh", "Katherine", "Lisa", "Monica",
            "Noah", "Oscar", "Peter", "Quinn", "Rachel", "Sally", "Thomas", "Ursula", "Vicky", "Wendy", "Xavier", "Zara", "Amy", "Bella",
            "Christopher", "Daryll", "Ethan", "Frank", "Gertrude", "Harrison", "Isobel", "James", "Ken", "Larry", "Magnus", "Nelly", "Oliver",
            "Patrick", "Robin", "Sarah", "Tim", "Ugly", "Venom", "Spiderman", "Hulk", "Iron Man", "Wolverine", "Beast", "Tyrion", "Daenerys"
        };

        private readonly Random rnd;

        public DemoHelper()
        {
            rnd = new Random();
        }

        public List<DateTime> GetDates(int count = 10)
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;

            for (int i = 0; i < count; i++)
            {
                dates.Add(start.AddDays(rnd.Next(range)));
            }
            return dates;
        }

        public List<string> GetNames(int count = 10)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int j = i;
                while (j >= randomNames.Length)
                {
                    j -= randomNames.Length;
                }
                names.Add(randomNames[j]);
            }
            return names;
        }

        public List<string> GetDescriptions(int count = 10)
        {
            List<string> descriptions = new List<string>();
            for (int i = 0; i < count; i++)
            {
                RandomText text = new RandomText(randomWords);
                text.AddContentParagraphs(1, 1, 2, 4, 12);
                descriptions.Add(text.Content);
            }
            return descriptions;
        }

        public bool GetRandomBool()
        {
            return rnd.NextDouble() > 0.5;
        }

        public List<TestDataModel> GetTestData(int count = 10)
        {
            List<DateTime> dates = GetDates(count);
            List<string> names = GetNames(count);
            List<string> descriptions = GetDescriptions(count);

            List<TestDataModel> testData = new List<TestDataModel>();
            for (int i = 0; i < count; i++)
            {
                testData.Add(new TestDataModel()
                {
                    Date = dates[i],
                    Name = names[i],
                    Description = descriptions[i],
                    Active = GetRandomBool()
                });
            }
            return testData;
        }
    }
}