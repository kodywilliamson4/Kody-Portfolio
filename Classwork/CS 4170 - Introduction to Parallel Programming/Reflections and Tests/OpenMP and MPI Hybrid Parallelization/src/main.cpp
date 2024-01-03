#include <iostream>
#include <iomanip>
#include <math.h>
#include <cstdlib>
#include <string>
#include <vector>
#include <fstream>

#include <random>
#include "CStopWatch.h"
#include <omp.h>
#include <boost/mpi.hpp>
#include <boost/serialization/string.hpp>
#include <boost/serialization/vector.hpp>

namespace mpi = boost::mpi;
namespace mt = mpi::threading;

using namespace std;

// https://www.boost.org/doc/libs/1_71_0/doc/html/boost/mpi/threading/level.html
int main(){

    mpi::environment env(mt::funneled);

    if(env.thread_level() < mt::funneled){
        env.abort(-1);
    }

    mpi::communicator world;

    
    #pragma omp parallel
    {   
        int numThreads = omp_get_num_threads();
        int threadNum  = omp_get_thread_num();

        std::cout   << "Hello from Thread " << threadNum+1 << " of " << numThreads
                    << " on Node " << world.rank()+1  << " of " << world.size() << "\n";
    }


    return 0;
}
