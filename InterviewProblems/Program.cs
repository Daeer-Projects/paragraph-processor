using System;

namespace InterviewProblems
{
    class Program
    {
        const string LoremIpsum =
            "Lorem ipsum dolor sit amet, mel magna dolore rationibus no, ea pericula gubergren has. In vidisse percipit vix, qui amet adipiscing no, eum ad malis dicit. Ut eirmod commune eos. Vix case officiis no, decore nominavi te quo, stet appareat philosophia his ei. Te sea viris nemore neglegentur, ad eam dicit detracto partiendo. Minim impedit nominavi ut has, feugiat recteque id usu, at pro debitis forensibus delicatissimi. Assum accommodare qui ad. " +
            "Officiis neglegentur ut ius, aliquip invenire reformidans ex sit. Te legere disputationi his, nam ad utamur omittam apeirian. Cu vero paulo oportere qui, in suscipit lucilius consetetur ius. Ludus vocibus ad sed, ex vel eirmod feugiat nominavi, nostro inciderint mediocritatem vix et. At has sale denique, quo platonem democritum ullamcorper id. Modus similique sea at. " +
            "Sit mundi prompta voluptua ea, adipisci senserit repudiandae et pro. Ne consequuntur concludaturque eos, eos ea summo nostrum insolens, duo no viderer veritus. Timeam phaedrum scripserit te mei, te mea docendi pertinax omittantur, stet sale vis ea. Eos solet ceteros accusata at, an melius adversarium vituperatoribus qui, forensibus dissentias mea ea. Ius vocent maiestatis id, congue meliore et vel, est volutpat definitiones id. Ad vix velit blandit persecuti. " +
            "Nobis aliquam mnesarchum vim an, malis lucilius postulant sed ut. Mel et deserunt accommodare voluptatibus, in mei possit maluisset accommodare. Suas tempor tamquam quo ad, at vel zril homero platonem. Ei suas quando oportere duo. Vix quod augue disputando ei, paulo ubique scripta ei vim. Nec cibo affert menandri id, justo semper quo ea. " +
            "Eu solum expetenda vim, sed audire prodesset in. Eu tritani maiorum iudicabit quo, eos an latine numquam vulputate, per ceteros percipit at. Sit wisi dignissim elaboraret ei. Quo numquam aliquam feugait ne, mea dolor constituam cu, ne est viris impetus. Eos populo percipit ex, ne sed facer persius nostrud. Ea nec eirmod iriure, sed ex mazim integre tibique.";

        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1:");
            Console.WriteLine(Problem1.Process(LoremIpsum, 70));
            Console.WriteLine();

            // Uncomment these lines to test your second solution.
            //Console.WriteLine("Problem 2:");
            //foreach (var result in Problem2.Process(LoremIpsum))
            //    Console.WriteLine("Word: " + result.Key + " Count: " + result.Value);
            //Console.WriteLine();

            Console.WriteLine("Press any key to continue.");
            Console.Read();
        }
    }
}
