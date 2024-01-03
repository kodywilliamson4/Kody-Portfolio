#include <iostream>
#include <iomanip>
#include <math.h>
#include <cstdlib>
#include <string>
#include <vector>
#include <fstream>
#include <random>
#include <mpi.h>
#include <sstream>

#include <omp.h>
#include "CStopWatch.h"

#include <boost/mpi.hpp>
#include <boost/mpi/environment.hpp>
#include <boost/mpi/communicator.hpp>
#include <boost/serialization/string.hpp>
#include <boost/serialization/vector.hpp>

namespace mpi = boost::mpi;
//namespace mt = mpi::threading;

typedef std::vector<int>       iArray1D;
typedef std::vector<double>    ldArray1D;
typedef std::vector<ldArray1D> ldArray2D;
typedef std::vector<ldArray2D> ldArray3D;

#define PI_F 3.141592654f

class Particle{                                                     //Double check this as well as Swarm for proper changes
public:
    Particle() : Particle(0){}

    Particle(int Nd){
        R.resize(Nd, -INFINITY);
        V.resize(Nd, -INFINITY);

        M = -INFINITY;
        pBest = -INFINITY;
        pBestPos.resize(Nd, -INFINITY);
    }

    void print(){
        std::cout << "M: " << M << "\n";
        std::cout << "pBest: " << pBest << "\n";

        for (int i = 0; i < (int)R.size(); i++){
            std::cout << "R[" << i << "] = " << R[i] << "\n";
        }
        for (int i = 0; i < (int)V.size(); i++){
            std::cout << "V[" << i << "] = " << V[i] << "\n";
        }
    }

    template <typename Archive>
    void serialize(Archive &ar, const unsigned int version){
        ar &R;
        ar &V;
        ar &M;
        ar &pBest;
        ar &pBestPos;
    }

    // private:
    friend class boost::serialization::access;

    std::vector<double> R;
    std::vector<double> V;
    double M;
    double pBest;
    std::vector<double> pBestPos;
};

class Swarm{

    public:
        Swarm() : Swarm(0, 0) {}
        Swarm(int Np, int Nd){
            particles.resize(Np, Particle(Nd));
        }

        void print(){
            for (int i = 0; i < (int)particles.size(); i++){
                particles[i].print();
            }
        }

        template <typename Archive>
        void serialize(Archive &ar, const unsigned int version){
            ar &particles;
        }

    //private:  
        friend class boost::serialization::access;
        std::vector<Particle> particles;
};

double f(double x)
{
    return x*x;
}

std::random_device rd;                          // only used once to initialise (seed) engine
double randDbl(const double& min, const double& max) {
    static thread_local std::mt19937* generator = nullptr;
    if (!generator) {
        generator = new std::mt19937(clock());
    }
    std::uniform_real_distribution<double> distribution(min, max);
    return distribution(*generator);
}

double Rastrigin(std::vector<double> &R, int Nd, int p){ // Rastrigin
    double Z = 0, Xi;

    for (int i = 0; i < Nd; i++){
        Xi = R[i];
        Z += (pow(Xi, 2) - 10 * cos(2 * PI_F * Xi) + 10);
    }
    return -Z;
}

