#!/bin/bash

#SBATCH --nodes=4
#SBATCH --ntasks-per-node=12
#SBATCH --time=1:00:00
#SBATCH --mail-type=END,FAIL
#SBATCH --account=PCS0253
#SBATCH --job-name=Hybridish

module load mvapich
module load boost  

#module load openmpi # module load intelmpi
cd $SLURM_SUBMIT_DIR/Default
make all
mpiexec -n 4 Hybrid
