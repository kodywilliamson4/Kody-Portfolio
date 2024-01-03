# CS 4770 - Group 1 - Electronic Voting - Developer Information

### Project Overview
The app is built in Blazor WebAssembly using the ASP.NET Core hosted model. Three projects are present:
* Client - UI and code that runs in-browser
* Server - HTTP controllers and database access
* Shared - data models

Four pages are present, implemented as Razor components:
* A home page to direct users to the appropriate place
* An election management page where authenticated users can create and manage their own elections
* A voting page where authenticated users will be able to vote in elections
* A results page where users will be able to view the results of completed elections that they created or were a member of the potential voter base of.

The election management and voting pages utilize Blazor's HTML form component wrappers to allow for responsive validation without the use of JavaScript.

The project communicates with a Google Firestore (NoSQL) database that will store hashed data about users and elections.

### API List
* Home
  * GET(string user) => returns true if user has election they have not voted on
* Election
  * POST(Election e) => adds e to database
  * GET() => returns List containing all Election objects
  * GET(string electionId) => returns election object with specified id
* ElectionMgmt
  * GET(string user) => returns List of Election objects that user created
* Email
  * GET(Election e) => sends email notification to the Electorate of e, returns true if succesfully sent
* UserElection
  * GET(string user) => returns List of Election objects user is in the Electorate of
* Vote
  * POST(Vote v) => adds v to database
  * GET(string user) => gets List of all user's votes
* Result
  * GET(string user) => gets List of results user is allowed to view

### Database

##### Collections
* Election
  * Candidates (array)
  * Creator (string)
  * Electorate (array)
  * EndDay, EndMonth, EndYear (int)
  * StartDay, StartMonth, StartYear (int)
  * Title (string)
* Vote
  * ElectionID (string)
  * VoterID (string)
  * Choice (string)
* Result
  * ElectionID (string)
  * Candidates (array)
  * Percentages (array)

### Building

##### Target Framework
.NET 5

##### Common Errors
* **Problem**: There are migrations that have not been applied to the following database(s): ..."
  * **Solution**: Right click G01ElectronicVoting.Server project -> Open in Terminal, run `dotnet ef database update`
  * **Alternate Solution**: Tools -> NuGet Package Manager -> Package Manager Console, make sure "Default project" is set to Server, run `Update-Database`
* **Problem**: CSS changes not applying
  * **Solution**: Ctrl+F5 in browser

### Active Contributors
* Gabe Trautman
* Devin Waldon
* Kody Williamson
* Jiawei Ou
