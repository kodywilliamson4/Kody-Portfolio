# Sprint Review 05
---
### Gabe
- What went well?
> Election data can now be read from the database without any complications. This means we no longer require hard-coded sample data outside of the Results page. I also finished designing the database schema so that we are ready to finish adding database operations in the next sprint.
- What didn’t go so well?
> Google.Cloud.Firestore's Timestamp class does not behave properly when read from the database, so I had to split the election's StartDate/EndDate into integers (StartYear, StartMonth, StartDay, etc.). This took a considerable amount of time to debug before I decided to make the switch.
- What have I learned?
> I learned how to use HTTP GET requests to pull entire collections from a Firestore (NoSQL) database. I also continue to notice that Google's .NET support is lacking.
- What still puzzles me?
> For the remaining sprints, I will probably have trouble balancing the work evenly among the team members as I will want to
- What will we change to improve?
> I will start adding common errors encountered by developers to the DEVELOPER.md file so they can consult that rather than me.
---
### Kody
- What went well?
> We have made all of the connections so our workflow has been able to get underway.
- What didn’t go so well?
> No issues this week to discuss.
- What have I learned?
> I have learned more about how we use user's names in order to show data specific to them.
- What still puzzles me?
> Changing the looks of the website, I still need to look more into this.
- What will we change to improve?
> This week went pretty smooth so I think we are in a good point right now. I don't have any critiques to make.
---
### Devin
- What went well?
> We were able to access our actual data in our Firestore database instead of using sample data.
- What didn’t go so well?
> Everything went smooth for the most part.
- What have I learned?
> How to use more functionalities in C#/Blazor, like using the AuthenticationStateProvider and HttpClient classes.
- What still puzzles me?
> Nothing, everything currently seems clear.
- What will we change to improve?
> Nothing needs change, we just need to keep staying persistent and keep communicating any new ideas and/or inputs we may have for the web app.
---
### Jiawei
- What went well?
> We got firestore database to work.
- What didn’t go so well?
> Everything seems fine.
- What have I learned?
> I learned more about how to use Blazor with C# and java script and some issues when running on the chrome browser.
- What still puzzles me?
> Not for right now.
- What will we change to improve?
> Nothing to improve right now, but definitely keep communicating and share new ideas with each other.
---