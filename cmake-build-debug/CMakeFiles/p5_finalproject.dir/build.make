# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.13

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
CMAKE_COMMAND = /Applications/CLion.app/Contents/bin/cmake/mac/bin/cmake

# The command to remove a file.
RM = /Applications/CLion.app/Contents/bin/cmake/mac/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /Users/MinJaeLee/cs184/p5-finalproject

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/p5_finalproject.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/p5_finalproject.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/p5_finalproject.dir/flags.make

CMakeFiles/p5_finalproject.dir/main.cpp.o: CMakeFiles/p5_finalproject.dir/flags.make
CMakeFiles/p5_finalproject.dir/main.cpp.o: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/p5_finalproject.dir/main.cpp.o"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/p5_finalproject.dir/main.cpp.o -c /Users/MinJaeLee/cs184/p5-finalproject/main.cpp

CMakeFiles/p5_finalproject.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/p5_finalproject.dir/main.cpp.i"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /Users/MinJaeLee/cs184/p5-finalproject/main.cpp > CMakeFiles/p5_finalproject.dir/main.cpp.i

CMakeFiles/p5_finalproject.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/p5_finalproject.dir/main.cpp.s"
	/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /Users/MinJaeLee/cs184/p5-finalproject/main.cpp -o CMakeFiles/p5_finalproject.dir/main.cpp.s

# Object files for target p5_finalproject
p5_finalproject_OBJECTS = \
"CMakeFiles/p5_finalproject.dir/main.cpp.o"

# External object files for target p5_finalproject
p5_finalproject_EXTERNAL_OBJECTS =

p5_finalproject: CMakeFiles/p5_finalproject.dir/main.cpp.o
p5_finalproject: CMakeFiles/p5_finalproject.dir/build.make
p5_finalproject: CMakeFiles/p5_finalproject.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable p5_finalproject"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/p5_finalproject.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/p5_finalproject.dir/build: p5_finalproject

.PHONY : CMakeFiles/p5_finalproject.dir/build

CMakeFiles/p5_finalproject.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/p5_finalproject.dir/cmake_clean.cmake
.PHONY : CMakeFiles/p5_finalproject.dir/clean

CMakeFiles/p5_finalproject.dir/depend:
	cd /Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /Users/MinJaeLee/cs184/p5-finalproject /Users/MinJaeLee/cs184/p5-finalproject /Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug /Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug /Users/MinJaeLee/cs184/p5-finalproject/cmake-build-debug/CMakeFiles/p5_finalproject.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/p5_finalproject.dir/depend

