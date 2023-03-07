# Install script for directory: /home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "/usr/local")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Install shared libraries without execute permission?
if(NOT DEFINED CMAKE_INSTALL_SO_NO_EXE)
  set(CMAKE_INSTALL_SO_NO_EXE "1")
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/OpenXLSX/headers" TYPE FILE FILES "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/LibXLS/OpenXLSX-Exports.hpp")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/OpenXLSX/headers" TYPE FILE FILES
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/IZipArchive.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCell.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCellIterator.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCellRange.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCellReference.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCellValue.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLColor.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLColumn.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLCommandQuery.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLConstants.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLContentTypes.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLDateTime.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLDocument.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLException.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLFormula.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLIterator.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLProperties.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLRelationships.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLRow.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLRowData.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLSharedStrings.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLSheet.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLWorkbook.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLXmlData.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLXmlFile.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLXmlParser.hpp"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/headers/XLZipArchive.hpp"
    )
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include/OpenXLSX" TYPE FILE FILES "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/OpenXLSX.hpp")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xlibx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY FILES "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/output/libOpenXLSX.a")
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX" TYPE FILE FILES
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/LibXLS/OpenXLSXConfig.cmake"
    "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/LibXLS/OpenXLSX/OpenXLSXConfigVersion.cmake"
    )
endif()

if("x${CMAKE_INSTALL_COMPONENT}x" STREQUAL "xUnspecifiedx" OR NOT CMAKE_INSTALL_COMPONENT)
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX/OpenXLSXTargets.cmake")
    file(DIFFERENT EXPORT_FILE_CHANGED FILES
         "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX/OpenXLSXTargets.cmake"
         "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/LibXLS/CMakeFiles/Export/lib/cmake/OpenXLSX/OpenXLSXTargets.cmake")
    if(EXPORT_FILE_CHANGED)
      file(GLOB OLD_CONFIG_FILES "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX/OpenXLSXTargets-*.cmake")
      if(OLD_CONFIG_FILES)
        message(STATUS "Old export file \"$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX/OpenXLSXTargets.cmake\" will be replaced.  Removing files [${OLD_CONFIG_FILES}].")
        file(REMOVE ${OLD_CONFIG_FILES})
      endif()
    endif()
  endif()
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX" TYPE FILE FILES "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/LibXLS/CMakeFiles/Export/lib/cmake/OpenXLSX/OpenXLSXTargets.cmake")
  if("${CMAKE_INSTALL_CONFIG_NAME}" MATCHES "^()$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/OpenXLSX" TYPE FILE FILES "/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Build/LibXLS/CMakeFiles/Export/lib/cmake/OpenXLSX/OpenXLSXTargets-noconfig.cmake")
  endif()
endif()

