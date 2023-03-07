cmake_minimum_required(VERSION 3.0.0)
project(VideojuegoSDL2 VERSION 0.1.0)

add_executable(VideojuegoSDL2 src/main.cpp)
target_link_libraries(VideojuegoSDL2 SDL2main SDL2)
