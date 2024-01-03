using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace G01ElectronicVoting.Shared
{
    [FirestoreData]
    public class Result
    {
        [FirestoreProperty]
        public string ElectionId { get; set; }
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public int[] Votes { get; set; }
        [FirestoreProperty]
        public string[] Candidates { get; set; }

        public Result() { }

        [JsonConstructor]
        public Result(string _electionid, string _title, int[] _votes, string[] _candidates)
        {
            ElectionId = _electionid;
            Title = _title;
            Candidates = _candidates;
            Votes = _votes;
        }
    }

    //helper class for results chart
    public class Candidate
    {
        public int Votes { get; set; } = 0;
        public string CandidateName { get; set; } = "";

        public Candidate(int _votes, string _candidateName)
        {
            Votes = _votes;
            CandidateName = _candidateName;
        }
    }
}
