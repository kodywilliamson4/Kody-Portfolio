#ifdef _OPENMP
    #include <omp.h>
#endif
#include <random>

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

int main(){

    int myRank = 0;
    int numThreads = 0;

    #ifdef _OPENMP
        myRank = omp_get_thread_num();
        numThreads = omp_get_num_threads();
    #else
        myRank = 0;
        numThreads = 1;
    #endif

    return 874;
}


