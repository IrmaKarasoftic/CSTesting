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

        // @CodeScene(disable-all)
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
                        if (word == "BA")
                        {

                        }
                        else if (word == "BB")
                        {
                            if (word == "BA")
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
                                        else if (word == "BB")
                                        {

                                        }
                                    }
                                }
                            }
                            else if (word == "BB")
                            {

                            }
                        }
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
                var synonymsFromCache = _words.Where(x => synonyms.Contains(x.WordString.ToLower())).ToList();
                var synonymIds = synonymsFromCache.Select(x => x.Id).ToList();

                //Get synonyms that are not already in cache
                var synonymsNotInCache = synonyms.Where(s => !synonymsFromCache.Select(x => x.WordString).Contains(s));

                //Add those synonyms
                var (newSynonymIds, nextId) = AddWordsToCache(_words.Count + 1, synonymIds, synonymsNotInCache);

                //Now we have a list of all synonyms, new and old
                var allSynonymIds = synonymIds.Concat(newSynonymIds).ToList();

                //Check if word already exists
                var existingWord = _words.FirstOrDefault(x => x.WordString == word.ToLower());

                //If it doesn't, add the word and synonyms
                if (existingWord == null)
                {
                    //Add synonyms of synonyms
                    synonymsFromCache.ForEach(x => allSynonymIds.AddRange(x.SynonymIds));

                    //Add new word and bind synonyms
                    _words.Add(new Word() { Id = nextId, WordString = word.ToLower(), SynonymIds = allSynonymIds.ToList() });
                    allSynonymIds.Add(nextId);
                }
                else
                {
                    //If it does, hook only synonyms that aren't already in the list
                    HookTheNewSynonymsToWord(existingWord, newSynonymIds);

                    //Add the word and its synonyms to all synonyms list
                    allSynonymIds.Add(existingWord.Id);
                    allSynonymIds.AddRange(existingWord.SynonymIds);
                }
                allSynonymIds = allSynonymIds.ToList();

                //Update newly added synonyms to have the references to all words
                UpdateAllSynonymsOfSynonyms(allSynonymIds);

                //Update the cache
                _cache.Set(wordListCacheKey, _words);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        // @CodeScene(disable:"Complex Method")
        public bool SomeOtherMethod(string word, List<string> synonyms)
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
                                        else if (word == "BB")
                                        {

                                        }
                                    }
                                }
                            }
                            else if (word == "BB")
                            {

                            }
                        }
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
                var synonymsFromCache = _words.Where(x => synonyms.Contains(x.WordString.ToLower())).ToList();
                var synonymIds = synonymsFromCache.Select(x => x.Id).ToList();

                //Get synonyms that are not already in cache
                var synonymsNotInCache = synonyms.Where(s => !synonymsFromCache.Select(x => x.WordString).Contains(s));

                //Add those synonyms
                var (newSynonymIds, nextId) = AddWordsToCache(_words.Count + 1, synonymIds, synonymsNotInCache);

                //Now we have a list of all synonyms, new and old
                var allSynonymIds = synonymIds.Concat(newSynonymIds).ToList();

                //Check if word already exists
                var existingWord = _words.FirstOrDefault(x => x.WordString == word.ToLower());

                //If it doesn't, add the word and synonyms
                if (existingWord == null)
                {
                    //Add synonyms of synonyms
                    synonymsFromCache.ForEach(x => allSynonymIds.AddRange(x.SynonymIds));

                    //Add new word and bind synonyms
                    _words.Add(new Word() { Id = nextId, WordString = word.ToLower(), SynonymIds = allSynonymIds.ToList() });
                    allSynonymIds.Add(nextId);
                }
                else
                {
                    //If it does, hook only synonyms that aren't already in the list
                    HookTheNewSynonymsToWord(existingWord, newSynonymIds);

                    //Add the word and its synonyms to all synonyms list
                    allSynonymIds.Add(existingWord.Id);
                    allSynonymIds.AddRange(existingWord.SynonymIds);
                }
                allSynonymIds = allSynonymIds.ToList();

                //Update newly added synonyms to have the references to all words
                UpdateAllSynonymsOfSynonyms(allSynonymIds);

                //Update the cache
                _cache.Set(wordListCacheKey, _words);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool AddTest(string word)
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

        private void UpdateAllSynonymsOfSynonyms(List<long> allSynonymIds)
        {
            _words.Where(x => allSynonymIds.Contains(x.Id)).Select(x =>
            {
                //Add list of new synonyms to existing list of synonyms
                var idsToAdd = x.SynonymIds.Concat(allSynonymIds.Where(id => id != x.Id));
                var synonymIds = idsToAdd.Distinct().ToList();
                x.SynonymIds = synonymIds;
                return x;
            }).ToList();
        }

        private void HookTheNewSynonymsToWord(Word existingWord, List<long> newSynonymIds)
        {
            _words.Where(x => x.Id == existingWord.Id).Select(x =>
            {
                x.SynonymIds = x.SynonymIds.Concat(newSynonymIds).ToList();
                return x;
            }).ToList();
        }

        private (List<long>, int) AddWordsToCache(int nextId, List<long> synonymIds, IEnumerable<string> synonymsNotInCache)
        {
            var newSynonymIds = new List<long>();
            foreach (var synonym in synonymsNotInCache)
            {
                _words.Add(new Word()
                {
                    Id = nextId,
                    WordString = synonym.ToLower(),
                    SynonymIds = synonymIds,
                });
                newSynonymIds.Add(nextId++);
            }

            return (newSynonymIds, nextId);
        }

    }
}
