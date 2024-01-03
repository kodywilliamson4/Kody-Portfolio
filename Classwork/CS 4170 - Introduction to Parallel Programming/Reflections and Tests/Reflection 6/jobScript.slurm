#!/bin/bash

#SBATCH --nodes=1
#SBATCH --ntasks-per-node=12
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=MPIish

module load mvapich #module load openmpi # module load intelmpi
cd $SLURM_SUBMIT_DIR/Default
make all
mpiexec -n 4 MPI >> results.csv
mpiexec -n 5 MPI >> results.csv
mpiexec -n 6 MPI >> results.csv
mpiexec -n 7 MPI >> results.csv
mpiexec -n 8 MPI >> results.csv
mpiexec -n 9 MPI >> results.csv
