using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are 10 movies on this list.");
                Console.WriteLine("What category are you interested in?");
                
                string input = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("The following movies are " + input + " movies:");
                Console.WriteLine("");

                List<Movie> movies = new List<Movie>();
                Movie m = new Movie("Silence of the Lambs", "horror");
                movies.Add(m);
                Movie j = new Movie("Saw", "horror");
                movies.Add(j);
                Movie n = new Movie("Moana", "animated");
                movies.Add(n);
                Movie l = new Movie("IT", "horror");
                movies.Add(l);
                Movie o = new Movie("Good Will Hunting", "drama");
                movies.Add(o);
                Movie p = new Movie("The Fifth Element", "sci-fi");
                movies.Add(p);
                Movie q = new Movie("American Beauty", "drama");
                movies.Add(q);
                Movie r = new Movie("Schindler's List", "drama");
                movies.Add(r);
                Movie s = new Movie("Toy Story", "animated");
                movies.Add(s);
                Movie t = new Movie("Alien", "sci-fi");
                movies.Add(t);

                foreach (Movie cj in movies)
                {
                    string cat = cj.getCategory();
                    if (cat == "horror" && input.Contains("horror"))
                    {
                        Console.WriteLine(cj.getTitle());
                    }
                    if (cat == "drama" && input.Contains("drama"))
                    {
                        Console.WriteLine(cj.getTitle());
                    }
                    if (cat == "sci-fi" && input.Contains("sci-fi"))
                    {
                        Console.WriteLine(cj.getTitle());
                    }
                    if (cat == "animated" && input.Contains("animated"))
                    {
                        Console.WriteLine(cj.getTitle());
                    }                                  
                }
            } while (Continue() == true);

        }
        
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
            return run;
        }
    }   
}


