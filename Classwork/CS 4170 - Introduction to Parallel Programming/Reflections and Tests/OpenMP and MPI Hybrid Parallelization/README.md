### MPI Template for CS 4170/5170 ###
This is a basic template for Hybrid MPI-OpenMP code in CS 4170/5170

## Starting your own Repo ##

Follow these steps:

1. Create your appropriately named repo on Gitlab.

2. On your local computer: 
    - if using SSH, run  `git clone -b master --single-branch git@gitlab.com:CS_4170_5170_Parallel_Programing/fall-2019/hybrid.git <DIRECTORY_NAME>`. 
    - If using HTTPS, run `git clone -b master --single-branch https://gitlab.com/CS_4170_5170_Parallel_Programing/fall-2019/hybrid.git <DIRECTORY_NAME>`

3. `cd <DIRECTORY_NAME>`

4. `git remote remove origin`. This removes the current remote named `origin`.

5. `git remote add origin <URL_OF_YOUR_REPO>`. This adds a new remote that has the address of your repo.

6. `git branch -m master`. This changes the name of the current branch (mpi) to master.

6. `git push -u origin master`. This pushes your changes.

## Prerequisites ##
This code is meant to run with [Open-MPI](https://www.open-mpi.org/), [Boost](https://www.boost.org), [Boost MPI](https://www.boost.org/doc/libs/1_68_0/doc/html/mpi.html), and [OpenMP](https://www.openmp.org).

On Mac, be sure to run the command `brew install open-mpi boost boost-mpi`

On Windows, God Bless :)

## Running ##
To compile and run from command line if you are not on windows:

```
cd Default && make all
```

To compile and run with Docker issue the following commands from the root of the project (not in the Default folder):
```
docker run --rm -v ${PWD}:/tmp -w /tmp/Default rgreen13/alpine-mpi-boost make all
docker run --rm -v ${PWD}:/tmp -w /tmp/Default rgreen13/alpine-mpi-boost mpiexec --allow-run-as-root -n X MPI
```
where `X` is the number of nodes.

Do note that these makefiles generally expect custom BOOST libraries to be available in the variables ```$BOOST_LIBS``` and ```$BOOST_CFLAGS```. For instance, ```$BOOST_LIBS``` may include ```-L/usr/local/boost/intel/18.0/mvapich2/2.3/1.67.0/lib``` as it does on OSC. 

Make sure to build your code, then modify the `jobScript` accordingly. You also need to issue the following two commands to load MPI and Boost:
## Using OSC ##
1. Move all the files to the Ohio Supercomputing Center (OSC) server of your choice. 
2. Run the following two lines:
```
module load mvapich2
module load boost
```
3. Update the makefile so that `-fopenmp` is `-qopenmp`
4. Build your code using `make all` from the Default directory
5. Modify the jobScript file as needed. This is particularly true of nodes and ppn. The math on these two values must not exceed the total number of cores available. 
6. Submit from inside the `Default` directory using `qsub jobScript`

You may also do this using http://ondemand.osc.edu