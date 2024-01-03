#!/bin/bash

#SBATCH --nodes=10
#SBATCH --ntasks-per-node=10
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=Hybridish

module load mvapich2
module load boost  

#module load openmpi # module load intelmpi
export OMP_NUM_THREADS=12
cd $SLURM_SUBMIT_DIR/Default
make OSC
mpiexec -n 1 Hybrid >> results.csv
mpiexec -n 2 Hybrid >> results.csv
mpiexec -n 3 Hybrid >> results.csv
mpiexec -n 4 Hybrid >> results.csv
mpiexec -n 5 Hybrid >> results.csv
mpiexec -n 6 Hybrid >> results.csv
mpiexec -n 7 Hybrid >> results.csv
mpiexec -n 8 Hybrid >> results.csv
mpiexec -n 9 Hybrid >> results.csv
mpiexec -n 10 Hybrid >> results.csv
