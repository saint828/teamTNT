#!/usr/bin/env python

import os
import sys
import numpy as np
import scipy.io.wavfile as wav
import scipy.signal as sig

def wavread(filename):
    fs, y = wav.read(filename)
    if len(y.shape) > 1:
        y = np.mean(y, axis = 1) / 32768
    else:
        y = y / 32768
    return fs, y

def wavwrite(filename, fs, y):
    y = (y * 32768).astype("i2")
    wav.write(filename, fs, y)

if __name__ == "__main__":
    dir = os.getcwd()
    fs1, x = wavread(dir + "/monaural/" + sys.argv[1]) # 16bit モノラル
    fs2, h = wavread(dir + "/impulse/church_impulse.wav") # 16bit モノラル
    if fs1 == fs2:
        y = sig.convolve(x, h)
        y = 0.9 * y / np.max(y)
        wavwrite(dir + "/rev_monaural/" + "rev_" + sys.argv[1], fs1, y)
    else:
        print("サンプリング周波数が一致しません")