# -*- coding: utf-8 -*-

'''
Please create a "Words.txt" inside "Data" folder and 
write down your words for this mini game. 
* This file must save with UTF-8 encoding, no sig.
* Every words MUST follow the same length as the orignal one.
* The orignal EnglishPlay_Data.dat must place in the "Data" folder.
'''
import codecs

def get_str_len(fs):
    pos = fs.tell()
    result = 0
    while fs.read(1) != '\x00':
        result += 1
    fs.seek(pos, 0)
    return result

def read_words(path):
    words = codecs.open(path, 'r', 'utf-8').read().split('\n')
    return words

def import_ans(path, words, words_count, magic_pos, magic):
    if len(words) != words_count:
        raise ValueError("Words count error. Except: %d, actual: %d"%(words_count, len(words)))

    fs = open(path, 'rb+')

    fs.seek(magic_pos, 0)
    if fs.read(len(magic)) != magic:
        raise ValueError("Input file error. Not %s at 0x%x."%(magic, magic_pos))
    fs.seek(1, 1)

    for word in words:
        except_len = get_str_len(fs)
        data = word.encode('utf-8')
        if len(data) != except_len:
            raise ValueError("Word length error. Except: %d, actual: %d. Position: 0x%x"%(except_len, len(data), fs.tell()))
        fs.write(data)
        fs.write('\x00')
        fs.flush()
    
    fs.close()

if '__main__' == __name__:
    words = read_words("Data/Words.txt")
    import_ans("Data/EnglishPlay_Data.dat", words[:42], 42, 0x5A, "JPN_ANS")
    import_ans("Data/EnglishPlay_Data.dat", words[42:], 24, 0x37D, "JPN_ANS_LV1")