void PSO(int Np, int Nd, double (*objFunc)(std::vector<double> &, int, int), int numThreads)
{
    //mpi::environment env(mt::funneled);

    //if(env.thread_level() < mt::funneled){
        //env.abort(-1);
    //}

    mpi::communicator world;

    double xMin, xMax, vMin, vMax;
    int numProcs = world.size();
    int myRank = world.rank();
    int numEvals, Nt, num;
    CStopWatch timer;
    xMin = -5.12;   // Lower Bound
    xMax = 5.12;    // Upper Bound
    vMin = -1;      // Minimum Velocity
    vMax = 1;       // Maximum Velocity
    Nt = 3000;
    numEvals = 0;
    //int lastStep = Nt, bestTimeStep = 0;
    float C1 = 1.45, C2 = 1.45;
    float w, wMax = 0.9, wMin = 0.1;
    float R1, R2;
    std::vector<Particle> myP;
    std::vector<Particle> myBest;

    num = Np / numProcs;
    myP.resize(num);
    myBest.resize(numProcs);

    Swarm swarm(Np, Nd);
    Particle myB(Nd);
    mpi::scatter(world, swarm.particles, myP.data(), num, 0);

    // Global Best
    ldArray1D gBestPosition(Nd, -INFINITY);
    float gBestValue = -INFINITY;

    if(myRank == 0)
    {
        timer.startTimer();
    }

    // Init Population
    #pragma omp parallel for
    for (int p = 0; p < num; p++){
        for (int i = 0; i < Nd; i++){
            myP[p].R[i] = randDbl(xMin, xMax);
            myP[p].V[i] = randDbl(vMin, vMax);
        }
    }

    // Evaluate Fitness
    #pragma omp parallel for reduction(+:numEvals)
    for (int p = 0; p < num; p++){
        myP[p].M = objFunc(myP[p].R, Nd, p);
        numEvals++;
    }
    //MPI_Allreduce(&numEvals, &numEvals, 1, MPI_INIT, MPI_SUM, MPI_COMM_World);

    for (int j = 1; j < Nt; j++){

        //Update Positions
        #pragma omp parallel for collapse(2)
        for (int p = 0; p < num; p++){ // Particle
            for (int i = 0; i < Nd; i++){ // Dimension
                myP[p].R[i] = myP[p].R[i] + myP[p].V[i]; // Update my position

                // Corrects a particle if it's outside the bounds
                if (myP[p].R[i] > xMax){ myP[p].R[i] = randDbl(xMin, xMax);}
                if (myP[p].R[i] < xMin){ myP[p].R[i] = randDbl(xMin, xMax);}
            }
        }

        // Evaluate Fitness
        #pragma omp parallel for reduction(+:numEvals)
        for (int p = 0; p < num; p++){
            myP[p].M = objFunc(myP[p].R, Nd, p);
            numEvals++;
        }
        //MPI_Allreduce(&numEvals, &numEvals, 1, MPI_INIT, MPI_SUM, MPI_COMM_World);

        // Global & Personal Bests
        #pragma omp parallel for //reduction(max:gBestValue)
        for (int p = 0; p < num; p++){
            if (myP[p].M > myB.M){
                myB.M = myP[p].M;
                for (int i = 0; i < Nd; i++){
                    myB.pBestPos[i] = myP[p].R[i];
                }
            }

            // Local
            if (myP[p].M > myP[p].pBest){
                myP[p].pBest = myP[p].M;
                for (int i = 0; i < Nd; i++){
                    myP[p].pBestPos[i] = myP[p].R[i];
                }
            }
        }

        mpi::gather(world, myB, myBest, 0);

        if(myRank == 0)
        {
            for(int i = 0; i < (int)myBest.size(); i++)
            {
                if(myBest[i].M > gBestValue)
                {
                    gBestValue = myBest[i].M;
                    for(int j = 0; j < Nd; j++)
                    {
                        gBestPosition[j] = myBest[i].R[j];
                    }
                }
            }
        }

        mpi::broadcast(world, gBestValue, 0);
        mpi::broadcast(world, gBestPosition, 0);

        if (gBestValue >= -0.0001)
        {
           // lastStep = j;
            break;
        }


        // Update Velocities
        w = wMax - ((wMax - wMin) / Nt) * j;
        #pragma omp parallel for collapse(2) private(R1, R2)
        for (int p = 0; p < num; p++){
            for (int i = 0; i < Nd; i++){
                R1 = randDbl(0, 1);
                R2 = randDbl(0, 1);

                // Original PSO
                myP[p].V[i] = w * myP[p].V[i] + C1 * R1 * (myP[p].pBestPos[i] - myP[p].R[i]) + C2 * R2 * (gBestPosition[i] - myP[p].R[i]);
                if (myP[p].V[i] > vMax){ myP[p].V[i] = randDbl(vMin, vMax);}
                if (myP[p].V[i] < vMin){ myP[p].V[i] = randDbl(vMin, vMax);}
            }
        }
    } // End Time Steps

    world.barrier();
    if (myRank == 0)
    {
        timer.stopTimer();

        std::cout << numThreads << "," << gBestValue << "," << Np << "," << Nd << "," << numEvals << "," << timer.getElapsedTime() << std::endl;
    }

    gBestPosition.clear();
}

int main(){

    int Np, Nd;
    double (*rPtr)(std::vector<double> &, int, int) = NULL;
    int threadMin, threadMax, threadStep;

    Np = 1000;
    Nd = 30;
    threadMin = 1; threadMax = 10; threadStep = 1;

    //std::cout << "Fitness, Np, Nd, NumEvals, Time" << std::endl;
    rPtr = &Rastrigin;

    mpi::environment env;

    for (int numThreads = threadMin; numThreads <= threadMax; numThreads += threadStep)
    {
        for (int numTrial = 0; numTrial < 5; numTrial++)
        {
            omp_set_num_threads(numThreads);
            PSO(Np, Nd, rPtr, numThreads);
        }
        std::cout << std::endl;
    }

    rPtr = NULL;

    return 0;
}
