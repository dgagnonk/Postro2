using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postro2
{

    public enum Condition
    {
        Perfect, Good, Average, Below_Average, Bad
    }

    public class Poster
    {

        public Condition PosterCondition { get; set; }
        public int Count { get; set; }
        public string Title { get; set; }

        public string ID { get { return _ID; } }
        private string _ID;

        public Poster(string title, Condition condition, string id, int count = 1)
        {
            this.Title = title;
            this.Count = count;
            this.PosterCondition = condition;

            _ID = id;
        }

        public override string ToString()
        {
            string ret = "";

            ret = string.Format("{0}, {1}, {2}, {3}", Title, ConditionToString(PosterCondition), Count.ToString(), ID);
            return ret;
        }

        public static string ConditionToString(Condition c)
        {
            switch((int)c)
            {
                case 0:
                    return "Perfect";

                case 1:
                    return "Good";

                case 2:
                    return "Average";

                case 3:
                    return "Below Average";

                case 4:
                    return "Bad";

                default:
                    return "N/A";          
            }
        }

        public static string ConditionToString(int c)
        {
            switch (c)
            {
                case 0:
                    return "Perfect";

                case 1:
                    return "Good";

                case 2:
                    return "Average";

                case 3:
                    return "Below Average";

                case 4:
                    return "Bad";

                default:
                    return "N/A";
            }
        }

        public static Condition StringToCondition(string s)
        {
            if (s == "Perfect") return Condition.Perfect;
            if (s == "Good") return Condition.Good;
            if (s == "Average") return Condition.Average;
            if (s == "Below Average") return Condition.Below_Average;
            if (s == "Bad") return Condition.Bad;

            return Condition.Average;


        }

    }
}
