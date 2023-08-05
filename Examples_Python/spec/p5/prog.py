from random import randint
import time
from array import *

size = 10000
arr1 = [size]
show = False


def Check(arr):
    for i in range(size):
        if arr[i] > arr[i + 1]: return False
    return True


for x in range(size):
    arr1.append(randint(-10000, 10000))

arr2 = arr1[:]
if (show): print(arr1)

ta = time.perf_counter()
for i in range(size):
    for j in range(size - i):
        if arr1[j] > arr1[j + 1]:
            arr1[j], arr1[j + 1] = arr1[j + 1], arr1[j]
tb = time.perf_counter()

if (show): print(arr1)
print(f"arr1: {Check(arr1)} Время {tb - ta:0.3f} сек")

if (show): print(arr2)
ta = time.perf_counter()
for i in range(size):
    for j in range(size):
        if arr2[j] > arr2[j + 1]:
            arr2[j], arr2[j + 1] = arr2[j + 1], arr2[j]
tb = time.perf_counter()

if (show): print(arr2)
print(f"arr2: {Check(arr2)} Время {tb - ta:0.3f} сек")