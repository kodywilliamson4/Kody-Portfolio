using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace G01ElectronicVoting.Shared
{
    [FirestoreData]
    public class Vote
    {
        [FirestoreProperty]
        public string ElectionId { get; set; }
        [FirestoreProperty]
        public string VoterId { get; set; }
        [FirestoreProperty]
        public string Choice { get; set; }

        public Vote() { }

        [JsonConstructor]
        public Vote(string _electionId, string _voterId, string _choice)
        {
            ElectionId = _electionId;
            VoterId = _voterId;
            Choice = _choice;
        }
    }
}
