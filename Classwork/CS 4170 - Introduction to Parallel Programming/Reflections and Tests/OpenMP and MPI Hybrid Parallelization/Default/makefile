CC = mpicxx

OSC: LIBS = $(BOOST_LIBS) $(MPI_LIBS) -lgomp -lmpi -lboost_mpi -lboost_serialization
OSC: CFLAGS =-O2 -g -Wall -c -fmessage-length=0 -std=c++17 -fopenmp
OSC: INCLUDE = -I../src $(MPI_CFLAGS) $(BOOST_CFLAGS)

all: LIBS = -L$(BOOST_LIBS) -lgomp -lmpi -lboost_mpi -lboost_serialization
all: CFLAGS =-O2 -g -Wall -c -fmessage-length=0 -std=c++17 -fopenmp
all: INCLUDE = -I../src  -I$(BOOST_CFLAGS)/

RM := rm -rf

TARGET  = "Hybrid"

UNAME := $(shell uname)
ifeq ($(UNAME),Darwin)
	CC = g++-9
else
	CC = g++
endif

SUBDIRS  	 := $(wildcard ../) $(wildcard ../*/)
CPP_SRCS 	 := $(wildcard ../*/*.cpp) $(wildcard ../*/*/*.cpp) 
OBJS     := $(patsubst ../%.cpp, ./%.o, $(CPP_SRCS))
CPP_DEPS := $(patsubst ../%.cpp, ./%.d, $(CPP_SRCS))


all: MPI

OSC: MPI

MPI: $(OBJS) $(USER_OBJS)
	@echo 'Building target: $@'
	@echo 'Invoking: GCC C++ Linker'
	$(CC) -o $(TARGET) $(ARCH) $(OBJS) $(LIBS) 
	@echo 'Finished building target: $@'
	@echo ' '

src/%.o: ../src/%.cpp
	@mkdir -p $(@D)
	@echo 'Building file: $<'
	@echo 'Invoking: GCC C++ Compiler'
	$(CC) $(INCLUDE) $(CFLAGS) $(LPSOLVE_FLAGS) $(OPENMP) $(ARCH) -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(OBJS)$(CPP_DEPS)$(CPP_DEPS) $(TARGET)
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY:
