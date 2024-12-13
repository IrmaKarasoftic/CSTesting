using SynonymsDB;

namespace SynonymsAPI.Services
{
    public class BadService
    {
        public BadService()
        {

        }
        //codechecker_critical
        public bool Add(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //TODO refactor this
        public bool Add(string word, bool foo)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {
                        if (word == "A")
                        {

                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(string word, bool foo, bool foo2)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {
                        if (word == "A")
                        {

                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(string word, string foo)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {
                        if (word == "A")
                        {

                        }
                    }
                }
                else if (word == "C")
                {

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //TODO one more
        public bool Add(string word, int foo)
        {
            try
            {
                if (word == "A")
                {
                    if (word == "A")
                    {
                        if (word == "A")
                        {

                        }

                    }
                    else if (word.Contains("B"))
                    {
                        if (word == "BA")
                        {
                            if (word == "A")
                            {

                            }
                            else if (word.Contains("B"))
                            {
                                if (word == "BA")
                                {

                                }
                                else if (word == "BB")
                                {

                                }
                            }
                            else if (word == "C")
                            {

                            }
                        }
                        else if (word == "BB")
                        {

                        }
                    }
                    else if (word == "C")
                    {

                    }
                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add(string word, List<string> synonyms)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {

                }
                //Remove all empty strings, or synonyms that are equal to word, and get Distinct values
                synonyms.RemoveAll(s => string.IsNullOrWhiteSpace(s) || s == word);
                synonyms = synonyms.Distinct().ToList();

                if (word == null || synonyms.Count == 0) return false;

                //If the word that is a synonym already exists, get the ID. If not, add it


                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add1(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add_1x(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add_Test(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add_Test1(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Add_Test_123(string word)
        {
            try
            {
                if (word == "A")
                {

                }
                else if (word.Contains("B"))
                {
                    if (word == "BA")
                    {
                        if (word == "A")
                        {

                        }
                    }
                    else if (word == "BB")
                    {

                    }
                }
                else if (word == "C")
                {
                    if (word == "BA")
                    {

                    }
                    else if (word == "BB")
                    {

                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public decimal Calculate(decimal amount, int type, int years, bool foo1, bool foo2, bool foo3)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }

        public decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }

        public decimal Calculate(decimal amount, int type, int years, bool foo)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }

        public decimal Calculate(decimal amount, int type, int years, bool foo1, bool foo2)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
                if (type == 1)
                {
                    result = amount;
                }
                else if (type == 2)
                {
                    result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
                }
                else if (type == 3)
                {
                    result = (0.7m * amount) - disc * (0.7m * amount);
                }
                else if (type == 4)
                {
                    result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
                }
                return result;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }

        public void NoOverloadsMethod()
        {

        }
    }
}
