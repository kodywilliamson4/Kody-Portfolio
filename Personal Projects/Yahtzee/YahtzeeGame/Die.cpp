#include <random>
#include <time.h>
using namespace std;


class Die
{
private:
	int die;
public:
	//Die();

	int roll() {
		Die myDie;
		die = myDie.RNG();
		return die;		
	};
	int RNG() {
		random_device dev;
		mt19937 rng(dev());
		uniform_int_distribution<std::mt19937::result_type> dist6(1, 6); // distribution in range [1, 6]
		return dist6(rng);
	};
};







