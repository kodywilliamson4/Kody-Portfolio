#ifdef _OPENMP
    #include <omp.h>
#endif
#include <random>
#include <iostream>
#include "CStopWatch.h"

std::random_device rd;                           // only used once to initialise (seed) engine
std::mt19937 rng(rd());                          // random-number engine used (Mersenne-Twister in this case)
std::uniform_int_distribution<int> uni(0, 2000); // guaranteed unbiased

std::vector<int> generateList(int n){

    std::vector<int> retValue;
    srandom(time(NULL));
    for (int i = 0; i < n; i++){
        retValue.push_back(uni(rng));
    }

    return retValue;
}

double f(double x){
    double retVal = 0.0;

    retVal = x*x;

    return retVal;
}

double serialTrap(double a, double b, int n){

    double h, retValue, x;

    h = (b-a)/n;
    retValue = (f(a)+ f(b))/2;
    #pragma omp parallel for reduction(+: retValue)
    for(int i=1; i<=n-1; i++){
        x = a + i*h;
        retValue += f(x);
    }
    retValue = h*retValue;

    return retValue;
}

int main(){

    CStopWatch timer;
    double result;
    int a, b, n;

    a=0, b=16;
    // n=1983905792;
    n = 100000;
    // result = 0.0;

    double totalTime;
    int numTrials = 10;

   
    for(int i=0; i<numTrials; i++){
        timer.startTimer();
        result = serialTrap(a, b, n);
        timer.stopTimer();
        // std::cout << "My Result is: " << result << " in " << timer.getElapsedTime() << " seconds\n";
        std::cout << "Serial," << result << ",1," << timer.getElapsedTime() << "\n";
    }
    /*********************** End Serial Code ***********************/

    /*********************** Begin Parallel Code ***********************/
    for(int i=0; i<numTrials; i++){
        timer.startTimer();
        result = parallelTrap(a, b, n);
        timer.stopTimer();
        // std::cout << "My Result is: " << result << " in " << timer.getElapsedTime() << " seconds\n";
        std::cout << "Parallel," << result << ",X," << timer.getElapsedTime() << "\n";
    }
    
    
    /*********************** End Parallel Code ***********************/
    return 0;

   
}


