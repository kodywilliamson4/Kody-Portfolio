using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using G01ElectronicVoting.Shared;
using Newtonsoft.Json;

namespace G01ElectronicVoting.Server.Data
{
    public static class FirestoreDataAccess
    {
        private static FirestoreDb db;

        static FirestoreDataAccess()
        {
            string keypath = Paths.FirestoreAPIKeyPath;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", keypath);
            db = FirestoreDb.Create(Paths.FirebaseProjectID);
        }

        public static async Task<bool> UserMustVote(string user)
        {
            try
            {
                CollectionReference electionRef = db.Collection("Election");
                CollectionReference voteRef = db.Collection("Vote");

                QuerySnapshot electionSnapshot = await electionRef.GetSnapshotAsync();
                QuerySnapshot voteSnapshot = await voteRef.GetSnapshotAsync();

                List<Election> userElections = new();
                List<Vote> userVotes = new();

                //get elections user can vote in
                foreach (var doc in electionSnapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string electionJson = JsonConvert.SerializeObject(doc.ToDictionary());
                        Election e = JsonConvert.DeserializeObject<Election>(electionJson);
                        if (e.Electorate.Contains(user)) userElections.Add(e);
                    }
                }

                //get user's votes
                foreach (var doc in voteSnapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string voteJson = JsonConvert.SerializeObject(doc.ToDictionary());
                        Vote v = JsonConvert.DeserializeObject<Vote>(voteJson);
                        if (v.VoterId == user) userVotes.Add(v);
                    }
                }

                foreach (var i in userElections)
                {
                    if (userVotes.Where(x => x.ElectionId == i.Id).Count() == 0)
                        return true;
                }

