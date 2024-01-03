#!/bin/bash

#SBATCH --nodes=12
#SBATCH --ntasks-per-node=1
#SBATCH --time=2:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=MPIish

module load mvapich2 
module load boost #module load openmpi #module load intelmpi
cd $SLURM_SUBMIT_DIR/Default
make all
mpiexec -ppn 1 Results > results1.csv
mpiexec -ppn 2 Results > results2.csv
mpiexec -ppn 3 Results > results3.csv
mpiexec -ppn 4 Results > results4.csv
mpiexec -ppn 5 Results > results5.csv
mpiexec -ppn 6 Results > results6.csv
mpiexec -ppn 7 Results > results7.csv
mpiexec -ppn 8 Results > results8.csv
mpiexec -ppn 9 Results > results9.csv
mpiexec -ppn 10 Results > results10.csv
mpiexec -ppn 11 Results > results11.csv
mpiexec -ppn 12 Results > results12.csv
