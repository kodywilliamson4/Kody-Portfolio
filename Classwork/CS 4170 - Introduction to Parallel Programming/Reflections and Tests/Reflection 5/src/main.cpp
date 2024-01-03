#include <omp.h>
#include <iostream>
#include <iomanip>
#include "CStopWatch.h"
#include <vector>
#include <random>
#include <algorithm>

double firstPiMethod(int n) {
    double sum = 0.0;
    double factor = 1.0;

    for (int i = 0; i < n; i++, factor = -factor) {
        sum += factor/(2*i+1);
    }    
    return 4.0*sum;

}

double secondPiMethod(int nSamples) {
   
    double x, y;
    double estimate = 0.0;
    int numInCircle = 0.00;

    for(int i=0; i< nSamples; i++){
        x = ((double) std::rand() / (double) RAND_MAX) * 2.0 - 1.0;
        y = ((double) std::rand() / (double) RAND_MAX) * 2.0 - 1.0;

        if(x*x + y*y <=1){
            numInCircle++;
        }
    }
    estimate = (4.0*numInCircle/((double) nSamples));
    return estimate;
}

double parSect(int num)
{
    double first = 0;
    double second = 0;

    #pragma omp parallel //sections
    {
        #pragma omp sections
        {
            #pragma omp section
            {
                first = firstPiMethod(num);
            }
            #pragma omp section
            {
                second = secondPiMethod(num);
            }

        }
    }

    first = first + second;
    first = first / 2.0;

    return first;
}

double parTask(int num)
{
    double first = 0;
    double second = 0;

    #pragma omp parallel
    {
        #pragma omp single
        {
#pragma omp task
            {
                first = firstPiMethod(num);
            }
#pragma omp task
            {
                second = secondPiMethod(num);
            }
        }
    }

    first = first + second;
    first = first / 2.0;

    return first;
}

double serial(int num)
{
    double first = 0;
    double second = 0;

    first = firstPiMethod(num);
    second = secondPiMethod(num);

    first = first + second;
    first = first / 2.0;

    return first;
}

int main()
{
    int n = 100000000;
    CStopWatch timer;
    CStopWatch timer2;
    CStopWatch timer3;
    int threadMin, threadMax, threadStep;
    threadMin = 1; threadMax = 12; threadStep = 1;


    for (int numThreads = threadMin; numThreads <= threadMax; numThreads += threadStep) {
        omp_set_num_threads(numThreads);
        std::cout << numThreads;
        timer.startTimer();
        std::cout << numThreads << ": Sections: " << parSect(n);
        timer.stopTimer();
        std::cout << " " << timer.getElapsedTime() << std::endl;
        timer2.startTimer();
        std::cout << numThreads << ": Tasks: " << parTask(n);
        timer2.stopTimer();
        std::cout << " " << timer2.getElapsedTime() << std::endl;
        timer3.startTimer();
        std::cout << numThreads << ": Serial: " << serial(n);
        timer3.stopTimer();
        std::cout << " " << timer3.getElapsedTime() << std::endl;
    }

    return 0;
}