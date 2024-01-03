CC = mpicxx
LIBS = -L$(BOOST_LIBS) -lboost_mpi -lboost_serialization
CFLAGS =-O2 -g -Wall -c -fmessage-length=0 -std=c++17 -I$(BOOST_CFLAGS)

RM := rm -rf

TARGET  = "cs4170_sp2021_a02_williamson"

UNAME := $(shell uname)
ifeq ($(UNAME),Darwin)
	INCLUDE = -I../src -I/usr/local/opt/boost/
else
	INCLUDE = -I../src -I/boost_1_75_0
	#-I$(MPI_CXXFLAGS) -I$(BOOST_FLAGS)
endif


SUBDIRS  	 := $(wildcard ../) $(wildcard ../*/)
CPP_SRCS 	 := $(wildcard ../*/*.cpp) $(wildcard ../*/*/*.cpp) 

OBJS     := $(patsubst ../%.cpp, ./%.o, $(CPP_SRCS))
CPP_DEPS := $(patsubst ../%.cpp, ./%.d, $(CPP_SRCS))


# All Target
all: MPI

# Tool invocations
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
	$(CC) $(INCLUDE) $(CFLAGS) $(LPSOLVE_FLAGS) $(OPENMP) $(ARCH) $(LIBS) -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(OBJS)$(CPP_DEPS)$(CPP_DEPS) $(TARGET)
	-@echo ' '

.PHONY: all clean dependents
.SECONDARY: