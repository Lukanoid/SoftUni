﻿namespace AuthorProblem
{
    public class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }

        [Author("Vasil")]
        void NewMethod(string method)
        {

        }
    }
}
