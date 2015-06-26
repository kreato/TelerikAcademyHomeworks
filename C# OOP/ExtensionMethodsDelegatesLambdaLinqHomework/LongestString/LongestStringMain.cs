namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class LongestStringMain
    {
        static void Main()
        {
            string text = "The beast appears, though you didn't expect it. You've never seen anything like this creature, a giant komondor dog with horns--and a former vicar of the church, apparently, evangelizing her faith by holding her paws together in prayer, then slamming them onto the ground and knocking you clear. The vicar is a microcosm of Bloodborne itself, a wondrous monstrosity that attacks you with vicious horror and religious overtones until you submit to it. Even should you rise above its terrors, Bloodborne answers to no master. Instead, you come to an agreement with it: You allow it to invade your brain and demand your concentration, and it allows you to wake from inevitable death, reminding you with each resurrection that life is a gift.";
            var splitedText = text.Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var longestWord = splitedText.OrderByDescending(x => x.Length).FirstOrDefault();
            Console.WriteLine("Longest word in string: {0}", longestWord);
            var splitedText2 = text.Split(new[] { ". " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var longestSentance = splitedText2.OrderByDescending(x => x.Length).FirstOrDefault();
            Console.WriteLine("Longest sentance in string: {0}", longestSentance);
        }
    }
}
