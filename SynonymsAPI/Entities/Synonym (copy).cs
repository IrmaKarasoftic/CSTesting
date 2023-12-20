namespace SynonymsDB
{
    public class Synonym
    {
        public long Id { get; set; }
        public string SynonymString { get; set; }
        public long WordId { get; set; }
        public Word Word { get; set; }
    }
}
//testing
