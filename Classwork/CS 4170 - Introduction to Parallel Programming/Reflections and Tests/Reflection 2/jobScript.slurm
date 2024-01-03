#!/bin/bash

#SBATCH --ntasks=4
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=ONE_THREAD_WILL

export OMP_NUM_THREADS=4
cd $SLURM_SUBMIT_DIR/Default
make all
./OpenMP > results.csv
