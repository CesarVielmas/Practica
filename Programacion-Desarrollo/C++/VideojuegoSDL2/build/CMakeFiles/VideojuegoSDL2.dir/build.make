# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.16

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build

# Include any dependencies generated for this target.
include CMakeFiles/VideojuegoSDL2.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/VideojuegoSDL2.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/VideojuegoSDL2.dir/flags.make

CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o: CMakeFiles/VideojuegoSDL2.dir/flags.make
CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o: ../src/main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o"
	/usr/bin/g++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o -c /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/src/main.cpp

CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.i"
	/usr/bin/g++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/src/main.cpp > CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.i

CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.s"
	/usr/bin/g++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/src/main.cpp -o CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.s

# Object files for target VideojuegoSDL2
VideojuegoSDL2_OBJECTS = \
"CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o"

# External object files for target VideojuegoSDL2
VideojuegoSDL2_EXTERNAL_OBJECTS =

VideojuegoSDL2: CMakeFiles/VideojuegoSDL2.dir/src/main.cpp.o
VideojuegoSDL2: CMakeFiles/VideojuegoSDL2.dir/build.make
VideojuegoSDL2: CMakeFiles/VideojuegoSDL2.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable VideojuegoSDL2"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/VideojuegoSDL2.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/VideojuegoSDL2.dir/build: VideojuegoSDL2

.PHONY : CMakeFiles/VideojuegoSDL2.dir/build

CMakeFiles/VideojuegoSDL2.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/VideojuegoSDL2.dir/cmake_clean.cmake
.PHONY : CMakeFiles/VideojuegoSDL2.dir/clean

CMakeFiles/VideojuegoSDL2.dir/depend:
	cd /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2 /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2 /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build /home/cesarvielmas/Programacion-Desarrollo/C++/VideojuegoSDL2/build/CMakeFiles/VideojuegoSDL2.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/VideojuegoSDL2.dir/depend

