Reflection #04
Completed by Kody Williamson

Summary
This last week in class focused on locks and critical sections of code. Critical section of code are sections that can only be entered by one thread at a time to make sure that the data is stored and accessed correctly without any overlap in a way that would skew results. In class we learned three different ways that we can implement a critical section properly, with each of the three methods having perks as well as downsides to them.

First before the locks we learned about barriers that would allow us to block all threads until they reach the same point. This would be accomplished with the code #pragma omp barrier.

As for the locks we have the following three options.

The first way we learned was **Locks**. Locks avoid the typical performance hit that are created by the inherent barriers of critical and atomic.

The second way is **#pragma omp critical**. Critical sections aren't limited the same way that atomic sections and are implemented. Another perk of critical sections is their ability to named. This allows you to implement multiple critical sections in a way that they all have unique identifiers since they are given the same names by default.

#pragma omp critical
{
    x++;
}

The third and final option is **#pragma omp atomic**. This means the next line of code following the #pragma omp atomic line will only allow it to be touched by one thread at a time. This option is much higher performance but the downside is that it must follow the form of x <op> = <expression>. With the op being able to be +,*, -, /, &, ^, |, <<, >> as well as x++, ++x, x--, --x. Atomic sections would be implemented by example:

#pragma omp atomic
x++;

Results