                return false;
            }
            catch
            {
                throw;
            }
        }

        public static async void CreateElection(Election e)
        {
            try
            {
                CollectionReference colref = db.Collection("Election");
                await colref.AddAsync(e);
            }
            catch
            {
                throw;
            }
        }

        public static async void UpdateElection(Election e)
        {
            try
            {
                DocumentReference docRef = db.Collection("Election").Document(e.Id);
                await docRef.SetAsync(e, SetOptions.Overwrite);
            }
            catch
            {
                throw;
            }
        }

        public static async void DeleteElection(string electionId)
        {
            try
            {
                DocumentReference docRef = db.Collection("Election").Document(electionId);
                await docRef.DeleteAsync();
            }
            catch
            {
                throw;
            }
        }

        public static async Task<List<Election>> GetAllElections()
        {
            try
            {
                CollectionReference colref = db.Collection("Election");
                QuerySnapshot snapshot = await colref.GetSnapshotAsync();

                List<Election> elections = new();
                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string json = JsonConvert.SerializeObject(doc.ToDictionary());
                        Election e = JsonConvert.DeserializeObject<Election>(json);
                        e.Id = doc.Id;
                        elections.Add(e);
                    }
                }

                return elections.OrderBy(x => x.EndYear)
                    .ThenBy(x => x.EndMonth)
                    .ThenBy(x => x.EndDay)
                    .ThenBy(x => x.Title)
                    .ToList();
            }
            catch
            {
                throw;
            }
        }

        public static async Task<Election> GetElectionFromId(string electionId)
        {
            try
            {
                DocumentReference docref = db.Collection("Election").Document(electionId);
                DocumentSnapshot snapshot = await docref.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    Election e = snapshot.ConvertTo<Election>();
                    e.Id = snapshot.Id;
                    return e;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }

        public static async Task<List<Election>> GetCurrentElectionsForUser(string user)
        {
            try
            {
                CollectionReference colref = db.Collection("Election");
                QuerySnapshot snapshot = await colref.GetSnapshotAsync();

                List<Election> elections = new();
                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string json = JsonConvert.SerializeObject(doc.ToDictionary());
                        Election e = JsonConvert.DeserializeObject<Election>(json);
                        e.Id = doc.Id;
                        if (DateTime.Now >= e.StartDate && DateTime.Now < e.EndDate && e.Electorate.Contains(user))
                            elections.Add(e);
                    }
                }

                return elections;
            }
            catch
            {
                throw;
            }
        }

        public static async Task<List<Election>> GetElectionsCreatedBy(string user)
        {
            try
            {
                CollectionReference colref = db.Collection("Election");
                QuerySnapshot snapshot = await colref.GetSnapshotAsync();

                List<Election> elections = new();
                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string json = JsonConvert.SerializeObject(doc.ToDictionary());
                        Election e = JsonConvert.DeserializeObject<Election>(json);
                        e.Id = doc.Id;
                        if (e.Creator == user) elections.Add(e);
                    }
                }

                return elections;
            }
            catch
            {
                throw;
            }
        }

        public static async void SubmitVote(Vote v)
        {
            try
            {
                CollectionReference colref = db.Collection("Vote");
                await colref.AddAsync(v);
            }
            catch
            {
                throw;
            }
        }

        public static async Task<List<Vote>> GetUserVotes(string user)
        {
            try
            {
                CollectionReference colref = db.Collection("Vote");
                QuerySnapshot snapshot = await colref.GetSnapshotAsync();

                List<Vote> votes = new();
                foreach (var doc in snapshot.Documents)
                {
                    string json = JsonConvert.SerializeObject(doc.ToDictionary());
                    Vote v = JsonConvert.DeserializeObject<Vote>(json);
                    if (v.VoterId == user) votes.Add(v);
                }

                return votes;
            }
            catch
            {
                throw;
            }
        }

        public static async Task<List<Result>> GetResultsForUser(string userId)
        {
            try
            {
                await UpdateResults();

                CollectionReference colref = db.Collection("Result");
                QuerySnapshot snapshot = await colref.GetSnapshotAsync();

                List<Result> results = new();
                foreach (var doc in snapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string json = JsonConvert.SerializeObject(doc.ToDictionary());
                        Result r = JsonConvert.DeserializeObject<Result>(json);

                        Election e = await GetElectionFromId(r.ElectionId);

                        if (e.Creator == userId || e.Electorate.Contains(userId))
                            results.Add(r);
                    }
                }

                return results;
            }
            catch
            {
                throw;
            }
        }

        public static async Task UpdateResults()
        {
            try
            {
                //get finished elections
                CollectionReference electionRef = db.Collection("Election");
                var electionSnapshot = await electionRef.GetSnapshotAsync();

                List<Election> finishedElections = new();
                foreach (var doc in electionSnapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string electionJson = JsonConvert.SerializeObject(doc.ToDictionary());
                        Election e = JsonConvert.DeserializeObject<Election>(electionJson);
                        e.Id = doc.Id;
                        if (e.EndDate <= DateTime.Now) finishedElections.Add(e);
                    }
                }

                //get all result entries
                CollectionReference resultRef = db.Collection("Result");
                var resultSnapshot = await resultRef.GetSnapshotAsync();

                List<Result> results = new();
                foreach (var doc in resultSnapshot.Documents)
                {
                    if (doc.Exists)
                    {
                        string resultJson = JsonConvert.SerializeObject(doc.ToDictionary());
                        Result r = JsonConvert.DeserializeObject<Result>(resultJson);
                        results.Add(r);
                    }
                }

                //check if there's a result entry for all finished elections
                bool found = false;
                CollectionReference voteRef = db.Collection("Vote");
                QuerySnapshot voteSnapshot;
                List<Vote> votesThisElection;
                Dictionary<string, int> candidateVotes;

                foreach (Election fe in finishedElections)
                {
                    found = false;

                    foreach (Result fr in results)
                    {
                        found = (fe.Id == fr.ElectionId);
                        if (found) break;
                    }

                    //if a result entry is not present
                    if (!found)
                    {
                        //gather votes for the current finished election
                        votesThisElection = new();
                        voteSnapshot = await voteRef.GetSnapshotAsync();
                        foreach (var doc in voteSnapshot.Documents)
                        {
                            if (doc.Exists)
                            {
                                string voteJson = JsonConvert.SerializeObject(doc.ToDictionary());
                                Vote v = JsonConvert.DeserializeObject<Vote>(voteJson);
                                if (fe.Id == v.ElectionId) votesThisElection.Add(v);
                            }
                        }

                        //count votes
                        candidateVotes = new();
                        foreach (string candidate in fe.Candidates)
                            candidateVotes.Add(candidate, 0);

                        foreach (Vote vte in votesThisElection)
                            candidateVotes[vte.Choice] += 1;

                        //create and add result entry
                        var newResult = new Result(fe.Id, fe.Title, candidateVotes.Values.ToArray(), candidateVotes.Keys.ToArray());
                        await resultRef.AddAsync(newResult);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
