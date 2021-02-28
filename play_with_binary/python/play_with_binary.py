import struct

#// Read a large big-endian binary file
#// https://stackoverflow.com/questions/40397731/read-a-large-big-endian-binary-file
#// numpy.fromfile(filename, dtype='>f') for big-endian.


#// Run as 
#// python -c "import os, sys; sys.path.append(os.path.abspath('python')); from play_with_binary import readBinFile; readBinFile('data/float_utf8_.898.bin')"
#
#// cf: How to import other Python files?
#// https://stackoverflow.com/questions/2349991/how-to-import-other-python-files

def float2bytes(floatValue):
  #// 'f' indicates 'float'.
  return bytearray(struct.pack('f', floatValue))


#// 'ascii'
def readBinFile(fileName, encoding='utf-8'):

  with open(fileName, 'r', encoding=encoding) as file:
    print(file.read())


def test():
  fileName = 'data/test_utf8.bin'
  encoding = 'utf-8'
  print(fileName, encoding)
  readBinFile(fileName, encoding)
  encoding = 'ascii'
  print(fileName, encoding)
  readBinFile(fileName, encoding)


  fileName = 'data/test_ascii.bin'
  encoding = 'utf-8'
  print(fileName, encoding)
  readBinFile(fileName, encoding)
  encoding = 'ascii'
  print(fileName, encoding)
  readBinFile(fileName, encoding)

