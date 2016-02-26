namespace MongoPlayground.Models
{
    using System;

    using MongoDB.Driver;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            // var database = client.GetDatabase("test");

            //Problem HW 5.3 Verification
            //var collection = database.GetCollection<GradeModel>("grades");
            //var results = collection.Find(x => x.Scores.Count > 0).ToList();
            //var helper = results.GroupBy(x => x.ClassId).ToList();
            //var winner = new Tuple<int, double>(-1, -1.00);
            //foreach (var r in helper)
            //{
            //    Console.WriteLine("Class {0} investigation Started", r.Key);
            //    var classAverage =  r.ToList().Select(x => x.Scores.Where(y => y.Type != 'quiz').Average(y => y.Score)).Average();
            //    Console.WriteLine("Class {0} averaged {1}", r.Key, classAverage);

            //    if (winner.Item2 < classAverage)
            //        winner = new Tuple<int, double>(r.Key, classAverage);
            //}
            //Console.WriteLine('\tHW 5.3 Answer: Winner {0}, Average {1}', winner.Item1, winner.Item2);
            //Console.ReadLine();

            //Problem HW 5.4 Verification
            //var startsHelper = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            //var zips = database.GetCollection<ZipModel>("zips");
            //var results = zips.Find(x => x.City.Length > 0).ToList().Where(x => startsHelper.Contains(x.City.First())).Sum(x => x.Population);

            //    Console.WriteLine("Population Total where City starts with an integer... Total: {0}", results);

            //Final Problem 7

            //var database = client.GetDatabase("p7");

            //var albums = database.GetCollection<Album>("albums").Find(x => x.Id > int.MinValue).ToList().SelectMany(x => x.Images).Distinct().ToList();
            //var minusOrphans = database.GetCollection<Image>("images").Find(x => x.Id > int.MinValue).ToList().Count(x => albums.Contains(x.Id) && x.Tags.Contains("sunrises"));
            //Console.WriteLine("Orphaned... Total: {0}", minusOrphans);

            //Final Problem 2
            //var enronDb = client.GetDatabase("enron");

            // var messages = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "susan.mara@enron.com" || x.Headers.From == "soblander@carrfut.com" || x.Headers.From == "evelyn.metoyer@enron.com").ToList();

            //var susanToJeff = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "susan.mara@enron.com" && x.Headers.To.Contains("jeff.dasovich@enron.com")).ToList();

            //var susanToRichard = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "susan.mara@enron.com" && x.Headers.To.Contains("richard.shapiro@enron.com")).ToList();

            //var soblanderToSoblander = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "soblander@carrfut.com" && x.Headers.To.Contains("soblander@carrfut.com")).ToList();

            //var susanToJames = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "susan.mara@enron.com" && x.Headers.To.Contains("james.steffes@enron.com")).ToList();

            //var evelynToKate = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "evelyn.metoyer@enron.com" && x.Headers.To.Contains("kate.symes@enron.com")).ToList();

            //var susanToAlan = enronDb.GetCollection<Message>("messages").Find(x => x.Headers.From == "susan.mara@enron.com" && x.Headers.To.Contains("alan.comnes@enron.com")).ToList();

            //Console.WriteLine("susanToJeff {0}", susanToJeff.Count());
            //Console.WriteLine("susanToRichard {0}", susanToRichard.Count());
            //Console.WriteLine("soblanderToSoblander {0}", soblanderToSoblander.Count());
            //Console.WriteLine("susanToJames {0}", susanToJames.Count());
            //Console.WriteLine("evelynToKate {0}", evelynToKate.Count());
            //Console.WriteLine("susanToAlan {0}", susanToAlan.Count());

            //var distinctSenders = messages.Select(x => x.Headers.From.ToUpper()).Distinct().ToList();

            //var winner = "";
            //var winningCount = 0;
            //foreach (var sender in distinctSenders)
            //{
            //    //Get this guys messages
            //    var thisGuysMessages = messages.Where(x => x.Headers.From.ToUpper() == sender).ToList();

            //    try
            //    {
            //        //Find this dudes Favorite Recipient!
            //        var q = (from x in thisGuysMessages.SelectMany(x => x.Headers.To).Select(x => x.ToUpper())
            //            group x by x
            //            into g
            //            let count = g.Count()
            //            orderby count descending
            //            select new {Value = g.Key, Count = count}).First();

            //        if (q.Count > winningCount)
            //        {
            //            winningCount = q.Count;

            //            winner = string.Format("New Winner: {0} sent a total of {1} Messages to {2}.", sender, q.Count, q.Value);
            //            Console.WriteLine(winner);
            //        }

            //    }
            //    catch (Exception)
            //    {
            //        //Eat it
            //    }
            //}

            //Console.WriteLine("WINNER WINNER {0}", messages.Count());

            //Console.WriteLine("Messages... Total: {0}", messages.Count());
            //Console.WriteLine("Distinct Senders... Total: {0}", distinctSenders.Count());
            //Final Problem 8
            //var animals = database.GetCollection<Animal>("animals"); 

            Console.ReadLine();
        }
    }
}