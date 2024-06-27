using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using SynonymsAPI.Interfaces;
using SynonymsDB;
using System.Linq;

namespace SynonymsAPI.Services
{
    public class SynonymsService : ISynonymsService
    {
        private const string wordListCacheKey = "wordList";
        private readonly IMemoryCache _cache;
        private List<Word> _words;

        public bool CopiedMethod(string word, List<string> synonyms)
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
                        if (word == "BA")
                        {

                        }
                        else if (word == "BB")
                        {
                            if (word == "BA")
                            {

                            }
                            else if (word == "BB")
                            {

                            }
                        }
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
                //Remove all empty strings, or synonyms that are equal to word, and get Distinct values

    }
}
}
}
