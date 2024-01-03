using System;
using System.Collections.Generic;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace G01ElectronicVoting.Shared
{
    [FirestoreData]
    public class Election
    {
        public string Id { get; set; }
        [FirestoreProperty]
        public string Title { get; set; }
        [FirestoreProperty]
        public List<string> Candidates { get; set; }
        [FirestoreProperty]
        public int StartYear { get; set; }
        [FirestoreProperty]
        public int StartMonth { get; set; }
        [FirestoreProperty]
        public int StartDay { get; set; }
        [FirestoreProperty]
        public int EndYear { get; set; }
        [FirestoreProperty]
        public int EndMonth { get; set; }
        [FirestoreProperty]
        public int EndDay { get; set; }
        [FirestoreProperty]
        public string Creator { get; set; }
        [FirestoreProperty]
        public List<string> Electorate { get; set; }
        [FirestoreProperty]
        public bool Hidden { get; set; }

        public DateTime StartDate { get => new DateTime(StartYear, StartMonth, StartDay); }
        public DateTime EndDate { get => new DateTime(EndYear, EndMonth, EndDay); }

        public Election()
        {
            Candidates = new();
            Electorate = new();
        }

        [JsonConstructor]
        public Election(string _title, List<string> _candidates, int _startYear, int _startMonth, int _startDay, int _endYear, int _endMonth, int _endDay, string _creator, List<string> _electorate, bool _hidden)
        {
            Title = _title;
            Candidates = _candidates;
            StartYear = _startYear; StartMonth = _startMonth; StartDay = _startDay;
            EndYear = _endYear; EndMonth = _endMonth; EndDay = _endDay;
            Creator = _creator;
            Electorate = _electorate;
            Hidden = _hidden;
        }
    }
}
