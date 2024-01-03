**Summarize what you learned during this week of class. Note any particular features, concepts, code, or terms that you believe are important. A thoughtful and complete response would be so complete that a student could, fundamentally, relearn all that you encountered this week simply by viewing your README file.**
MPI is used to parallelize programs. To start using MPI we call **MPI_Init(NULL, NULL);** and to end using MPI we call **MPI_Finalize();**. Both of these can only be called once within the code and should be used within main if there are multiple instances of MPI usage within the code.

**MPI_Comm_size()** sets the communicator's size for the parallelization and often uses MPI_COMM_WORLD as the first parameter and the second parameter is the number of processes. This is the equivalent to get_num_threads in openmp

**MPI_Comm_rank()** gets the rank of the communicator and often uses MPI_COMM_WORLD as the first parameter and the second parameter is where the current rank is returned. This is the equivalent of get_thread_num in openmp.

**MPI_Send()** performs a blocking send.

**MPI_Probe()** gets the status of the communication taking place.

**MPI_Get_Count()** gets the number of top level elements received/what size of data receiving.

**MPI_Recv()** performs a blocking receive.


**Include data along with the calculated Speedup, Efficiency, and Karp-Flatt metric. What do these metrics tell you?**

**How much time was spent on communication vs. computation? This provides insights into your implementation.**

**Provide images/charts for each metric and include them in your repository and README.md. You should use Microsoft Excel of Python with a plotting library for this.**

**Did you achieve a performance gain? How did your final version of code compare to the solution provided? What did you miss?**

**How much time did you spend on this reflection? How much time did you spending coding? Writing? Testing? Analyzing?**
I spent almost all of my time on coding and rewatching the videos from class. I believe I am getting confused somewhere between the last Tuesday's class example and the Trapezoid Rule example. Total I spent around 4 hours on Monday and 4 hours on Tuesday.
