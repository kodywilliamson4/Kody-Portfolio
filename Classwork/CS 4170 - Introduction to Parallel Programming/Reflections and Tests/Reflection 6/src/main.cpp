#include <mpi.h>
#include <sstream>
#include <iostream>
#include "CStopWatch.h"


std::random_device rd; 
std::mt19937 rng(rd()); 
std::uniform_real_distribution<double> myDist{-1, 1};

void calcPi(int nSamples) {

    double x, y;
    double estimate = 0.0;
    int numInCircle = 0.00;
    CStopWatch timer;

    timer.startTimer();
    for(int i=0; i< nSamples; i++){
        x = myDist(rng);
        y = myDist(rng);

        if(x*x + y*y <=1){
            numInCircle++;
        }
    }
    timer.stopTimer();
    estimate = (4.0*numInCircle/((double) nSamples));
    std::cout << estimate << ", " << timer.getElapsedTime() << endl;
}

void parallel()
{
    int numProcs;
    int myRank;
    MPI_Status myStatus;
    double n = 10000000;
    double localResult;


    MPI_Comm_size(MPI_COMM_WORLD, &numProcs);
    MPI_Comm_rank(MPI_COMM_WORLD, &myRank);


    if(myRank != 0){ // Worker

        // Send my result back to master
        MPI_Send(&localResult, 1, MPI_DOUBLE, 0, 0, MPI_COMM_WORLD);

    }else{ // Master

        result = localResult; // Start with the work the Master already completed
        // Gather all the results
        for(int i=1; i<numProcs; i++){
            MPI_Recv(&localResult, 1, MPI_DOUBLE, i, 0, MPI_COMM_WORLD, &myStatus);
            
            // Combine them
            result += localResult;
        }

    for (int i = 0; i < 10; i++) {
        std::cout << "Pi, Time" <<endl;
        calcPi(n);
    }
}

int main()
{
    MPI_Init(NULL, NULL);

    for(int i = 0; i < 10; i++) {
        parallel();
    }

    MPI_Finalize();

}
