**Summary of Class**
In class we learned about multiple new ways to parallelize our code and ways to change the behaviour of our code/threads/parallelization.

**omp_set_dynamic()** allows you to adjust whether the number of threads is changed dynamically or not within your code's execution.
**omp_set_nested()** allows you to turn on nested parallelization within your code's execution to allow for loops and nested portions of code to parallelize themsevles.

Entering a 0 in the above items will turn them off while entering a 1 will turn them on.

While coding we can use **omp_set_num_threads(n) on the fly to be able to actively change the number of threads(n) we are using in the following #pragma omp parallel sections and we can also do it within a nested parallel part of our code. Which would look like this:

`#pragma omp parallel
{


	...
	omp_set_num_threads(2);
	
	#pragma omp parallel
	{

	}


}
`

Our code often starts with a default pool of 1024 threads and then sends the threads out to do operations as they are needed with thread 0/the first thread being the threads that assigns out jobs when we reach a parallel sections that needs a thread.

**omp_get_num_threads** is a piece of code that can be called to find how many threads are currently executing in the parallel region from which it is called. This can be useful to test how threads are distributed within your code.

When programming sometimes you might want to enable nested parallelism but you might also want to limit how deep into the nesting you will assign multiple threads. This can be accomplished with **omp_max_active_levels(n)** with n representing how many layers deep into your nested program it will assign the threads beyond 1.

**Questions**
Include data along with the calculated Speedup, Efficiency, and Karp-Flatt metric. What do these metrics tell you?
Provide images/charts for each metric and include them in your repository and README.md. You should use Microsoft Excel of Python with a plotting library for this.
Did you achieve a performance gain? How did your final version of code compare to the solution provided? What did you miss?
How much time did you spend on this reflection? How much time did you spending coding? Writing? Testing? Analyzing?
Coding - 3 hours
Writing - 2 hours
Testing - 2 hours
Analyzing - 
What are the differences in performance/behavior between tasks and sections in this reflection?

**Data**
Results for this reflection were achieved by using a set number n of 100,000,000. The number of threads was tested between 1-12. The code was tested using two parallelization methods, sections and tasks, as well as tested serially to have a base comparison. Below are the tables as well as in the Results folder, along with the results in a [csv](https://gitlab.com/kodywilliamson/cs4170_sp2021_r05_williamson/-/blob/master/Results/results.csv) and [Excel](https://gitlab.com/kodywilliamson/cs4170_sp2021_r05_williamson/-/blob/master/Results/Results.xlsx) format.

We see time wise that the single thread result is lower than all of the other threads and the rest of the time results tend to stick close to eachother with tasks and sections sharing similar times and slightly both outperforming the serial results.

For speedup we see a sublinear result for all three trials with tasks and sections having almost matching results and having overall higher speedup than serial but all three results indicate a slowdown rather than a speedup with added threads.

For efficiency we see three results all being sublinear and showing decreasing, below 1 efficiency. All three implementations have a decreasing efficiency as threads are added.

For Karp-Flatt we see all three results have sublinear results as threads are added. Sections and tasks follow close to eachtother and seems to slowly be approaching 1.7 where the serial code appears to follow a similiar pattern but be slightly higher as it slowly approaches 1.85.

![Speedup](https://gitlab.com/kodywilliamson/cs4170_sp2021_r05_williamson/-/blob/master/Results/Speedup.png)

![Efficiency](https://gitlab.com/kodywilliamson/cs4170_sp2021_r05_williamson/-/blob/master/Results/Efficiency.png)

![Karp-Flatt](https://gitlab.com/kodywilliamson/cs4170_sp2021_r05_williamson/-/blob/master/Results/Karp-Flatt.png)
