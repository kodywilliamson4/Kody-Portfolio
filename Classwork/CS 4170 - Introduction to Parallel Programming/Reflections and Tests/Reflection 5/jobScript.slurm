#!/bin/bash

#SBATCH --ntasks=2 
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=R05_Williamson

export OMP_NUM_THREADS=12
cd $SLURM_SUBMIT_DIR/Default
make all
./cs4170_sp2021_r05_williamson > results.csv
