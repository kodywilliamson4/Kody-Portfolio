#!/bin/bash

#SBATCH --ntasks=12 
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=A01_Williamson

export OMP_NUM_THREADS=12
cd $SLURM_SUBMIT_DIR/Default
make all
./cs4170_sp2021_a01_williamson > results.csv
